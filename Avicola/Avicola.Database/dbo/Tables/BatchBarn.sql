CREATE TABLE [dbo].[BatchBarn] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [BatchId]      UNIQUEIDENTIFIER NOT NULL,
    [BarnId]       UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]  DATETIME2 (7)    NOT NULL,
    [InitialBirds] INT              NOT NULL,
    [IsDeleted]    BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_BatchBarn] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BatchBarn_Barn] FOREIGN KEY ([BarnId]) REFERENCES [dbo].[Barn] ([Id]),
    CONSTRAINT [FK_BatchBarn_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id])
);

