CREATE TABLE [dbo].[StageChange](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
	[StageFromId] [uniqueidentifier] NOT NULL,
	[StageToId] [uniqueidentifier] NOT NULL,
	[StageFromInitialBirds] INT NOT NULL,
	[StageFromIFinalBirds] INT NOT NULL,
	[FoodEntryDuringPeriod] [decimal](18, 4) NOT NULL,
	[CurrentFoodStock] [decimal](18, 4) NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0,
CONSTRAINT [PK_StageChange] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_StageChange_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id]),
	CONSTRAINT [FK_StageChange_StageFrom] FOREIGN KEY ([StageFromId]) REFERENCES [Stage]([Id]),
	CONSTRAINT [FK_StageChange_StageTo] FOREIGN KEY ([StageToId]) REFERENCES [Stage]([Id])
) ON [PRIMARY]
