CREATE TABLE [dbo].[Vaccine] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]    DATETIME2 (7)    NOT NULL,
    [Name]           VARCHAR (100)    NOT NULL,
    [IsDeleted]      BIT              DEFAULT ((0)) NOT NULL,
    [RecommendedDay] INT              NULL,
    CONSTRAINT [PK_Vaccine] PRIMARY KEY CLUSTERED ([Id] ASC)
);

