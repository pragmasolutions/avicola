﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

:r .\DataLoadType.Data.sql	
:r .\StandardTypes.Data.sql	
:r .\Standards.Data.sql	
:r .\Stages.Data.sql	
:r .\EggClass.Data.sql	
:r .\EggEquivalence.Data.sql	

:r .\Product.Data.sql	
:r .\Shifts.Data.sql	
:r .\OrderStatus.Data.sql	
:r .\Users.Data.sql	