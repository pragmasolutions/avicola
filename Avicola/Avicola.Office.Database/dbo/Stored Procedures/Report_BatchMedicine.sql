CREATE PROCEDURE [dbo].[Report_BatchMedicine]
	@BatchId UNIQUEIDENTIFIER,
	@StageId UNIQUEIDENTIFIER
AS
BEGIN
	
	DECLARE @StageName VARCHAR(50)
	SET @StageName = (SELECT TOP 1 LOWER(Name) FROM Stage WHERE Id = @StageId)
	
	SELECT 
		B.Number,
		BM.CreatedDate,
		BM.StartDate,
		BM.EndDate,
		Medicine = M.Name
	FROM BatchMedicine BM INNER JOIN Batch B
		ON BM.BatchId = B.Id INNER JOIN GeneticLine GL 
		ON B.GeneticLineId = GL.Id INNER JOIN Medicine M
		ON BM.MedicineId = M.Id
	WHERE B.Id = BatchId 
		AND ((@StageName = 'cría y precría' AND BM.CreatedDate < DATEADD(DAY, (GL.WeeksInBreeding * 7), B.DateOfBirth))
		OR (@StageName = 'postura' AND BM.CreatedDate > DATEADD(DAY, (GL.WeeksInBreeding * 7), B.DateOfBirth)))
	ORDER BY BM.CreatedDate 
END
GO
