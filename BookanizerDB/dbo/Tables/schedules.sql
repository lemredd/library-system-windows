CREATE TABLE [dbo].[schedules] (
    [sched_id]   INT            IDENTITY (1, 1) NOT NULL,
    [account_id] INT            NOT NULL,
    [book_id]    INT            NOT NULL,
    [date_start] DATE           NULL,
    [date_end]   DATE           NULL,
    [status]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK__schedule__747730C89521BE43] PRIMARY KEY CLUSTERED ([sched_id] ASC),
    CONSTRAINT [FK__schedules__accou__44FF419A] FOREIGN KEY ([account_id]) REFERENCES [dbo].[accounts] ([account_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK__schedules__book___4E88ABD4] FOREIGN KEY ([book_id]) REFERENCES [dbo].[books] ([book_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

