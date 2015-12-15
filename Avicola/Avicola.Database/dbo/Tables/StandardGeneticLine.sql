CREATE TABLE [dbo].[StandardGeneticLine] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]   DATETIME2 (7)    NOT NULL,
    [StandardId]    UNIQUEIDENTIFIER NOT NULL,
    [GeneticLineId] UNIQUEIDENTIFIER NOT NULL,
    [IsDeleted]     BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StandardGeneticLine] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StandardGeneticLine_GeneticLine] FOREIGN KEY ([GeneticLineId]) REFERENCES [dbo].[GeneticLine] ([Id]),
    CONSTRAINT [FK_StandardGeneticLine_Standard] FOREIGN KEY ([StandardId]) REFERENCES [dbo].[Standard] ([Id])
);

