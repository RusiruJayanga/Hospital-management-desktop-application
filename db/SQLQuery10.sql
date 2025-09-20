CREATE TABLE [dbo].[drug] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (MAX) NULL,
    [supplier]        VARCHAR (MAX) NULL,
    [nurse] VARCHAR (MAX) NULL,
    [date]       VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
