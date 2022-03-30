CREATE TABLE [Docker].[person] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Firstname]      NVARCHAR (50) NULL,
    [Lastname]      NVARCHAR (50) NULL,
    [date_of_birth] DATE          NULL,
    [occupation]    NVARCHAR (50) NULL,
    [company]       NVARCHAR (50) NULL,
    [test1] NCHAR(10) NULL, 
    [test2] NCHAR(10) NULL, 
    [test3] NCHAR(10) NULL, 
    [test4] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


