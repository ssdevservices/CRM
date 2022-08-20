CREATE TABLE [dbo].[Customers] (
    [CustomerId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (MAX) NOT NULL,
    [Address1]   NVARCHAR (50)  NOT NULL,
    [Address2]   NVARCHAR (50)  NULL,
    [City]       NVARCHAR (50)  NOT NULL,
    [State]      NVARCHAR (50)  NOT NULL,
    [Zip]        NVARCHAR (5)   NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

