CREATE PROCEDURE Stock_GetByDeposit
	@DepositId uniqueidentifier
AS
BEGIN
	SELECT ProductId = P.Id,
		ProductName = UPPER(P.Name),
		Boxes = SUM(SE.Boxes),
		Maples = SUM(SE.Maples),
		Eggs = SUM(SE.Eggs)
	FROM StockEntry SE
		INNER JOIN Stock S
			ON SE.StockId = S.Id
		INNER JOIN Product P
			ON S.ProductId = P.Id
	WHERE SE.IsDeleted = 0
		AND S.IsDeleted = 0
		AND S.DepositId = @DepositId
	GROUP BY P.Id, P.Name
END