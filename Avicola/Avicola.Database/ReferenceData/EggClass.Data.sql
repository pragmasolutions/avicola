﻿
INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  '6D9FAF95-AE36-424E-A32D-BD20F61D25D5', N'B1', 1, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = '6D9FAF95-AE36-424E-A32D-BD20F61D25D5')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  '02409E27-9943-4418-B577-55481B68CE52', N'B2', 2, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = '02409E27-9943-4418-B577-55481B68CE52')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  'C9D9BDA5-FBEE-43DF-92B2-5F8DAE466C96', N'B2 chico', 3, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = 'C9D9BDA5-FBEE-43DF-92B2-5F8DAE466C96')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  '96690BFD-9C5A-41BD-8316-1847165FEB79', N'B3', 4, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = '96690BFD-9C5A-41BD-8316-1847165FEB79')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  '9600FC4E-5B50-475D-A41A-6C3866D43A45', N'B4', 5, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = '9600FC4E-5B50-475D-A41A-6C3866D43A45')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  'E14E7C9B-80E6-49DE-9EB9-E1BF831E6A9F', N'B5', 6, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = 'E14E7C9B-80E6-49DE-9EB9-E1BF831E6A9F')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  'F3003CA0-8CDA-4C5D-AAD2-2171FF4B60C5', N'B6', 7, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = 'F3003CA0-8CDA-4C5D-AAD2-2171FF4B60C5')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  'E98B2A4D-2E62-4D46-978C-31CFA0231CBE', N'B7', 8, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = 'E98B2A4D-2E62-4D46-978C-31CFA0231CBE')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  '1F840D11-ED2A-4CE0-B805-352241D60FC2', N'B8', 9, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = '1F840D11-ED2A-4CE0-B805-352241D60FC2')

INSERT INTO [dbo].[EggClass] ([Id], [Name], [Sequence], [CreatedDate], [IsDeleted])
SELECT  '7EB1B151-CCFD-432A-9A12-56E0B5798C37', N'B0', 10, GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[EggClass] WHERE Id = '7EB1B151-CCFD-432A-9A12-56E0B5798C37')
