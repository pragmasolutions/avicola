CREATE TABLE [dbo].[BatchVaccine](
	[Id] [uniqueidentifier] NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
	[VaccineId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[RecommendedDate] [datetime2](7) NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_BatchVaccine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_BatchVaccine_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id]), 
    CONSTRAINT [FK_BatchVaccine_Vaccine] FOREIGN KEY ([VaccineId]) REFERENCES [Vaccine]([Id])
) ON [PRIMARY]