﻿
INSERT INTO [dbo].[StandardType] ([Id], [Name], [CreatedDate], [IsDeleted])
SELECT  'BC083A29-845F-45E9-BF41-5A68F480CA73', N'Rango de valores', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[StandardType] WHERE Id = 'BC083A29-845F-45E9-BF41-5A68F480CA73')

INSERT INTO [dbo].[StandardType] ([Id], [Name], [CreatedDate], [IsDeleted])
SELECT  '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', N'Valor único', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[StandardType] WHERE Id = '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35')
