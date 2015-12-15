CREATE TABLE [dbo].[BatchObservation] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]     DATETIME2 (7)    NOT NULL,
    [Content]         VARCHAR (MAX)    NOT NULL,
    [ObservationDate] DATETIME2 (7)    NOT NULL,
    [BatchId]         UNIQUEIDENTIFIER NOT NULL,
    [IsDeleted]       BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_BatchObservation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BatchObservation_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id])
);

