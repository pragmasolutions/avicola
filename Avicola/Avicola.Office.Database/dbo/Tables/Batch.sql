﻿CREATE TABLE [dbo].[Batch](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Number] [int] NOT NULL,
	[InitialBirds] [int] NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[GeneticLineId] [uniqueidentifier] NOT NULL,
	[StartingFood] [decimal](18, 2) NOT NULL,
	[FoodClassId] [uniqueidentifier] NOT NULL,
	[BarnId] [uniqueidentifier] NULL,
	[StageId] AS (CASE WHEN  GETDATE() < [ArrivedToBarn] THEN CONVERT(uniqueidentifier,'096DEBD6-C537-4569-8B97-53A3C3E82A39') ELSE CONVERT(uniqueidentifier,'0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F') END),
	[ArrivedToBarn] [datetime2](7) NOT NULL DEFAULT GETDATE(),
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