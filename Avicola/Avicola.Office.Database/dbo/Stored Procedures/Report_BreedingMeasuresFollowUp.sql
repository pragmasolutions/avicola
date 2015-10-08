CREATE PROCEDURE [dbo].[Report_BreedingMeasuresFollowUp]
	@BatchId UNIQUEIDENTIFIER,
	@DateFrom DATETIME = NULL,
	@DateTo DATETIME = NULL

AS
BEGIN
	DECLARE @Dias TABLE
	(
		Fecha datetime
	)

	DECLARE @StageId UNIQUEIDENTIFIER 
	SET @StageId = '096debd6-c537-4569-8b97-53a3c3e82a39'

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
			@WeeksInBreeding = GL.WeeksInBreeding,
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

	SET @EndDate = (SELECT DATEADD(DAY, -1, DATEADD(WEEK, @WeeksInBreeding, @StartDate)))

	INSERT INTO @Dias (Fecha)
	SELECT thedate FROM dbo.ExplodeDates(@StartDate, @EndDate) as d


	INSERT INTO @Items (Secuencia, Fecha)
	SELECT ROW_NUMBER() OVER(ORDER BY Fecha ASC),
		Fecha 
	FROM @Dias
	ORDER BY Fecha ASC


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
	WHERE SGL.StageId = @StageId
		AND M.BatchId = @BatchId
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
	WHERE SGL.StageId = @StageId
		AND M.BatchId = @BatchId
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
	WHERE SGL.StageId = @StageId
		AND M.BatchId = @BatchId
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
	WHERE SGL.StageId = @StageId
		AND M.BatchId = @BatchId
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
	WHERE SGL.StageId = @StageId
		AND M.BatchId = @BatchId
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
	WHERE SGL.StageId = @StageId
		AND M.BatchId = @BatchId
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