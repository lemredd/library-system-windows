CREATE TABLE [dbo].[accounts] (
    [account_id] INT          IDENTITY (1, 1) NOT NULL,
    [username]   VARCHAR (50) NOT NULL,
    [password]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK__accounts__46A222CD1AD6183D] PRIMARY KEY CLUSTERED ([account_id] ASC)
);

