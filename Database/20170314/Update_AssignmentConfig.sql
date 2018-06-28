USE [LSDB]
GO
SET IDENTITY_INSERT [dbo].[AssignmentConfig] ON 

INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (1, 21, 1, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 1', CAST(N'2017-07-20 00:00:00.000' AS DateTime), CAST(N'2017-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (2, 21, 1, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 2', CAST(N'2017-08-20 00:00:00.000' AS DateTime), CAST(N'2017-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (3, 22, 1, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 1', CAST(N'2017-07-20 00:00:00.000' AS DateTime), CAST(N'2017-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (4, 22, 1, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 2', CAST(N'2017-08-20 00:00:00.000' AS DateTime), CAST(N'2017-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (5, 23, 2, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 1', CAST(N'2017-07-20 00:00:00.000' AS DateTime), CAST(N'2017-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (6, 23, 2, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 2', CAST(N'2017-08-20 00:00:00.000' AS DateTime), CAST(N'2017-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (7, 24, 2, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 1', CAST(N'2017-07-20 00:00:00.000' AS DateTime), CAST(N'2017-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (8, 24, 2, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 2', CAST(N'2017-08-20 00:00:00.000' AS DateTime), CAST(N'2017-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (9, 25, 3, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 1', CAST(N'2017-07-20 00:00:00.000' AS DateTime), CAST(N'2017-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (10, 25, 3, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 2', CAST(N'2017-08-20 00:00:00.000' AS DateTime), CAST(N'2017-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (11, 26, 3, N'admin', NULL, N'1', NULL, NULL, N'Nộp Bài Lần 1', CAST(N'2017-07-20 00:00:00.000' AS DateTime), CAST(N'2017-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (12, 26, 3, N'admin', NULL, N'0', NULL, NULL, N'Nộp Bài Lần 2', CAST(N'2017-08-20 00:00:00.000' AS DateTime), CAST(N'2017-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[AssignmentConfig] ([Id], [DocumentId], [ClassId], [CreatedBy], [CreatedOn], [Status], [ModifiedBy], [ModifiedOn], [Content], [StartDate], [EndDate]) VALUES (15, 27, 2, N'admin', CAST(N'2017-03-13 21:51:33.793' AS DateTime), N'0', NULL, NULL, N'Nộp bài lần 2', CAST(N'2017-03-15 00:00:00.000' AS DateTime), CAST(N'2017-03-25 00:00:00.000' AS DateTime))

SET IDENTITY_INSERT [dbo].[AssignmentConfig] OFF

Go

Alter table StudentExcercise
Add AssignmentConfigId  bigint

Go

Alter table StudentExcercise
Add constraint fk_StudentExcercise_AssignmentConfig foreign key(AssignmentConfigId) references AssignmentConfig(Id)