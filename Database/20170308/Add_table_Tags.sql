USE LSDB
GO

CREATE TABLE Tags
(
Id BIGINT IDENTITY(1,1) NOT NULL,
TagName VARCHAR(255),
Type VARCHAR(255),
TagId VARCHAR(255),
PRIMARY KEY(id)
)
