CREATE PROCEDURE StandardGeneticLine_Delete
	@Id uniqueidentifier
AS
BEGIN
	UPDATE M
	SET IsDeleted = 1 
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
	WHERE SI.StandardGeneticLineId = @Id

	UPDATE SI
	SET IsDeleted = 1 
	FROM Measure M
		INNER JOIN StandardItem SI
			ON M.StandardItemId = SI.Id
	WHERE SI.StandardGeneticLineId = @Id

	UPDATE StandardGeneticLine
	SET IsDeleted = 1
	WHERE Id = @Id
END