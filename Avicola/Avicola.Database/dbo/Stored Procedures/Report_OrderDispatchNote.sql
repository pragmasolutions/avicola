CREATE PROCEDURE [dbo].[Report_OrderDispatchNote]
	@OrderId UNIQUEIDENTIFIER
AS
BEGIN
	
	SELECT 
		O.DispatchNoteNumber,
		O.CreatedDate,
		O.PreparedDate,
		O.DispatchedDate,
		ClientName = C.Name,
		O.City,
		O.[Address],
		O.PhoneNumber,
		Truck = T.[Description] + ' - ' + t.NumberPlate,
		DriverName = D.Name,
		EggClassName = EC.Name,
		Dozens = OEC.Dozens

	FROM [Order] O LEFT JOIN OrderEggClass OEC
		ON OEC.OrderId = O.Id LEFT JOIN EggClass EC
		ON EC.Id = OEC.EggClassId LEFT JOIN Driver D 
		ON D.Id = O.DriverId LEFT JOIN Client C
		ON C.Id = O.ClientId LEFT JOIN Truck T
		ON T.Id = O.TruckId

	WHERE O.Id = @OrderId  AND O.OrderStatusId = '65021B0D-6BFD-438A-8692-2AB8E5BE17BD'

	ORDER BY EC.[Sequence]
END