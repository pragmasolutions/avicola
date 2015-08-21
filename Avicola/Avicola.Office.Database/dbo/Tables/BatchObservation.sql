CREATE TABLE [dbo].[BatchObservation](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Content] [varchar](max) NOT NULL,
	[ObservationDate] [datetime2](7) NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_BatchObservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_BatchObservation_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id])
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]