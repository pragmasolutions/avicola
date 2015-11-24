CREATE TABLE [dbo].[Order]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [CreatedDate] DATETIME2 NOT NULL, 
    [Dozens] INT NOT NULL, 
    [ClientId] UNIQUEIDENTIFIER NOT NULL, 
    [OrderStatusId] UNIQUEIDENTIFIER NOT NULL, 
	[PreparedDate] DATETIME2 NULL, 
	[DepositId] UNIQUEIDENTIFIER NULL, 
    [DispatchedDate] DATETIME2 NULL, 
    [TruckId] UNIQUEIDENTIFIER NULL, 
    [DriverId] UNIQUEIDENTIFIER NULL, 
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Order_Client] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id]), 
    CONSTRAINT [FK_Order_OrderStatus] FOREIGN KEY ([OrderStatusId]) REFERENCES [OrderStatus]([Id]), 
	CONSTRAINT [FK_Order_Deposit] FOREIGN KEY ([DepositId]) REFERENCES [Deposit]([Id]), 
    CONSTRAINT [FK_Order_Truck] FOREIGN KEY ([TruckId]) REFERENCES [Truck]([Id]), 
    CONSTRAINT [FK_Order_Driver] FOREIGN KEY ([DriverId]) REFERENCES [Driver]([Id])
)
