CREATE TABLE [dbo].Post
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(255) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [Content] NVARCHAR(MAX) NULL, 
    [AuthorId] UNIQUEIDENTIFIER NOT NULL, 
    [DataTimeActive] DATETIME2 NULL, 
    [IsActive] BIT NOT NULL, 
    [Image] VARCHAR(100) NULL, 
    [LastUpdated] DATETIME2 NULL, 
    [CreatedDate] DATETIME2 NULL, 
    [NumberOfView] BIGINT NULL
)
