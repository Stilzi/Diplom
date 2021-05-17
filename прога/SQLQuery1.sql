CREATE DATABASE Dormitory

USE Dormitory

CREATE TABLE [Floor] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[FloorNumber]	INT																																										NOT NULL
)

CREATE TABLE [Rooms] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[Number]		NVARCHAR(10)																																							NOT NULL,
	[IdFloor]		INT	CONSTRAINT FK_Rooms_Floor FOREIGN KEY REFERENCES [Floor] ([Id])																										NOT NULL
)

CREATE TABLE [Students] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[Name]			NVARCHAR(30)																																							NOT NULL,
	[IdRoom]        INT	CONSTRAINT FK_Students_Rooms FOREIGN KEY REFERENCES [Rooms]	([Id])																									NOT NULL,
	[IdGroup]		INT CONSTRAINT FK_Students_Group FOREIGN KEY REFERENCES	[Group] ([Id])																									NOT NULL
)

CREATE TABLE [Group] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[NumberGroup]	NVARCHAR(10) 																																							NOT NULL
)

CREATE TABLE [Watch] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[JanitorId]		INT CONSTRAINT FK_Watch_Janitor FOREIGN KEY REFERENCES [Janitor] ([Id])																									NOT NULL,
	[ChangeId]		INT CONSTRAINT FK_Watch_Change  FOREIGN KEY REFERENCES [Change]  ([Id])																									NOT NULL,
	[FloorId]		INT CONSTRAINT FK_Watch_Floor   FOREIGN KEY REFERENCES [Floor]   ([Id])																									NOT NULL
)

CREATE TABLE [Janitor] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[JanitorName]	NVARCHAR(30)																																							NOT NULL
)

CREATE TABLE [Change] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[ChangeTime]	NVARCHAR(10)																																							NOT NULL
)

CREATE TABLE [Registration] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[Login]			NVARCHAR(30)																																							NOT NULL,
	[Password]		NVARCHAR(30)																																							NOT NULL,
	[RoleId]		INT CONSTRAINT FK_Role_Id FOREIGN KEY REFERENCES [Role] ([Id])																											NOT NULL
)

CREATE TABLE [Role] (
	[Id]			INT PRIMARY KEY IDENTITY(1,1)																																					,
	[Role]			NVARCHAR(30)																																							NOT NULL
)

