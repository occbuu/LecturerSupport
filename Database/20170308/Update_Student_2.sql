Use LSDB

Go

INSERT [dbo].[Users] ([UserId], [Pwd], [ObjectId], [LastLogin], [Status], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [HackTimes], [LastIP], [Birthday], [FullName], [Avatar], [Address1]) VALUES (N'bangst9', N'123456', N'201701010003', NULL, N'1', N'admin', CAST(N'2016-06-06 00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users] ([UserId], [Pwd], [ObjectId], [LastLogin], [Status], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [HackTimes], [LastIP], [Birthday], [FullName], [Avatar], [Address1]) VALUES (N'leek', N'123456', N'201701010004', NULL, N'1', N'admin', CAST(N'2016-06-06 00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users] ([UserId], [Pwd], [ObjectId], [LastLogin], [Status], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [HackTimes], [LastIP], [Birthday], [FullName], [Avatar], [Address1]) VALUES (N'mantu07', N'123456', N'201701010002', NULL, N'1', N'admin', CAST(N'2016-06-06 00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users] ([UserId], [Pwd], [ObjectId], [LastLogin], [Status], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [HackTimes], [LastIP], [Birthday], [FullName], [Avatar], [Address1]) VALUES (N'baby612', N'123456', N'201701010005', NULL, N'1', N'admin', CAST(N'2016-06-06 00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)

Go

Alter table StudentClass
Drop column StudentId

Go

Alter table CourseScore
Drop column StudentId

go


Alter table StudentAttendance
Drop column StudentId

go


Alter table StudentClass
Add StudentId bigint

Go

Alter table CourseScore
Add StudentId bigint

go


Alter table StudentAttendance
Add StudentId bigint

Go
--fk

Alter table StudentClass
Add constraint fk_StudentClass_Student foreign key(StudentId) references Student(Id)

Go

Alter table CourseScore
Add constraint fk_CourseScore_Student foreign key(StudentId) references Student(Id)

go


Alter table StudentAttendance
Add constraint fk_StudentAttendance_Student foreign key(StudentId) references Student(Id)


go

alter table CourseScore
Add Status varchar(20)

go

--Student--


SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [ObjectId], [Code], [Status], [SchoolId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn]) VALUES (1, N'201701010002', N'1311060953', N'1', 1, N'Admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Student] ([Id], [ObjectId], [Code], [Status], [SchoolId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn]) VALUES (2, N'201701010003', N'1311060974', N'1', 2, N'Admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Student] ([Id], [ObjectId], [Code], [Status], [SchoolId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn]) VALUES (3, N'201701010004', N'1311060988', N'1', 3, N'Admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Student] ([Id], [ObjectId], [Code], [Status], [SchoolId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn]) VALUES (4, N'201701010005', N'1311060999', N'1', 3, N'Admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
 
--Course Score--

SET IDENTITY_INSERT [dbo].[CourseScore] ON 

INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (1, 1, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'8', N'Giữa Kỳ', N'30', N'1', 1)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (2, 1, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'8', N'Cuối Kỳ', N'70', N'1', 1)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (3, 2, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'7', N'Giữa Kỳ', N'30', N'1', 1)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (4, 2, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'7', N'Cuối Kỳ', N'70', N'1', 1)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (5, 1, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'8.5', N'Giữa Kỳ', N'30', N'1', 2)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (6, 1, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'9.5', N'Cuối Kỳ', N'70', N'1', 2)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (7, 1, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'7', N'Giữa Kỳ', N'30', N'1', 3)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (8, 1, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'7', N'Cuối Kỳ', N'70', N'1', 3)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (9, 3, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'7', N'Giữa Kỳ', N'30', N'1', 2)
INSERT [dbo].[CourseScore] ([Id], [ClassId], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [TypeScore], [PercentScore], [Status], [StudentId]) VALUES (10, 3, N'Admin', CAST(N'2017-07-20 00:00:00.000' AS DateTime), NULL, NULL, N'6', N'Cuối Kỳ', N'70', N'1', 2)
SET IDENTITY_INSERT [dbo].[CourseScore] OFF



--StudentClass--

SET IDENTITY_INSERT [dbo].[StudentClass] ON 

INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (1, 1, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (2, 2, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (3, 1, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 2)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (4, 3, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 2)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (5, 2, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 3)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (6, 3, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 3)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (7, 1, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 3)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (8, 3, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (9, 4, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 2)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (11, 2, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 4)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (12, 5, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 2)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (13, 12, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (14, 13, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 2)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (15, 14, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 3)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (16, 15, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[StudentClass] ([Id], [ClassId], [Status], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [Score], [StudentId]) VALUES (17, 16, N'ACT', N'admin', CAST(N'2017-01-01 00:00:00.000' AS DateTime), NULL, NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[StudentClass] OFF


Go

Update Object set DoB = CAST(N'1995-09-20 00:00:00.000' AS DateTime) where (ObjectId >=201701010001) and (ObjectId <=201701010005)

go

Update Object set TemAdd='Tien Giang' where (ObjectId >=201701010001) and (ObjectId <=201701010005)




