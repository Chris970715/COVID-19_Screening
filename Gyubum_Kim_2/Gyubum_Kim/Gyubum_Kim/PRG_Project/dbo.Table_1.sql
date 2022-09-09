CREATE TABLE [dbo].ScreeningTable
(
	[ScreeningID] INT NOT NULL PRIMARY KEY, 
    [StudentID] INT NOT NULL, 
    [CloseContact] BIT NOT NULL, 
    [Travelled] BIT NOT NULL, 
    [Symptoms] BIT NOT NULL, 
    [Date] DATE NOT NULL
)
