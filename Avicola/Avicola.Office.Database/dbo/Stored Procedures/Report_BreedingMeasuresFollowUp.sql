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
		ConsumoRealPorAve decimal(18,2),
		Stock decimal(18,2),
		Mes varchar(14),
		DiaDelMes int
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

	DECLARE @PostureDate date
	DECLARE @BreedingDate date
	DECLARE @RebreedingDate date
	DECLARE @PostureInitialBirds decimal(18,2)
	DECLARE @PostureInitialFood decimal(18,2)
	DECLARE @BreedingStageId UNIQUEIDENTIFIER = '0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F'
	DECLARE @ReBreedingStageId UNIQUEIDENTIFIER = '50F38EC7-4A04-4A9E-B2E4-6B9BC59D57DA'
	DECLARE @PostureStageId UNIQUEIDENTIFIER = '0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F'

	SELECT @BreedingDate = B.BreedingDate,@RebreedingDate = B.ReBreedingDate,@PostureDate = B.PostureDate FROM Batch B WHERE B.Id = @BatchId 

				SELECT @PostureInitialBirds = SUM(BB.InitialBirds) FROM BatchBarn BB 
													INNER JOIN Barn B
														ON BB.BarnId = B.Id

	WHERE BB.BatchId = @BatchId AND B.StageId = @PostureStageId

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

	DECLARE @FoodConsumption TABLE
	(
		DateLimit datetime,
		ConsumptionPerBirdPorDay decimal(18,2)
	)

	INSERT INTO @FoodConsumption (DateLimit, ConsumptionPerBirdPorDay)
	SELECT DateLimit = @RebreedingDate,ConsumptionPerBirdPorDay = ((SG.FoodEntryDuringPeriod - SG.CurrentFoodStock) / ((SG.StageFromIFinalBirds + SG.StageFromIFinalBirds) / 2)) / DATEDIFF(DAY,@BreedingDate,@RebreedingDate)
	FROM StageChange SG
	WHERE SG.BatchId = @BatchId
	AND SG.StageToId = @ReBreedingStageId
	UNION
	SELECT DateLimit = @PostureDate, ConsumptionPerBirdPorDay = ((SG.FoodEntryDuringPeriod - SG.CurrentFoodStock) / ((SG.StageFromIFinalBirds + SG.StageFromIFinalBirds) / 2)) / DATEDIFF(DAY,@RebreedingDate,@PostureDate)
	FROM StageChange SG
	WHERE SG.BatchId = @BatchId
	AND SG.StageToId = @PostureStageId
	UNION
	SELECT DateLimit = SE.Date, ConsumptionPerBirdPorDay = (ISNULL((FE.TotalEntryAmount + (CASE WHEN PSE.Date IS NULL THEN PS.CurrentFoodStock ELSE 0 END)) / BD.BirdsAverage,0) / (CASE WHEN PSE.Date IS NULL THEN DATEDIFF(DAY,@PostureDate,SE.Date) ELSE DATEDIFF(DAY,PSE.Date,SE.Date) END))
	FROM SiloEmptying SE 
		   OUTER APPLY(SELECT TOP 1  SG.CurrentFoodStock FROM StageChange SG WHERE SG.BatchId = @BatchId AND SG.StageToId = @PostureStageId) PS	
		   OUTER APPLY(SELECT TOP 1 PSE.Date FROM SiloEmptying PSE  WHERE PSE.Date < SE.Date AND SE.BatchId = @BatchId ORDER BY PSE.Date) PSE	
		   OUTER APPLY(SELECT TotalEntryAmount = SUM(FE.Amount) FROM @FoodEntryDuringPosture FE WHERE  FE.Date BETWEEN  ISNULL(PSE.Date,@PostureDate) AND SE.Date) FE	
		   OUTER APPLY(SELECT BirdsAverage = (@PostureInitialBirds + (@PostureInitialBirds - ISNULL(SUM(BD.Amount),0))) / 2 FROM @BirdsDeadDuringPosture BD WHERE BD.Date BETWEEN  ISNULL(PSE.Date,@PostureDate) AND SE.Date) BD			
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
	SET ConsumoRealPorAve = FC.ConsumptionPerBirdPorDay
	FROM @Items I
		 OUTER APPLY(SELECT * FROM @FoodConsumption FC WHERE I.Fecha <= FC.DateLimit) FC
		
	UPDATE I
	SET Stock = @StartingFood + ISNULL((SELECT ISNULL(SUM(I2.IngresoAlimento), 0) - ISNULL(SUM(I2.ConsumoAlimento), 0)
					FROM @Items I2
					WHERE I.Secuencia >= I2.Secuencia), 0)
	FROM @Items I

	UPDATE @Items
	SET Mes = CONVERT(CHAR(4), Fecha, 100) + CONVERT(CHAR(4), Fecha, 120),
		DiaDelMes = DATEPART(DAY, Fecha)


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