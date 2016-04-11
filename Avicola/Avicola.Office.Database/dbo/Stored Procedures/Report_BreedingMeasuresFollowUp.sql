CREATE PROCEDURE [dbo].[Report_BreedingMeasuresFollowUp]
	@BatchId UNIQUEIDENTIFIER,
	@DateFrom DATETIME2 = NULL,
	@DateTo DATETIME2 = NULL

AS
BEGIN
	DECLARE @Dias TABLE
	(
		Fecha datetime
	)

	DECLARE @Items TABLE
	(
		Stage varchar(200),
		Semana int,
		Dia int,
		Fecha datetime,
		Secuencia int,	
		Mortandad int,
		Descarte int,
		TotalEliminado int,
		Aves int,
		PesoDelAve decimal(18,2),
		IngresoAlimento decimal(18,2),
		ClaseAlimento varchar(200),
		IngresoAlimentoAcumulado decimal(18,2),
		ConsumoAlimento decimal(18,2),
		ConsumoAlimentoAcumulado decimal(18,2),
		ConsumoPorAve int,
		ConsumoTotalPorDiaPerido decimal(18,6),
		Stock decimal(18,2),
		Mes varchar(14),
		DiaDelMes int,
		AlimentoInicialMes decimal(18,2),
		ConsumoTotalMes decimal(18,6),
		ConsumoDiario decimal(18,6)
	)

	DECLARE @StartDate DATETIME
	DECLARE @WeeksInBreeding INT
	DECLARE @InitialBirds INT
	DECLARE @StartingFood DECIMAL(18,2)
	DECLARE @EndDate DATETIME
	DECLARE @StartingFoodClass varchar(200)
	DECLARE @BatchNumber int
	DECLARE @DateOfBirth datetime
	DECLARE @GeneticLine varchar(200)
	DECLARE @PostureDate date
	DECLARE @BreedingDate date
	DECLARE @RebreedingDate date

	SELECT @StartDate = B.DateOfBirth,
			@InitialBirds = B.InitialBirds,
			@StartingFood = B.StartingFood,
			@StartingFoodClass = FC.Name,
			@BatchNumber = B.Number,
			@DateOfBirth = B.DateOfBirth,
			@GeneticLine = GL.Name,
			@BreedingDate = B.BreedingDate,
		    @RebreedingDate = B.ReBreedingDate,
		    @PostureDate = B.PostureDate 
	FROM Batch B
		INNER JOIN GeneticLine GL
			ON B.GeneticLineId = GL.Id
		INNER JOIN FoodClass FC
			ON B.FoodClassId = FC.Id
	WHERE B.Id = @BatchId

	SET @EndDate = (SELECT DATEADD(DAY, -1, DATEADD(WEEK, 120, @StartDate)))

	INSERT INTO @Dias (Fecha)
	SELECT thedate FROM dbo.ExplodeDates(@StartDate, @EndDate) as d
	
	INSERT INTO @Items (Secuencia, Fecha)
	SELECT ROW_NUMBER() OVER(ORDER BY Fecha ASC),
		Fecha 
	FROM @Dias
	ORDER BY Fecha ASC

	/* ----------------- CALCULO DE CONSUMO -----------------  */
	
	DECLARE @PostureInitialBirds decimal(18,2)
	DECLARE @PostureInitialFood decimal(18,2)
	DECLARE @BreedingStageId UNIQUEIDENTIFIER = '0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F'
	DECLARE @ReBreedingStageId UNIQUEIDENTIFIER = '50F38EC7-4A04-4A9E-B2E4-6B9BC59D57DA'
	DECLARE @PostureStageId UNIQUEIDENTIFIER = '0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F'

	--CALCULAR ALIMENTO INICIAL POSTURA
	SELECT @PostureInitialFood = CurrentFoodStock FROM StageChange WHERE BatchId = @BatchId AND StageToId = @PostureStageId AND IsDeleted = 0
	SELECT @PostureInitialFood = COALESCE (@PostureInitialFood, @StartingFood, 0)

	--CALCULAR AVES INICIALES DE POSTURA
	SELECT @PostureInitialBirds = SUM(BB.InitialBirds) 
	FROM BatchBarn BB 
		INNER JOIN Barn B
				ON BB.BarnId = B.Id
	WHERE BB.BatchId = @BatchId AND B.StageId = @PostureStageId AND BB.IsDeleted = 0

	--CALCULAR ALIMENTO INGRESADO EN POSTURA
	DECLARE @FoodEntryDuringPosture TABLE
	(
		Date datetime,
		Amount decimal(18,2)
	)

	INSERT INTO @FoodEntryDuringPosture (Date, Amount)
	SELECT M.Date,M.Value FROM Measure M
					INNER JOIN StandardItem SI
						ON M.StandardItemId = SI.Id
					INNER JOIN StandardGeneticLine SGL 
						ON SI.StandardGeneticLineId = SGL.Id
					INNER JOIN Standard S
						ON SGL.StandardId = S.Id
	WHERE M.BatchId = @BatchId
			AND S.Name = 'Ingreso de Alimento'
			AND M.Date >= @PostureDate
			AND M.IsDeleted = 0
			AND SI.IsDeleted = 0
			AND SGL.IsDeleted = 0

    --CALCULAR AVES MUERTAS EN POSTURA
	DECLARE @BirdsDeadDuringPosture TABLE
	(
		Date datetime,
		Amount decimal(18,2)
	)

	INSERT INTO @BirdsDeadDuringPosture (Date, Amount)
	SELECT M.Date,M.Value FROM Measure M
						INNER JOIN StandardItem SI
							ON M.StandardItemId = SI.Id
						INNER JOIN StandardGeneticLine SGL 
							ON SI.StandardGeneticLineId = SGL.Id
						INNER JOIN Standard S
							ON SGL.StandardId = S.Id
	WHERE M.BatchId = @BatchId
			AND (S.Name = 'Mortandad' OR S.Name = 'Descarte')
			AND M.Date >= @PostureDate
			AND M.IsDeleted = 0
			AND SI.IsDeleted = 0
			AND SGL.IsDeleted = 0

    --CARGAR TABLA TEMPORAL CON CONSUMOS POR ETAPAS Y VACIAMIENTOS DE SILO
	DECLARE @ConsumoAlimentoPorPeriodo TABLE
	(
	    Desde datetime,
		Hasta datetime,
		ConsumoDiario decimal(18,6),
		ConsumoTotal decimal(18,6)
	)

	;WITH ConsumoCTE AS
	( 
		SELECT 

		Orden = ROW_NUMBER() OVER(ORDER BY PDM.PrimerDiaDelMes ASC),
		DateFrom = PDM.PrimerDiaDelMes, 
		DateTo = EOMONTH(PDM.PrimerDiaDelMes), 
		IngresoAlimentoDelMes = FE.TotalEntryAmount,
		DiasDelMes = DDM.DiasDelMes,
		DiasHastaVaciamiento = DHV.DiasHastaVaciamiento,
		PrimerDiaDelMes = PDM.PrimerDiaDelMes

		FROM SiloEmptying SE 

			   OUTER APPLY(SELECT TOP 1  SG.CurrentFoodStock FROM StageChange SG WHERE SG.BatchId = @BatchId AND SG.StageToId = @PostureStageId) PS	
			   OUTER APPLY(SELECT TOP 1 PSE.Date FROM SiloEmptying PSE  WHERE PSE.Date < SE.Date AND PSE.BatchId = @BatchId ORDER BY PSE.Date DESC) PSE	
			   OUTER APPLY(SELECT DateFrom = CASE WHEN PSE.Date IS NULL THEN @PostureDate ELSE PSE.Date END) DF
			   
			   OUTER APPLY (SELECT DiasDelMes = DAY(EOMONTH(DF.DateFrom))) DDM
			   OUTER APPLY (SELECT PrimerDiaDelMes = DATEFROMPARTS(YEAR(ISNULL(PSE.Date,@PostureDate)),MONTH(ISNULL(PSE.Date,@PostureDate)),1)) PDM
			   OUTER APPLY (SELECT DiasHastaVaciamiento = DATEDIFF(DAY,PDM.PrimerDiaDelMes,CONVERT(date, SE.Date)) + 1) DHV
			   OUTER APPLY(SELECT TotalEntryAmount = SUM(FE.Amount) FROM @FoodEntryDuringPosture FE WHERE  FE.Date BETWEEN  ISNULL(PSE.Date,@PostureDate) AND SE.Date) FE	
		
		WHERE SE.IsDeleted = 0 AND  SE.BatchId = @BatchId
	)

	,TempCTE AS
	(
		SELECT C.*, 
			   AlimentoInicialDelMes = @PostureInitialFood,
			   StockFinal = CAST(((@PostureInitialFood + C.IngresoAlimentoDelMes) - (((@PostureInitialFood + C.IngresoAlimentoDelMes) / C.DiasHastaVaciamiento) * C.DiasDelMes)) AS decimal(18,2)),
			   ConsumoDelMes = (((@PostureInitialFood + C.IngresoAlimentoDelMes) / C.DiasHastaVaciamiento) * C.DiasDelMes),
			   ConsumoVaciamiento = @PostureInitialFood + C.IngresoAlimentoDelMes
		FROM ConsumoCTE C 
		WHERE C.Orden = 1
		UNION ALL
		SELECT C.*,  
			   AlimentoInicialDelMes = T.StockFinal,
			   StockFinal = CAST(((T.StockFinal + C.IngresoAlimentoDelMes) - (((T.StockFinal + C.IngresoAlimentoDelMes) / C.DiasHastaVaciamiento) * C.DiasDelMes)) AS decimal(18,2)),
			   ConsumoDelMes = (((T.StockFinal + C.IngresoAlimentoDelMes) / C.DiasHastaVaciamiento) * C.DiasDelMes),
			   ConsumoVaciamiento = T.StockFinal + C.IngresoAlimentoDelMes
		FROM ConsumoCTE C
				INNER JOIN TempCTE T
					ON T.Orden + 1 = C.Orden
	)

	INSERT INTO @ConsumoAlimentoPorPeriodo (Desde, Hasta,ConsumoTotal,ConsumoDiario)
	SELECT Desde = @BreedingDate, Hasta = @RebreedingDate,ConsumoTotal = SG.FoodEntryDuringPeriod + @StartingFood - SG.CurrentFoodStock, ConsumoDiario = (SG.FoodEntryDuringPeriod + @StartingFood - SG.CurrentFoodStock) / (DATEDIFF(DAY,@BreedingDate,@RebreedingDate) + 1)
	FROM StageChange SG
	WHERE SG.BatchId = @BatchId
	AND SG.StageToId = @ReBreedingStageId
	UNION
	SELECT  Desde = @RebreedingDate, Hasta = @PostureDate,ConsumoTotal = SG.FoodEntryDuringPeriod - SG.CurrentFoodStock , ConsumoDiario = (SG.FoodEntryDuringPeriod - SG.CurrentFoodStock) / (DATEDIFF(DAY,@RebreedingDate,@PostureDate) + 1)
	FROM StageChange SG
	WHERE SG.BatchId = @BatchId
	AND SG.StageToId = @PostureStageId
	UNION
	SELECT Desde = DateFrom,Hasta = DateTo,ConsumoTotal = ConsumoDelMes, ConsumoDiario = ConsumoDelMes / DiasDelMes
	FROM TempCTE

	UPDATE @Items
	SET Semana = CEILING(CAST(Secuencia as decimal) / CAST(7 as decimal))

	UPDATE @Items
	SET Dia = 7 - ((Semana * 7) - Secuencia)
	
	UPDATE @Items
	SET Mortandad = M.Value
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
		INNER JOIN StandardGeneticLine SGL 
			ON SI.StandardGeneticLineId = SGL.Id
		INNER JOIN Standard S
			ON SGL.StandardId = S.Id
		INNER JOIN @Items I
			ON M.[Date] = I.Fecha
	WHERE M.BatchId = @BatchId
		AND S.Name = 'Mortandad'
		AND M.IsDeleted = 0
		AND SI.IsDeleted = 0
		AND SGL.IsDeleted = 0

	UPDATE @Items
	SET Mortandad = ISNULL(Mortandad, 0)
	
	UPDATE @Items
	SET Descarte = M.Value
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
		INNER JOIN StandardGeneticLine SGL 
			ON SI.StandardGeneticLineId = SGL.Id
		INNER JOIN Standard S
			ON SGL.StandardId = S.Id
		INNER JOIN @Items I
			ON M.[Date] = I.Fecha
	WHERE M.BatchId = @BatchId
		AND S.Name = 'Descarte'
		AND M.IsDeleted = 0
		AND SI.IsDeleted = 0
		AND SGL.IsDeleted = 0

	UPDATE @Items
	SET Descarte = ISNULL(Descarte, 0)

	UPDATE I
	SET Aves = @InitialBirds 
				- ISNULL((SELECT SUM(I2.Mortandad) 
					FROM @Items I2
					WHERE I.Secuencia >= I2.Secuencia), 0)
				- ISNULL((SELECT SUM(I2.Descarte) 
					FROM @Items I2
					WHERE I.Secuencia >= I2.Secuencia), 0)
	FROM @Items I
	
	UPDATE @Items
	SET PesoDelAve = M.Value
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
		INNER JOIN StandardGeneticLine SGL 
			ON SI.StandardGeneticLineId = SGL.Id
		INNER JOIN Standard S
			ON SGL.StandardId = S.Id
		INNER JOIN @Items I
			ON SI.Sequence * 7 = I.Secuencia
	WHERE M.BatchId = @BatchId
		AND S.Name = 'Peso del Ave'
		AND M.IsDeleted = 0
		AND SI.IsDeleted = 0
		AND SGL.IsDeleted = 0

	UPDATE @Items
	SET TotalEliminado = Mortandad + Descarte
	
	UPDATE @Items
	SET IngresoAlimento = M.Value
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
		INNER JOIN StandardGeneticLine SGL 
			ON SI.StandardGeneticLineId = SGL.Id
		INNER JOIN Standard S
			ON SGL.StandardId = S.Id
		INNER JOIN @Items I
			ON M.[Date] = I.Fecha
	WHERE M.BatchId = @BatchId
		AND S.Name = 'Ingreso de Alimento'
		AND M.IsDeleted = 0
		AND SI.IsDeleted = 0
		AND SGL.IsDeleted = 0

	UPDATE @Items
	SET ClaseAlimento = FC.Name
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
		INNER JOIN StandardGeneticLine SGL 
			ON SI.StandardGeneticLineId = SGL.Id
		INNER JOIN Standard S
			ON SGL.StandardId = S.Id
		INNER JOIN @Items I
			ON M.[Date] = I.Fecha
		INNER JOIN FoodClass FC
			ON M.FoodClassId = FC.Id
	WHERE M.BatchId = @BatchId
		AND S.Name = 'Ingreso de Alimento'
		AND M.IsDeleted = 0
		AND SI.IsDeleted = 0
		AND SGL.IsDeleted = 0

	UPDATE I
	SET IngresoAlimentoAcumulado = ISNULL((SELECT SUM(I2.IngresoAlimento) 
					FROM @Items I2
					WHERE I.Secuencia >= I2.Secuencia), 0)
	FROM @Items I
	
	UPDATE @Items
	SET ConsumoAlimento = M.Value
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
		INNER JOIN StandardGeneticLine SGL 
			ON SI.StandardGeneticLineId = SGL.Id
		INNER JOIN Standard S
			ON SGL.StandardId = S.Id
		INNER JOIN @Items I
			ON M.[Date] = I.Fecha
	WHERE M.BatchId = @BatchId
		AND S.Name = 'Consumo de Alimento'
		AND M.IsDeleted = 0
		AND SI.IsDeleted = 0
		AND SGL.IsDeleted = 0

	UPDATE I
	SET ConsumoAlimentoAcumulado = ISNULL((SELECT SUM(I2.ConsumoAlimento) 
					FROM @Items I2
					WHERE I.Secuencia >= I2.Secuencia), 0)
	FROM @Items I
	
	UPDATE I
	SET ConsumoPorAve = CEILING((ConsumoAlimento * 1000) / Aves)
	FROM @Items I

	UPDATE I
	SET ConsumoTotalPorDiaPerido = ISNULL(FC.ConsumoTotal,0),ConsumoDiario = ISNULL(FC.ConsumoDiario,0)
	FROM @Items I
		 OUTER APPLY(SELECT * FROM @ConsumoAlimentoPorPeriodo FC WHERE I.Fecha >= FC.Desde AND I.Fecha <= FC.Hasta) FC
		
	UPDATE I
	SET Stock = @StartingFood + ISNULL((SELECT ISNULL(SUM(I2.IngresoAlimento), 0) - ISNULL(SUM(I2.ConsumoAlimento), 0) - (ISNULL(SUM(I2.ConsumoDiario), 0))
					FROM @Items I2
					WHERE I.Secuencia >= I2.Secuencia), 0)
	FROM @Items I

	UPDATE @Items
	SET Mes = CONVERT(CHAR(4), Fecha, 100) + CONVERT(CHAR(4), Fecha, 120),
		DiaDelMes = DATEPART(DAY, Fecha)

	--CALCULAR ALIMENTO INICIAL CON STOCK FINAL DEL MES ANTERIOR
	UPDATE I
	SET AlimentoInicialMes = ISNULL((
			  SELECT TOP 1 I2.Stock FROM @Items I2
			  WHERE DATEPART(MONTH,DATEADD(MONTH,-1,I.Fecha)) = DATEPART(MONTH,I2.Fecha)
			  AND DATEPART(YEAR,DATEADD(MONTH,-1,I.Fecha)) = DATEPART(YEAR,I2.Fecha)
			  ORDER BY I2.Fecha DESC), @StartingFood)
	FROM @Items I

	UPDATE I
	SET Stage = (CASE WHEN I.Fecha >= @DateOfBirth AND I.Fecha < @RebreedingDate THEN 'CRÍA' 
	 WHEN I.Fecha >= @RebreedingDate AND I.Fecha < @PostureDate THEN 'RECRÍA' 
	 WHEN I.Fecha >= @PostureDate THEN 'POSTURA' 
	 ELSE NULL END)
	FROM @Items I

	SELECT I.*,
			FechaNacimiento = @DateOfBirth,
			Lote = @BatchNumber,
			LineaGenetica = @GeneticLine,
			Clase = @StartingFoodClass,
			AvesAlInicio = @InitialBirds,
			AlimentoAlInicio = @StartingFood
	FROM @Items I
	WHERE (@DateFrom IS NULL OR I.Fecha >= @DateFrom) 
		AND (@DateTo IS NULL OR I.Fecha <= @DateTo)

END