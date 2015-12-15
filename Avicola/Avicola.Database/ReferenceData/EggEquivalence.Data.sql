INSERT INTO [dbo].[EggEquivalence] ([Id], [Name], [EggsAmount], [CreatedDate], [IsDeleted])
SELECT  '94CE87BD-519E-4507-AE06-F5BCA2CBA595', N'Huevos', 1, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggEquivalence] WHERE Id = '94CE87BD-519E-4507-AE06-F5BCA2CBA595')

INSERT INTO [dbo].[EggEquivalence] ([Id], [Name], [EggsAmount], [CreatedDate], [IsDeleted])
SELECT  '107C25DC-D92C-4BAB-A093-C9FCE2B8D522', N'Docenas', 12, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggEquivalence] WHERE Id = '107C25DC-D92C-4BAB-A093-C9FCE2B8D522')

INSERT INTO [dbo].[EggEquivalence] ([Id], [Name], [EggsAmount], [CreatedDate], [IsDeleted])
SELECT  'A9CDEB17-7207-4D95-BF55-0E62CF24FB65', N'Maples', 30, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggEquivalence] WHERE Id = 'A9CDEB17-7207-4D95-BF55-0E62CF24FB65')

INSERT INTO [dbo].[EggEquivalence] ([Id], [Name], [EggsAmount], [CreatedDate], [IsDeleted])
SELECT  '5CB0F2A5-EA71-4539-A876-13F1DB31611E', N'Cajas', 360, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggEquivalence] WHERE Id = '5CB0F2A5-EA71-4539-A876-13F1DB31611E')
