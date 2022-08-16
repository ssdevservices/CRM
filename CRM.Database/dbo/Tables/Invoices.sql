CREATE TABLE [dbo].[Invoices] (
    [InvoiceId]  INT IDENTITY (1000, 1) NOT NULL,
    [CustomerId] INT NOT NULL,
    [Amount]     INT NOT NULL,
    [IsPaid]     BIT NOT NULL,
    [FileId]     INT NULL,
    CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED ([InvoiceId] ASC),
    CONSTRAINT [FK_Invoices_Files] FOREIGN KEY ([FileId]) REFERENCES [dbo].[Files] ([FileId])
);

