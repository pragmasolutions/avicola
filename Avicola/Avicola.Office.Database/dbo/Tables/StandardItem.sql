CREATE TABLE [dbo].[StandardItem](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[StandardGeneticLineId] [uniqueidentifier] NOT NULL,
	[Sequence] [int] NOT NULL,
	[Value1] [decimal](18, 4) NOT NULL,
	[Value2] [decimal](18, 4) NULL,
	[FoodClassId] [uniqueidentifier] NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_StandardItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_StandardItem_FoodClass] FOREIGN KEY ([FoodClassID]) REFERENCES [FoodClass]([Id]), 
    CONSTRAINT [FK_StandardItem_StandardGeneticLine] FOREIGN KEY ([StandardGeneticLineId]) REFERENCES [StandardGeneticLine]([Id])
) ON [PRIMARY]