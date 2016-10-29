CREATE TABLE [dbo].[Standard] (
    [Id]                 UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate]        DATETIME2 (7)    NOT NULL,
    [Name]               VARCHAR (200)    NOT NULL,
    [MeasureUnity]       VARCHAR (200)    NOT NULL,
    [DataLoadTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [StandardTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [AllowDecimal]       BIT              DEFAULT ((1)) NOT NULL,
    [AggregateOperation] VARCHAR (5)      NULL,
    [YAxis]              INT              DEFAULT ((0)) NOT NULL,
	[DivideChartWeek]    INT			  NULL,
	[StartingWeek]  INT			  NULL,
    [IsDeleted]          BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Standard] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Standard_DataLoadType] FOREIGN KEY ([DataLoadTypeId]) REFERENCES [dbo].[DataLoadType] ([Id]),
    CONSTRAINT [FK_Standard_StandardType] FOREIGN KEY ([StandardTypeId]) REFERENCES [dbo].[StandardType] ([Id])
);

