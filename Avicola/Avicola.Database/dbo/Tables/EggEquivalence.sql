CREATE TABLE [dbo].[EggEquivalence] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (100)    NOT NULL,
    [EggsAmount]    INT              NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_EggEquivalence] PRIMARY KEY CLUSTERED ([Id] ASC)
);

