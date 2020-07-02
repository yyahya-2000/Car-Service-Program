CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [First Name] NCHAR(10) NOT NULL, 
    [Last Name] NCHAR(10) NOT NULL, 
    [Phone Number] NUMERIC NOT NULL, 
    [Car Number] CHAR(10) NOT NULL, 
    [Data] DATETIME NOT NULL, 
    [Spare Parts] TEXT NOT NULL, 
    [Paying Way] NVARCHAR(50) NOT NULL, 
    [Count] INT NOT NULL
)
