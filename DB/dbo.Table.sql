CREATE TABLE [dbo].[USER]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [FullName] VARCHAR(50) NULL, 
    [TPNo] INT NULL, 
    [Address] VARCHAR(100) NULL, 
    [UserName] VARCHAR(20) NULL, 
    [UserType] VARCHAR(14) NULL, 
    [Password] TEXT NULL
)
