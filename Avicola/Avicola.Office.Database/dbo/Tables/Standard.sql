﻿CREATE TABLE [dbo].[Standard](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[DataLoadTypeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Standard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_Standard_DataLoadType] FOREIGN KEY ([DataLoadTypeId]) REFERENCES [DataLoadType]([Id])
) ON [PRIMARY]
