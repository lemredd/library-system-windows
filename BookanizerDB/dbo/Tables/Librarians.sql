CREATE TABLE [dbo].[Librarians] (
    [admin_id] INT           IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([admin_id] ASC)
);

