CREATE TABLE [dbo].[Driver] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [CreatedDate] DATETIME2 (7)    NOT NULL,
    [Name]        VARCHAR (200)    NOT NULL,
    [Tel1]        VARCHAR (20)     NULL,
    [Tel2]        VARCHAR (20)     NULL,
    [CellPhone]   VARCHAR (25)     NULL,
    [Address]     VARCHAR (200)    NOT NULL,
    [City]        VARCHAR (100)    NOT NULL,
    [TruckId]     UNIQUEIDENTIFIER NULL,
    [IsDeleted]   BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Driver_Truck] FOREIGN KEY ([TruckId]) REFERENCES [dbo].[Truck] ([Id])
);

