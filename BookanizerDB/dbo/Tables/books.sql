CREATE TABLE [dbo].[books] (
    [book_id]       INT             IDENTITY (1, 1) NOT NULL,
    [title]         NVARCHAR (MAX)  NOT NULL,
    [author]        NVARCHAR (MAX)  NOT NULL,
    [date_authored] DATE            NOT NULL,
    [categories]    NVARCHAR (MAX)  NULL,
    [isbn]          BIGINT          NOT NULL,
    [image]         VARBINARY (MAX) NULL,
    [copies_left]   INT             NOT NULL,
    CONSTRAINT [PK__tmp_ms_x__490D1AE10411E5F3] PRIMARY KEY CLUSTERED ([book_id] ASC)
);

