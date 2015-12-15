CREATE TABLE [dbo].[EggClass] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
	[Name]        VARCHAR (100)    NOT NULL,
    [Sequence]    INT              NOT NULL,
    CONSTRAINT [PK_EggClass] PRIMARY KEY CLUSTERED ([Id] ASC)
);

