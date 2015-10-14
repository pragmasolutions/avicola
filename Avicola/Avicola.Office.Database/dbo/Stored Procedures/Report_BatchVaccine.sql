CREATE PROCEDURE [dbo].[Report_BatchVaccine]
	@BatchId UNIQUEIDENTIFIER,
	@StageId UNIQUEIDENTIFIER
AS
BEGIN
	
	DECLARE @StageName VARCHAR(50)
	SET @StageName = (SELECT TOP 1 LOWER(Name) FROM Stage WHERE Id = @StageId)
	
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
		--AND ((@StageName = 'cría y precría' AND BV.CreatedDate < DATEADD(DAY, (GL.WeeksInBreeding * 7), B.DateOfBirth))
		--OR (@StageName = 'postura' AND BV.CreatedDate > DATEADD(DAY, (GL.WeeksInBreeding * 7), B.DateOfBirth)))
	ORDER BY BV.CreatedDate 
END
GO
