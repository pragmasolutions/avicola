CREATE PROCEDURE [dbo].[Report_BatchObservation]
	@BatchId UNIQUEIDENTIFIER,
	@StageId UNIQUEIDENTIFIER
AS
BEGIN
	
	DECLARE @StageName VARCHAR(50)
	SET @StageName = (SELECT TOP 1 LOWER(Name) FROM Stage WHERE Id = @StageId)
	
	SELECT 
		B.Number,
		BO.CreatedDate,
		BO.Content
	FROM BatchObservation BO INNER JOIN Batch B
		ON BO.BatchId = B.Id INNER JOIN GeneticLine GL 
		ON B.GeneticLineId = GL.Id		
	WHERE B.Id = BatchId 
		--AND ((@StageName = 'cría y precría' AND BO.CreatedDate < DATEADD(DAY, (GL.WeeksInBreeding * 7), B.DateOfBirth))
		--OR (@StageName = 'postura' AND BO.CreatedDate > DATEADD(DAY, (GL.WeeksInBreeding * 7), B.DateOfBirth)))
	ORDER BY BO.CreatedDate 
END
GO
