
CREATE DATABASE LaserlabDBManual

USE LaserlabDBManual

GO

CREATE TABLE Persons
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(30) NOT NULL,
	[MiddleName] NVARCHAR(30)  NULL,
	[SurName] NVARCHAR(30) NOT NULL,
	[BirthDate] DATE NOT NULL,
	[IsAdmin] BIT NOT NULL,
	[IsUser] BIT NOT NULL,
	[IsCollaborator] BIT NOT NULL
)

INSERT INTO Persons VALUES ('Olgun','','Erguzel','1984-02-29', 1,1,1)
INSERT INTO Persons VALUES ('Gokhan','','Bilir','1979-3-13', 0,1,1)
INSERT INTO Persons VALUES ('Hatun','Cinkaya','Yilmaz','1981-4-9', 0,0,1)

CREATE Table Emails
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	eMail NVARCHAR(30) NOT NULL UNIQUE
)

INSERT INTO Emails VALUES ('sriperg@gmail.com')
INSERT INTO Emails VALUES ('gokhan@gmail.com')
INSERT INTO Emails VALUES ('hatun@gmail.com')

CREATE TABLE PersonEmails
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Person_Id INT FOREIGN KEY REFERENCES Persons(Id) NULL,
	Email_Id INT FOREIGN KEY REFERENCES Emails(Id) NULL,
	CONSTRAINT PersonEmails_Id_PersonId_EmailId UNIQUE (Id, Person_Id, Email_Id)
)

INSERT INTO PersonEmails VALUES (1,1)
INSERT INTO PersonEmails VALUES (2,2)
INSERT INTO PersonEmails VALUES (3,3)


CREATE TABLE Authorizations
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	UserName NVARCHAR(50) NOT NULL UNIQUE,
    [PassWord] NVARCHAR(50) NOT NULL,
	CONSTRAINT UX_UserName_PassWord UNIQUE (UserName, [Password])
)

Set IDENTITY_INSERT Authorizations ON

INSERT INTO Authorizations VALUES ('olgunerguzel','s2294150932')
INSERT INTO Authorizations VALUES ('gokhanbilir','g2294150932b')
INSERT INTO Authorizations VALUES ('hcinkaya','h2294150932bc')

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Authorization_Id INT FOREIGN KEY REFERENCES Authorizations(Id) NOT NULL
)

INSERT INTO Users VALUES (1)
INSERT INTO Users VALUES (2)

CREATE TABLE PersonUsers
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Person_Id INT FOREIGN KEY REFERENCES Persons(Id) NULL,
	[User_Id] INT FOREIGN KEY REFERENCES Users(Id) NULL,
)

INSERT INTO PersonUsers VALUES (1,1)
INSERT INTO PersonUsers VALUES (2,2)