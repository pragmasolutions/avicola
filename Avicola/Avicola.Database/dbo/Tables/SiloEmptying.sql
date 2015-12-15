CREATE TABLE [dbo].[SiloEmptying] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [BatchId]     UNIQUEIDENTIFIER NOT NULL,
    [Date]        DATETIME2 (7)    NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_SiloEmptying] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SiloEmptying_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id])
);

