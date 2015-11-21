CREATE TABLE [dbo].[Stock](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[DepositId] [uniqueidentifier] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_Stock_Deposit] FOREIGN KEY ([DepositId]) REFERENCES [Deposit]([Id]), 
    CONSTRAINT [FK_Stock_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id])
) ON [PRIMARY]