﻿
INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted])
SELECT  '86D41158-364A-4801-8975-05C9B1CEBD3C', N'Peso del ave', 'Kg', '939E6F2D-8001-448A-88E2-FEC280FBB055', 'BC083A29-845F-45E9-BF41-5A68F480CA73', 1, 'AVG', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = '86D41158-364A-4801-8975-05C9B1CEBD3C')

INSERT INTO [dbo].[Standard] ([Id], [Name], [MeasureUnity], [DataLoadTypeId], [StandardTypeId], [AllowDecimal], [AggregateOperation], [CreatedDate], [IsDeleted])
SELECT  'F814F03C-2655-4305-9D23-37E742ABF640', N'Mortandad', 'Aves', 'C4D05E89-69FB-42F7-8F6A-15C8BC130377', '7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35', 0, 'SUM', GETDATE(), 0 WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Standard] WHERE Id = 'F814F03C-2655-4305-9D23-37E742ABF640')
