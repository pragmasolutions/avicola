CREATE TABLE [dbo].[Stock] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [DepositId]   UNIQUEIDENTIFIER NOT NULL,
    [ProductId]   UNIQUEIDENTIFIER NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Stock_Deposit] FOREIGN KEY ([DepositId]) REFERENCES [dbo].[Deposit] ([Id]),
    CONSTRAINT [FK_Stock_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

