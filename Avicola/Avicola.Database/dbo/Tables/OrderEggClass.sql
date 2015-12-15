CREATE TABLE [dbo].[OrderEggClass] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]    DATETIME2 (7)    NOT NULL,
	[IsDeleted]      BIT              DEFAULT ((0)) NOT NULL,
    [Dozens]         INT              NOT NULL,
	[EggClassId]	 UNIQUEIDENTIFIER NOT NULL,    
	[OrderId]	 UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderEggClass_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [FK_Order_EggClass] FOREIGN KEY ([EggClassId]) REFERENCES [dbo].[EggClass] ([Id])
);

