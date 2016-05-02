CREATE TABLE [dbo].[Order] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]    DATETIME2 (7)    NOT NULL,
	[DispatchNoteNumber]        INT   NULL,
    [ClientId]       UNIQUEIDENTIFIER NOT NULL,
    [Address]        VARCHAR (200)    DEFAULT ('') NOT NULL,
    [PhoneNumber]    VARCHAR (25)     DEFAULT ('') NOT NULL,
    [City]           VARCHAR (200)    DEFAULT ('') NOT NULL,
    [OrderStatusId]  UNIQUEIDENTIFIER NOT NULL,
    [PreparedDate]   DATETIME2 (7)    NULL,
    [DepositId]      UNIQUEIDENTIFIER NULL,
    [DispatchedDate] DATETIME2 (7)    NULL,
    [TruckId]        UNIQUEIDENTIFIER NULL,
    [DriverId]       UNIQUEIDENTIFIER NULL,
	[LoadDate]    DATETIME2 (7)    NOT NULL DEFAULT GETDATE(),
    [IsDeleted]      BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Order_Client] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]),
    CONSTRAINT [FK_Order_Deposit] FOREIGN KEY ([DepositId]) REFERENCES [dbo].[Deposit] ([Id]),
    CONSTRAINT [FK_Order_Driver] FOREIGN KEY ([DriverId]) REFERENCES [dbo].[Driver] ([Id]),
    CONSTRAINT [FK_Order_OrderStatus] FOREIGN KEY ([OrderStatusId]) REFERENCES [dbo].[OrderStatus] ([Id]),
    CONSTRAINT [FK_Order_Truck] FOREIGN KEY ([TruckId]) REFERENCES [dbo].[Truck] ([Id])
);

