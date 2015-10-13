CREATE TABLE [dbo].[BatchMedicine](
	[Id] [uniqueidentifier] NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
	[MedicineId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 [Observation] VARCHAR(MAX) NULL, 
    CONSTRAINT [PK_BatchMedicine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_BatchMedicine_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id]), 
    CONSTRAINT [FK_BatchMedicine_Medicine] FOREIGN KEY ([MedicineId]) REFERENCES [Medicine]([Id])
) ON [PRIMARY]