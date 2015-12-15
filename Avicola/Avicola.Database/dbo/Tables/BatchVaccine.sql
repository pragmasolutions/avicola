CREATE TABLE [dbo].[BatchVaccine] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [BatchId]     UNIQUEIDENTIFIER NOT NULL,
    [VaccineId]   UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [StartDate]   DATETIME2 (7)    NOT NULL,
    [EndDate]     DATETIME2 (7)    NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_BatchVaccine] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BatchVaccine_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id]),
    CONSTRAINT [FK_BatchVaccine_Vaccine] FOREIGN KEY ([VaccineId]) REFERENCES [dbo].[Vaccine] ([Id])
);

