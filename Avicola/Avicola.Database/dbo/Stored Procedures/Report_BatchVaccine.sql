CREATE PROCEDURE [dbo].[Report_BatchVaccine]
	@BatchId UNIQUEIDENTIFIER,
	@DateFrom DATETIME = NULL,
	@DateTo DATETIME = NULL
AS
BEGIN
	
	
	SELECT 
		B.Number,
		BV.CreatedDate,
		BV.StartDate,
		BV.EndDate,
		Vaccine = V.Name
	FROM BatchVaccine BV INNER JOIN Batch B
		ON BV.BatchId = B.Id INNER JOIN GeneticLine GL 
		ON B.GeneticLineId = GL.Id INNER JOIN Vaccine V
		ON BV.VaccineId = V.Id
	WHERE B.Id = BatchId 
	AND (@DateFrom IS NULL OR BV.StartDate >= @DateFrom) 
	AND (@DateTo IS NULL OR BV.StartDate <= @DateTo)
		
	ORDER BY BV.CreatedDate 
END