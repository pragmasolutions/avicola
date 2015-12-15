CREATE TABLE [dbo].[BatchMedicine] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [BatchId]     UNIQUEIDENTIFIER NOT NULL,
    [MedicineId]  UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [StartDate]   DATETIME2 (7)    NOT NULL,
    [EndDate]     DATETIME2 (7)    NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    [Observation] VARCHAR (MAX)    NULL,
    CONSTRAINT [PK_BatchMedicine] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BatchMedicine_Batch] FOREIGN KEY ([BatchId]) REFERENCES [dbo].[Batch] ([Id]),
    CONSTRAINT [FK_BatchMedicine_Medicine] FOREIGN KEY ([MedicineId]) REFERENCES [dbo].[Medicine] ([Id])
);

