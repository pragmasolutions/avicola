
INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted], [DivideChartWeek])
SELECT  '86D41158-364A-4801-8975-05C9B1CEBD3C', N'Peso corporal', 'g', '939E6F2D-8001-448A-88E2-FEC280FBB055', 'BC083A29-845F-45E9-BF41-5A68F480CA73', 1, 'AVG', GETDATE(), 0, 18 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = '86D41158-364A-4801-8975-05C9B1CEBD3C')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted], [DivideChartWeek])
SELECT  'F814F03C-2655-4305-9D23-37E742ABF640', N'Mortandad', 'Aves', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', 1, 'SUM', GETDATE(), 0, 18 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = 'F814F03C-2655-4305-9D23-37E742ABF640')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted])
SELECT  'E8FE57EB-F05B-48AE-92B7-EB39F5807589', N'Descarte', 'Aves', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', 0, 'SUM', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = 'E8FE57EB-F05B-48AE-92B7-EB39F5807589')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted])
SELECT  '1927EBF5-4E6F-479F-AE4B-6D2C8152167A', N'Ingreso de Alimento', 'Kg', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', 1, 'SUM', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = '1927EBF5-4E6F-479F-AE4B-6D2C8152167A')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted], [DivideChartWeek])
SELECT  '42F12739-8F64-4E20-B08A-750B0D9B9E96', N'Consumo de Alimento', 'Kg', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', 'BC083A29-845F-45E9-BF41-5A68F480CA73', 1, 'SUM', GETDATE(), 0, 18 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = '42F12739-8F64-4E20-B08A-750B0D9B9E96')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted])
SELECT  '41C1FFEE-DE06-4FE4-9DE9-20423822CAC6', N'Agua', 'Litros', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', 1, 'SUM', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = '41C1FFEE-DE06-4FE4-9DE9-20423822CAC6')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted], [StartingWeek])
SELECT  'A755ACAB-4A3C-45FF-B90C-6B851E16A713', N'Peso del huevo', 'g', '939E6F2D-8001-448A-88E2-FEC280FBB055', '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', 1, 'AVG', GETDATE(), 0, 18 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = 'A755ACAB-4A3C-45FF-B90C-6B851E16A713')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted], [StartingWeek])
SELECT  'FCABB235-49D8-4B24-B3DE-D605382F567D', N'Producción', '%', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', 'BC083A29-845F-45E9-BF41-5A68F480CA73', 1, 'AVG', GETDATE(), 0, 17 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = 'FCABB235-49D8-4B24-B3DE-D605382F567D')

