CREATE TABLE [dbo].[StockEntry](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ShiftId] [uniqueidentifier] NOT NULL,
	[StockId] [uniqueidentifier] NOT NULL,
	[Boxes] [int] NOT NULL,
	[Maples] [int] NOT NULL,
	[Eggs] [int] NOT NULL,
	[ProviderId] [uniqueidentifier] NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_StockEntry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_StockEntry_Shift] FOREIGN KEY ([ShiftId]) REFERENCES [Shift]([Id]), 
    CONSTRAINT [FK_StockEntry_Stock] FOREIGN KEY ([StockId]) REFERENCES [Stock]([Id]), 
    CONSTRAINT [FK_StockEntry_Provider] FOREIGN KEY ([ProviderId]) REFERENCES [Provider]([Id])
) ON [PRIMARY]