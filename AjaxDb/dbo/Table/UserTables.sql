﻿CREATE TABLE [dbo].[UserTables]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1),
	[Name] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[CreatDateTime] Datetime NOT NULL DEFAULT GETDATE()
)
