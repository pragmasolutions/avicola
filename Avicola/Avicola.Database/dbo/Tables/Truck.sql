CREATE TABLE [dbo].[Truck] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [NumberPlate] VARCHAR (10)     NOT NULL,
    [Description] VARCHAR (250)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Truck] PRIMARY KEY CLUSTERED ([Id] ASC)
);

