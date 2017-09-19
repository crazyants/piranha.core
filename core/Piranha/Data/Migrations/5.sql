--
-- Copyright (c) 2017 Håkan Edling
--
-- This software may be modified and distributed under the terms
-- of the MIT license.  See the LICENSE file for details.
-- 
-- http://github.com/piranhacms/piranha
-- 

CREATE TABLE [Piranha_MediaVersions] (
	[Id] NVARCHAR(36) NOT NULL,
	[MediaId] NVARCHAR(36) NOT NULL,
	[Width] INT NOT NULL,
    [Height] INT NULL,
	[Created] DATETIME NOT NULL,
	CONSTRAINT PK_MediaVersion_Id PRIMARY KEY ([Id]),
	CONSTRAINT FK_MediaVersion_MediaId FOREIGN KEY ([MediaId]) REFERENCES [Piranha_Media] ([Id]) ON DELETE CASCADE
);