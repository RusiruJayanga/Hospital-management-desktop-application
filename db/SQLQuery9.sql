CREATE TABLE [dbo].[surgery] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [hall]       VARCHAR (MAX) NULL,
    [did]        VARCHAR (MAX) NULL,
    [department] VARCHAR (MAX) NULL,
    [nid]        VARCHAR (MAX) NULL,
    [date]       VARCHAR (MAX) NULL,
    [pid]        VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);