CREATE TABLE [dbo].[StageChange] (
    [Id]                    UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]           DATETIME2 (7)    NOT NULL,
    [BatchId]               UNIQUEIDENTIFIER NOT NULL,
    [StageFromId]           UNIQUEIDENTIFIER NOT NULL,
    [StageToId]             UNIQUEIDENTIFIER NOT NULL,
    [StageFromInitialBirds] INT              NOT NULL,
    [StageFromIFinalBirds]  INT              NOT NULL,
    [FoodEntryDuringPeriod] DECIMAL (18, 4)  NOT NULL,
    [CurrentFoodStock]      DECIMAL (18, 4)  NOT NULL,
    [IsDeleted]             BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StageChange] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StageChange_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id]),
    CONSTRAINT [FK_StageChange_StageFrom] FOREIGN KEY ([StageFromId]) REFERENCES [dbo].[Stage] ([Id]),
    CONSTRAINT [FK_StageChange_StageTo] FOREIGN KEY ([StageToId]) REFERENCES [dbo].[Stage] ([Id])
);

