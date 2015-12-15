CREATE TABLE [dbo].[ClassificationEggClass] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
	[ClassificationId]	UNIQUEIDENTIFIER NOT NULL,
	[EggClassId]		UNIQUEIDENTIFIER NOT NULL
    CONSTRAINT [PK_ClassificationEggClass] PRIMARY KEY CLUSTERED ([Id] ASC),
    [EggEquivalenceId] UNIQUEIDENTIFIER NOT NULL, 
    [Amount] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_ClassificationEggClass_Classification] FOREIGN KEY ([ClassificationId]) REFERENCES [dbo].[Classification] ([Id]),
	CONSTRAINT [FK_ClassificationEggClass_EggClass] FOREIGN KEY ([EggClassId]) REFERENCES [dbo].[EggClass] ([Id]),
	CONSTRAINT [FK_ClassificationEggClass_EggEquivalence] FOREIGN KEY ([EggEquivalenceId]) REFERENCES [dbo].[EggEquivalence] ([Id])
);

