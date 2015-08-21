CREATE TABLE [dbo].[Measure](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
	[StandardItemId] [uniqueidentifier] NOT NULL,
	[Value] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Measure] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_Measure_StandardItem] FOREIGN KEY ([StandardItemId]) REFERENCES [StandardItem]([Id]), 
    CONSTRAINT [FK_Measure_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id])
) ON [PRIMARY]
