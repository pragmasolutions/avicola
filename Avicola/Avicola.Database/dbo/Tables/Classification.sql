CREATE TABLE [dbo].[Classification] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
	[ClassificationDate]	DATETIME NOT NULL,
	[StockEntryId]		UNIQUEIDENTIFIER NOT NULL
    CONSTRAINT [PK_Classification] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Classification_StockEntry] FOREIGN KEY ([StockEntryId]) REFERENCES [dbo].[StockEntry] ([Id])
);

