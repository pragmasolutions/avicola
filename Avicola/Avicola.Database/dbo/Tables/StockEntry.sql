CREATE TABLE [dbo].[StockEntry] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [ShiftId]     UNIQUEIDENTIFIER NOT NULL,
    [StockId]     UNIQUEIDENTIFIER NOT NULL,
    [Boxes]       INT              NOT NULL,
    [Maples]      INT              NOT NULL,
    [Eggs]        INT              NOT NULL,
	[CurrentEggs] INT              NOT NULL,
	[BarnId]		UNIQUEIDENTIFIER NOT NULL,
    [ProviderId]  UNIQUEIDENTIFIER NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StockEntry] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StockEntry_Provider] FOREIGN KEY ([ProviderId]) REFERENCES [dbo].[Provider] ([Id]),
    CONSTRAINT [FK_StockEntry_Shift] FOREIGN KEY ([ShiftId]) REFERENCES [dbo].[Shift] ([Id]),
    CONSTRAINT [FK_StockEntry_Stock] FOREIGN KEY ([StockId]) REFERENCES [dbo].[Stock] ([Id]),
	CONSTRAINT [FK_StockEntry_Barn] FOREIGN KEY ([BarnId]) REFERENCES [dbo].[Barn] ([Id])
);

