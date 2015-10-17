CREATE TABLE [dbo].[BatchBarn](
	[Id] [uniqueidentifier] NOT NULL,
	[BatchId] [uniqueidentifier] NOT NULL,
	[BarnId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[InitialBirds] [int] NOT NULL,
	[FoodClassId] [uniqueidentifier] NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_BatchBarn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_BatchBarn_FoodClass] FOREIGN KEY ([FoodClassId]) REFERENCES [FoodClass]([Id]), 
    CONSTRAINT [FK_BatchBarn_Batch] FOREIGN KEY ([BatchId]) REFERENCES [Batch]([Id]),
	CONSTRAINT [FK_BatchBarn_Barn] FOREIGN KEY ([BarnId]) REFERENCES [Barn]([Id])
) ON [PRIMARY]