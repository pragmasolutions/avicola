CREATE TABLE [dbo].[Batch](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Number] [int] NOT NULL,
	[InitialBirds] [int] NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[GeneticLineId] [uniqueidentifier] NOT NULL,
	[StartingFood] [decimal](18, 2) NOT NULL,
	[FoodClassId] [uniqueidentifier] NOT NULL,
	[BarnId] [uniqueidentifier] NULL,
	[ArrivedToBarn] [datetime2](7) NULL,
	[PostureStartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_Batch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_Batch_GeneticLine] FOREIGN KEY ([GeneticLineId]) REFERENCES [GeneticLine]([Id]), 
    CONSTRAINT [FK_Batch_FoodClass] FOREIGN KEY ([FoodClassId]) REFERENCES [FoodClass]([Id]), 
    CONSTRAINT [FK_Batch_Barn] FOREIGN KEY ([BarnId]) REFERENCES [Barn]([Id])
) ON [PRIMARY]