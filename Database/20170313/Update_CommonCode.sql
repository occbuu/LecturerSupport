Use LSDB

Go
SET IDENTITY_INSERT [dbo].[Document] ON
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (21, 1, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Exercise', N'Exercise-1', N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>', NULL, NULL, NULL)
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (22, 1, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Exercise', N'Exercise-2', N'<p>Xưa ơi là xưa xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>', NULL, NULL, NULL)
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (23, 2, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Exercise', N'Exercise-1', N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>', NULL, NULL, NULL)
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (24, 2, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Exercise', N'Exercise-2', N'<p>Xưa ơi là xưa xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>', NULL, NULL, NULL)
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (25, 3, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Exercise', N'Exercise-1', N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>', NULL, NULL, NULL)
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (26, 3, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), N'admin', CAST(N'2017-03-12 20:36:06.573' AS DateTime), NULL, N'Exercise', N'Exercise-2', N'<p>Ng&agrave;y xửa ng&agrave;y xưa c&oacute; 40 t&ecirc;n cướp rất t&aacute;o bạo v&agrave; hun hăn. Ng&agrave;y xửa ng&agrave;y xưa c&oacute; 40 t&ecirc;n cướp rất t&aacute;o bạo v&agrave; hun hăn. Ng&agrave;y xửa ng&agrave;y xưa c&oacute; 40 t&ecirc;n cướp rất t&aacute;o bạo v&agrave; hun hăn</p>
', NULL, NULL, NULL)
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Content], [FileName], [FileExtension], [Linkl]) VALUES (27, 2, N'ewadasdasd', NULL, N'-1', N'admin', CAST(N'2017-03-12 21:04:34.830' AS DateTime), N'admin', CAST(N'2017-03-12 21:07:14.423' AS DateTime), NULL, N'Exercise', N'Exercise-2', N'<p>sadasdqad</p>
', N'27_20172112214876.xlsx', N'.xlsx', N'/Links/Document/Exercise/27_20172112214876.xlsx')
SET IDENTITY_INSERT [dbo].[Document] OFF

Go

CREATE TABLE [dbo].[AssignmentConfig](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DocumentId] [bigint] NULL,
	[ClassId] [bigint] NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[Status] [varchar](50) NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedOn] [datetime] NULL,
	[Content] [nvarchar](500) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	Primary key(Id)
)

go

Alter table [AssignmentConfig]
Add constraint fk_AssignmentConfig_Document foreign key([DocumentId]) references Document(Id)

Go

Alter table [AssignmentConfig]
Add constraint fk_AssignmentConfig_Class foreign key([ClassId]) references Class(Id)


Go

CREATE TABLE [dbo].[StudentExcercise](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DocumentId] [bigint] NULL,
	[ClassId] [bigint] NULL,
	[StudentId] [bigint] NULL,
	[CreatedOn] [datetime] NULL,
	[Link] [text] NULL,
	[FileName] [text] NULL,
	[FileExtension] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Content] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedOn] [datetime] NULL,
	Primary key(Id)
)

Go

Alter table [StudentExcercise]
Add constraint fk_StudentExcercise_Document foreign key([DocumentId]) references Document(Id)

Go

Alter table [StudentExcercise]
Add constraint fk_StudentExcercise_Class foreign key([ClassId]) references Class(Id)

go

Alter table [StudentExcercise]
Add constraint fk_StudentExcercise_Student foreign key(StudentId) references Student(Id)


