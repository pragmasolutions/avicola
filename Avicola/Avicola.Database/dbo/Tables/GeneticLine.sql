CREATE TABLE [dbo].[GeneticLine] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]     DATETIME2 (7)    NOT NULL,
    [Name]            VARCHAR (200)    NOT NULL,
    [ProductionWeeks] INT              NOT NULL,
    [IsDeleted]       BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_GeneticLine] PRIMARY KEY CLUSTERED ([Id] ASC)
);

