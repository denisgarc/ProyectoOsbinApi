﻿CREATE TABLE [dbo].[SysLog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1)
	, [UserId] INT FOREIGN KEY REFERENCES SysUser(Id) NOT NULL
	, [LogTypeId] INT FOREIGN KEY REFERENCES SysLogType(Id) NOT NULL
	, [ActionTypeId] INT FOREIGN KEY REFERENCES SysActionType(Id) NOT NULL
	, [FileName] VARCHAR(MAX) NOT NULL
	, [MethodName] VARCHAR(MAX) NOT NULL
	, [Description] VARCHAR(MAX) NOT NULL
	, [DTOIn] VARCHAR(MAX) NOT NULL
	, [DTOOut] VARCHAR(MAX) NOT NULL
	, [Date] DATETIME NOT NULL DEFAULT GETDATE()
)