CREATE TABLE [Docker].[person] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Fistname]      NVARCHAR (50) NULL,
    [Lastname]      NVARCHAR (50) NULL,
    [date_of_birth] DATE          NULL,
    [occupation]    NVARCHAR (50) NULL,
    [company]       NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


