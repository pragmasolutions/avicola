CREATE TABLE [dbo].[FoodClass] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (200)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_FoodClass] PRIMARY KEY CLUSTERED ([Id] ASC)
);

