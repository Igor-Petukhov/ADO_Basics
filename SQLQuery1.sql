﻿--CREATE TABLE Users(
--	Id INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(64) NOT NULL
--	)

--DROP TABLE Users

--CREATE TABLE Products(
--	Id INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(64) NOT NULL,
--  price DECIMAL NOT NULL
--	)
--DROP TABLE Products

CREATE TABLE Sales(
	Id INT PRIMARY KEY IDENTITY(1,1),
	id_user INT NOT NULL,
	id_product INT NOT NULL,
	moment DATE NOT NULL
	)

DROP TABLE Sales
