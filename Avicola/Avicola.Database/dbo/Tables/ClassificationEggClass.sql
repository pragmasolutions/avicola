CREATE TABLE [dbo].[ClassificationEggClass] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
	[ClassificationId]	UNIQUEIDENTIFIER NOT NULL,
	[EggClassId]		UNIQUEIDENTIFIER NOT NULL
    CONSTRAINT [PK_ClassificationEggClass] PRIMARY KEY CLUSTERED ([Id] ASC),
    [EggEquivalenceId] UNIQUEIDENTIFIER NOT NULL, 
    [Amount] INT NOT NULL, 
    [EggsCount] AS (CASE EggEquivalenceId
					WHEN '107C25DC-D92C-4BAB-A093-C9FCE2B8D522' THEN Amount * 12
					WHEN 'A9CDEB17-7207-4D95-BF55-0E62CF24FB65' THEN Amount * 30
					WHEN '5CB0F2A5-EA71-4539-A876-13F1DB31611E' THEN Amount * 360
					ELSE Amount
				END), 
    CONSTRAINT [FK_ClassificationEggClass_Classification] FOREIGN KEY ([ClassificationId]) REFERENCES [dbo].[Classification] ([Id]),
	CONSTRAINT [FK_ClassificationEggClass_EggClass] FOREIGN KEY ([EggClassId]) REFERENCES [dbo].[EggClass] ([Id]),
	CONSTRAINT [FK_ClassificationEggClass_EggEquivalence] FOREIGN KEY ([EggEquivalenceId]) REFERENCES [dbo].[EggEquivalence] ([Id])
);

