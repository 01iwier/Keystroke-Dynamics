﻿CREATE TABLE dbo.Users
(
	UserId INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(50) NOT NULL,
)
