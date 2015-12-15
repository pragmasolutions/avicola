CREATE PROCEDURE [dbo].[Report_BatchObservation]
	@BatchId UNIQUEIDENTIFIER,
	@DateFrom DATETIME = NULL,
	@DateTo DATETIME = NULL
AS
BEGIN
	
	SELECT 
		B.Number,
		BO.CreatedDate,
		BO.Content
	FROM BatchObservation BO INNER JOIN Batch B
		ON BO.BatchId = B.Id INNER JOIN GeneticLine GL 
		ON B.GeneticLineId = GL.Id		
	WHERE B.Id = BatchId 
		AND (@DateFrom IS NULL OR BO.ObservationDate >= @DateFrom) 
		AND (@DateTo IS NULL OR BO.ObservationDate <= @DateTo)
	ORDER BY BO.CreatedDate 
END