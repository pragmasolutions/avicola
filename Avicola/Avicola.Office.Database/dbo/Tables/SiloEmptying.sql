CREATE TABLE [dbo].[SiloEmptying](
	[Id] [uniqueidentifier] NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_SiloEmptying] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_SiloEmptying_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id]), 
) ON [PRIMARY]