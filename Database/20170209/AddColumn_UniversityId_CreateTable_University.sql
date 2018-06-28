USE LSDB

GO

CREATE TABLE University
(
	Id bigint IDENTITY(1,1) NOT NULL,
	Name nvarchar(500) NULL,
	[Description] nvarchar(500) NULL,
	[Address] [varchar](200) NULL,
	PRIMARY KEY(Id)
)

GO

ALTER TABLE Schedule
ADD UniversityId BIGINT

GO
ALTER TABLE Schedule
ADD CONSTRAINT FK_University FOREIGN KEY(UniversityId) REFERENCES UNIVERSITY(Id)

GO
SET IDENTITY_INSERT [University] ON
INSERT [dbo].[University] ([Id], [Name], [Description], [Address]) VALUES (1, N'Ho Chi Minh University Of Social Sciences And Humantities', N'Special University', N'10-12 Dinh Tien Hoang, Ben Nghe, Quan 1, Ho Chi Minh, Viet Nam')
INSERT [dbo].[University] ([Id], [Name], [Description], [Address]) VALUES (2, N'Ho Chi Minh University Of Culture', N'Special University', N'51 Quoc Huong,Thao Dien, Quan 2, Ho Chi Minh, Viet Nam')
INSERT [dbo].[University] ([Id], [Name], [Description], [Address]) VALUES (3, N'HUTECH', N'Special University', N'475A Dien Bien Phu, Binh Thanh, TPHCM ')
SET IDENTITY_INSERT [University] OFF
GO