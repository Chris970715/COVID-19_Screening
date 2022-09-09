CREATE TABLE [dbo].[UserTable] (
    [StudentID]   INT           NOT NULL,
    [UserName]    NVARCHAR (50) NOT NULL,
    [UserType]    NCHAR (10)    NOT NULL,
    [UserFlagged] INT           NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

