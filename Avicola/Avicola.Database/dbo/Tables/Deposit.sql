CREATE TABLE [dbo].[Deposit] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (100)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Deposit] PRIMARY KEY CLUSTERED ([Id] ASC)
);

