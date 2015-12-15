CREATE TABLE [dbo].[Barn] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (100)    NOT NULL,
    [Capacity]    INT              NULL,
    [StageId]     UNIQUEIDENTIFIER DEFAULT ('096DEBD6-C537-4569-8B97-53A3C3E82A39') NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Barn] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Barn_Stage] FOREIGN KEY ([StageId]) REFERENCES [dbo].[Stage] ([Id])
);

