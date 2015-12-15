CREATE TABLE [dbo].[Measure] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]    DATETIME2 (7)    NOT NULL,
    [BatchId]        UNIQUEIDENTIFIER NOT NULL,
    [StandardItemId] UNIQUEIDENTIFIER NOT NULL,
    [Value]          DECIMAL (18, 4)  NOT NULL,
    [FoodClassId]    UNIQUEIDENTIFIER NULL,
    [Date]           DATETIME         NULL,
    [IsDeleted]      BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Measure] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Measure_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id]),
    CONSTRAINT [FK_Measure_FoodClass] FOREIGN KEY ([FoodClassId]) REFERENCES [dbo].[FoodClass] ([Id]),
    CONSTRAINT [FK_Measure_StandardItem] FOREIGN KEY ([StandardItemId]) REFERENCES [dbo].[StandardItem] ([Id])
);

