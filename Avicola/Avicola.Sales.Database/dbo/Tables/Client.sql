CREATE TABLE [dbo].[Client](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] DATETIME2(7) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Tel1] [varchar](20) NULL,
	[Tel2] [varchar](20) NULL,
	[CellPhone] [varchar](25) NULL,
	[Email] [varchar](200) NULL,
	[Referent] [varchar](200) NULL,
	[WebSite] [varchar](1000) NULL,
	[Address] [varchar](200) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
