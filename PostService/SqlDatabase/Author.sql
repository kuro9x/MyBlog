CREATE TABLE [dbo].Author
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [PhoneNumber] VARCHAR(50) NOT NULL, 
    [DataTimeActive] DATETIME2 NULL, 
    [IsActive] BIT NOT NULL, 
    [Image] VARCHAR(100) NULL, 
    [Company] NVARCHAR(150) NULL, 
    [CreatedDate] DATETIME2 NULL, 
    [Rank] SMALLINT NULL, 
    [FacebookLink] CHAR(100) NULL, 
    [Linkedin] CHAR(100) NULL, 
    [GitHubLink] CHAR(100) NULL, 
    [LastUpdated] DATETIME2 NULL
)
