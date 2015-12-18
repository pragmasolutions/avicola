CREATE PROCEDURE [dbo].[Stock_GetByEggClass]
	@DepositId uniqueidentifier
AS
BEGIN
	DECLARE @Classifications TABLE
	(
		EggClassId uniqueidentifier,
		EggsCount int
	)

	INSERT INTO @Classifications
	SELECT CEC.EggClassId,
			SUM(CEC.EggsCount)
	FROM ClassificationEggClass CEC
		INNER JOIN Classification C
			ON CEC.ClassificationId = C.Id
		INNER JOIN StockEntry SE
			ON C.StockEntryId = SE.Id
		INNER JOIN Stock S
			ON SE.StockId = S.Id
	WHERE S.DepositId = @DepositId
		AND CEC.IsDeleted = 0
		AND C.IsDeleted = 0
		AND SE.IsDeleted = 0
		AND S.IsDeleted = 0
	GROUP BY CEC.EggClassId


	DECLARE @Orders TABLE
	(
		EggClassId uniqueidentifier,
		EggsCount int
	)

	INSERT INTO @Orders
	SELECT OEC.EggClassId,
		SUM(OEC.Dozens) * 12
	FROM OrderEggClass OEC
		INNER JOIN [Order] O
			ON OEC.OrderId = O.Id
	WHERE O.DepositId = @DepositId
		AND O.IsDeleted = 0
		AND OEC.IsDeleted = 0
		AND (O.OrderStatusId = '65021B0D-6BFD-438A-8692-2AB8E5BE17BD' --Enviado
			OR O.OrderStatusId = 'CAA647AB-0049-47AE-A4F4-6CFE50C4EE48' --Terminado
			OR O.OrderStatusId = '279ABF04-CAF4-4EF5-8113-CFADADF34D31') -- En Proceso
	GROUP BY OEC.EggClassId

	
	SELECT EC.Id,
			EC.Name,
			EggsCount = ISNULL(C.EggsCount, 0) - ISNULL(O.EggsCount, 0)	
	FROM EggClass EC
		LEFT JOIN @Classifications C
			ON EC.Id = C.EggClassId
		LEFT JOIN @Orders O
			ON EC.Id = O.EggClassId
	ORDER BY EC.Sequence
		
END
