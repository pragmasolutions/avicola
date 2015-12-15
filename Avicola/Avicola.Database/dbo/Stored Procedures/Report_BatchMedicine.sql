CREATE PROCEDURE [dbo].[Report_BatchMedicine]
	@BatchId UNIQUEIDENTIFIER,
	@DateFrom DATETIME = NULL,
	@DateTo DATETIME = NULL
AS
BEGIN
	
	SELECT 
		B.Number,
		BM.CreatedDate,
		BM.StartDate,
		BM.EndDate,
		Medicine = M.Name,
		BM.Observation
	FROM BatchMedicine BM INNER JOIN Batch B
		ON BM.BatchId = B.Id INNER JOIN GeneticLine GL 
		ON B.GeneticLineId = GL.Id INNER JOIN Medicine M
		ON BM.MedicineId = M.Id
	WHERE B.Id = BatchId 
		AND (@DateFrom IS NULL OR BM.StartDate >= @DateFrom) 
		AND (@DateTo IS NULL OR BM.StartDate <= @DateTo)
	ORDER BY BM.CreatedDate 
END