

--Run this seperately 
CREATE DATABASE [Numeric]
--Run the rest after running the create database statement
USE [Numeric]

CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountUsername] [varchar](50) NOT NULL,
	[AccountPass] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
PRIMARY KEY (AccountID)
)

GO
CREATE PROC [dbo].[spNewUser]
(
@user varchar(50),
@pass varchar(50),
@firstName varchar(50),
@lastName varchar(50)

)

AS 
BEGIN

INSERT INTO Accounts
values (@user, @pass, @firstName, @lastName)

END
GO



CREATE PROC [dbo].[spUserAccount]
(
@user varchar(50), @pass varchar(50)
)

AS 
BEGIN

select * 
from
Accounts
where AccountUsername = @user AND AccountPass = @pass

END
GO

