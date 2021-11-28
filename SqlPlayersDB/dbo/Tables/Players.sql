CREATE TABLE [dbo].[Players]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [GamesPlayed] INT NOT NULL, 
    [GamesWon] INT NOT NULL, 
    [HighestScore] INT NOT NULL
)
