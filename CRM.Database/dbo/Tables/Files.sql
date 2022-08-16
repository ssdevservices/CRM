CREATE TABLE [dbo].[Files] (
    [FileId]   INT             IDENTITY (1, 1) NOT NULL,
    [FileName] NVARCHAR (75)   NOT NULL,
    [FileType] NVARCHAR (10)   NOT NULL,
    [FileData] VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_Files] PRIMARY KEY CLUSTERED ([FileId] ASC)
);

