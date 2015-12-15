CREATE TABLE [dbo].[Batch] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]    DATETIME2 (7)    NOT NULL,
    [Number]         INT              NOT NULL,
    [InitialBirds]   INT              NOT NULL,
    [DateOfBirth]    DATETIME2 (7)    NOT NULL,
    [BreedingDate]   DATETIME2 (7)    NULL,
    [ReBreedingDate] DATETIME2 (7)    NULL,
    [PostureDate]    DATETIME2 (7)    NULL,
    [GeneticLineId]  UNIQUEIDENTIFIER NOT NULL,
    [StartingFood]   DECIMAL (18, 2)  NOT NULL,
    [FoodClassId]    UNIQUEIDENTIFIER NOT NULL,
    [StageId]        UNIQUEIDENTIFIER DEFAULT ('096DEBD6-C537-4569-8B97-53A3C3E82A39') NOT NULL,
    [EndDate]        DATETIME2 (7)    NULL,
    [IsDeleted]      BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Batch] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Batch_FoodClass] FOREIGN KEY ([FoodClassId]) REFERENCES [dbo].[FoodClass] ([Id]),
    CONSTRAINT [FK_Batch_GeneticLine] FOREIGN KEY ([GeneticLineId]) REFERENCES [dbo].[GeneticLine] ([Id]),
    CONSTRAINT [FK_Batch_Stage] FOREIGN KEY ([StageId]) REFERENCES [dbo].[Stage] ([Id])
);

