CREATE TABLE [dbo].[Shift] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        VARCHAR (100)    NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Shift] PRIMARY KEY CLUSTERED ([Id] ASC)
);

