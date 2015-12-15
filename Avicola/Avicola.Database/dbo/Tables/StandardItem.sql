CREATE TABLE [dbo].[StandardItem] (
    [Id]                    UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]           DATETIME2 (7)    NOT NULL,
    [StandardGeneticLineId] UNIQUEIDENTIFIER NOT NULL,
    [Sequence]              INT              NOT NULL,
    [Value1]                DECIMAL (18, 4)  NOT NULL,
    [Value2]                DECIMAL (18, 4)  NULL,
    [IsDeleted]             BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StandardItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StandardItem_StandardGeneticLine] FOREIGN KEY ([StandardGeneticLineId]) REFERENCES [dbo].[StandardGeneticLine] ([Id])
);

