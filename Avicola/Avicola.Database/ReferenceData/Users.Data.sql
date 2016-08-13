INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [IsDeleted]) 
SELECT 'C341C70B-7653-4967-9A1B-3F7660C29E74', N'mlaura@avicolasantaana.com.ar', 0, N'AJnpJ9j5/cGydA57Xd2nNiul905WkcDAFSauO5vWf1eoImZQvwXpUR12WlMvcYJ03w==', N'8020c3cf-e841-421d-8f15-5e12936bb3c8', NULL, 0, 0, NULL, 1, 0, N'mlaura@avicolasantaana.com.ar', 0
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[AspNetUsers] WHERE Id = 'C341C70B-7653-4967-9A1B-3F7660C29E74')

INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [IsDeleted]) 
SELECT '97C85D32-3B54-4A72-9069-8A0ADE457087', N'lisandro@avicolasantaana.com.ar', 0, N'AJnpJ9j5/cGydA57Xd2nNiul905WkcDAFSauO5vWf1eoImZQvwXpUR12WlMvcYJ03w==', N'8020c3cf-e841-421d-8f15-5e12936bb3c8', NULL, 0, 0, NULL, 1, 0, N'lisandro@avicolasantaana.com.ar', 0
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[AspNetUsers] WHERE Id = '97C85D32-3B54-4A72-9069-8A0ADE457087')

INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [IsDeleted]) 
SELECT '9CAF39FB-5DBF-4921-AFB5-077F36429951', N'daniel@avicolasantaana.com.ar', 0, N'AJnpJ9j5/cGydA57Xd2nNiul905WkcDAFSauO5vWf1eoImZQvwXpUR12WlMvcYJ03w==', N'8020c3cf-e841-421d-8f15-5e12936bb3c8', NULL, 0, 0, NULL, 1, 0, N'daniel@avicolasantaana.com.ar', 0
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[AspNetUsers] WHERE Id = '9CAF39FB-5DBF-4921-AFB5-077F36429951')

