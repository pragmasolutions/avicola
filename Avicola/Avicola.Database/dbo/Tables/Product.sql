CREATE TABLE [dbo].[Product] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (200)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);

