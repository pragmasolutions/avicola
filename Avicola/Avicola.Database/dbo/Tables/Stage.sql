CREATE TABLE [dbo].[Stage] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        VARCHAR (50)     NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Stage] PRIMARY KEY CLUSTERED ([Id] ASC)
);

