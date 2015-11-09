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
		ConsumoRealPorAve decimal(18,6),
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

	SELECT @StartDate = B.DateOfBirth,
			@InitialBirds = B.InitialBirds,
			@StartingFood = B.StartingFood,
			@StartingFoodClass = FC.Name,
			@BatchNumber = B.Number,
			@DateOfBirth = B.DateOfBirth,
			@GeneticLine = GL.Name
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

	DECLARE @PostureDate date
	DECLARE @BreedingDate date
	DECLARE @RebreedingDate date
	DECLARE @BatchInitialFood decimal(18,2)
	DECLARE @PostureInitialBirds decimal(18,2)
	DECLARE @PostureInitialFood decimal(18,2)
	DECLARE @BreedingStageId UNIQUEIDENTIFIER = '0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F'
	DECLARE @ReBreedingStageId UNIQUEIDENTIFIER = '50F38EC7-4A04-4A9E-B2E4-6B9BC59D57DA'
	DECLARE @PostureStageId UNIQUEIDENTIFIER = '0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F'

	--CARGAR DATOS DEL LOTE
	SELECT @BreedingDate = B.BreedingDate,
		   @RebreedingDate = B.ReBreedingDate,
		   @PostureDate = B.PostureDate, 
		   @BatchInitialFood = B.StartingFood  
	FROM Batch B WHERE B.Id = @BatchId 

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
	DECLARE @FoodConsumption TABLE
	(
	    DateFrom datetime,
		DateLimit datetime,
		ConsumptionPerDay decimal(18,6),
		ConsumptionPerBirdPorDay decimal(18,6)
	)

	INSERT INTO @FoodConsumption (DateFrom, DateLimit,ConsumptionPerDay, ConsumptionPerBirdPorDay)
	SELECT DateFrom = @BreedingDate, DateLimit = @RebreedingDate,ConsumptionPorDay = (SG.FoodEntryDuringPeriod + @StartingFood - SG.CurrentFoodStock) / (DATEDIFF(DAY,@BreedingDate,@RebreedingDate) + 1),ConsumptionPerBirdPorDay = ((SG.FoodEntryDuringPeriod + @StartingFood - SG.CurrentFoodStock) / ((SG.StageFromIFinalBirds + SG.StageFromIFinalBirds) / 2)) / (DATEDIFF(DAY,@BreedingDate,@RebreedingDate) + 1)
	FROM StageChange SG
	WHERE SG.BatchId = @BatchId
	AND SG.StageToId = @ReBreedingStageId
	UNION
	SELECT DateFrom = @RebreedingDate, DateLimit = @PostureDate,ConsumptionPorDay = (SG.FoodEntryDuringPeriod - SG.CurrentFoodStock) / (DATEDIFF(DAY,@RebreedingDate,@PostureDate) + 1), ConsumptionPerBirdPorDay = ((SG.FoodEntryDuringPeriod - SG.CurrentFoodStock) / ((SG.StageFromIFinalBirds + SG.StageFromIFinalBirds) / 2)) / (DATEDIFF(DAY,@RebreedingDate,@PostureDate) + 1)
	FROM StageChange SG
	WHERE SG.BatchId = @BatchId
	AND SG.StageToId = @PostureStageId
	UNION
	SELECT DateFrom = (CASE WHEN PSE.Date IS NULL THEN @PostureDate ELSE PSE.Date END), DateLimit = SE.Date, 
	ConsumptionPerDay = TEA.TotalEntryAmount / DC.DaysCount,
	ConsumptionPerBirdPorDay = TEA.TotalEntryAmount / BD.BirdsAverage / DC.DaysCount
	FROM SiloEmptying SE 
		   
		   OUTER APPLY(SELECT TOP 1  SG.CurrentFoodStock FROM StageChange SG WHERE SG.BatchId = @BatchId AND SG.StageToId = @PostureStageId) PS	
		   OUTER APPLY(SELECT TOP 1 PSE.Date FROM SiloEmptying PSE  WHERE PSE.Date < SE.Date AND PSE.BatchId = @BatchId ORDER BY PSE.Date) PSE	
		   OUTER APPLY(SELECT TotalEntryAmount = SUM(FE.Amount) FROM @FoodEntryDuringPosture FE WHERE  FE.Date BETWEEN  ISNULL(PSE.Date,@PostureDate) AND SE.Date) FE	
		   OUTER APPLY(SELECT BirdsAverage = (@PostureInitialBirds + (@PostureInitialBirds - ISNULL(SUM(BD.Amount),0))) / 2 FROM @BirdsDeadDuringPosture BD WHERE BD.Date BETWEEN  ISNULL(PSE.Date,@PostureDate) AND SE.Date) BD			

		   CROSS APPLY (SELECT TotalEntryAmount = ISNULL((FE.TotalEntryAmount + (CASE WHEN PSE.Date IS NULL THEN (CASE WHEN PS.CurrentFoodStock IS NULL THEN @BatchInitialFood ELSE PS.CurrentFoodStock END) ELSE 0 END)),0)) TEA
		   CROSS APPLY (SELECT DaysCount = (CASE WHEN PSE.Date IS NULL THEN DATEDIFF(DAY,CONVERT(date, @PostureDate),CONVERT(date, SE.Date)) ELSE DATEDIFF(DAY,CONVERT(date, PSE.Date),CONVERT(date, SE.Date)) END) + 1) DC
	WHERE SE.IsDeleted = 0 AND  SE.BatchId = @BatchId

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
	SET ConsumoRealPorAve = ISNULL(FC.ConsumptionPerBirdPorDay,0),ConsumoDiario = ISNULL(FC.ConsumptionPerDay,0)
	FROM @Items I
		 OUTER APPLY(SELECT * FROM @FoodConsumption FC WHERE I.Fecha >= FC.DateFrom AND I.Fecha <= FC.DateLimit) FC
		
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


	SELECT I.*,
			FechaNacimiento = @StartingFoodClass,
			Lote = @BatchNumber,
			LineaGenetica = @GeneticLine,
			Clase = @StartingFoodClass,
			AvesAlInicio = @InitialBirds,
			AlimentoAlInicio = @StartingFood
	FROM @Items I
	WHERE (@DateFrom IS NULL OR I.Fecha >= @DateFrom) 
		AND (@DateTo IS NULL OR I.Fecha <= @DateTo)

END