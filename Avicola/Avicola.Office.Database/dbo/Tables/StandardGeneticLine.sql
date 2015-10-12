CREATE TABLE [dbo].[StandardGeneticLine](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[StandardId] [uniqueidentifier] NOT NULL,
	[GeneticLineId] [uniqueidentifier] NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_StandardGeneticLine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_StandardGeneticLine_Standard] FOREIGN KEY ([StandardId]) REFERENCES [Standard]([Id]), 
    CONSTRAINT [FK_StandardGeneticLine_GeneticLine] FOREIGN KEY ([GeneticLineId]) REFERENCES [GeneticLine]([Id])
) ON [PRIMARY]
