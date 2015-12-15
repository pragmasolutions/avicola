﻿CREATE TABLE [dbo].[Client] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (200)    NOT NULL,
    [Tel1]        VARCHAR (20)     NULL,
    [Tel2]        VARCHAR (20)     NULL,
    [CellPhone]   VARCHAR (25)     NULL,
    [Email]       VARCHAR (200)    NULL,
    [Referent]    VARCHAR (200)    NULL,
    [WebSite]     VARCHAR (1000)   NULL,
    [Address]     VARCHAR (200)    NOT NULL,
    [City]        VARCHAR (100)    NOT NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([Id] ASC)
);

