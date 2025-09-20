CREATE TABLE [dbo].[patient] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (MAX) NULL,
    [phone]      VARCHAR (MAX) NULL,
    [department] VARCHAR (MAX) NULL,
    [address]    VARCHAR (MAX) NULL,
    [dob]        VARCHAR (MAX) NULL,
    [gender]     VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);