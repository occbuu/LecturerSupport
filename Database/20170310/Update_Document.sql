Use LSDB
Go

INSERT [dbo].[CommonType] ([CommonTypeId], [Description], [Note], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Qty], [Type]) VALUES (N'Document', N'Document', NULL, NULL, NULL, NULL, NULL, NULL, N'Manage Class')


go

INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'Conspectus', N'Đề Cương', NULL, NULL, CAST(1 AS Decimal(20, 0)), CAST(1 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'Conspectus-1', N'Chính', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'Conspectus-2', N'Tham khảo', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'Exercise', N'Bài tập và Đồ án', NULL, NULL, CAST(1 AS Decimal(20, 0)), CAST(1 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'Exercise-1', N'Bắt buộc', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'Exercise-2', N'Mở rộng', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'LessonReferences', N'Giáo trình/ Tài liệu tham khảo', NULL, NULL, CAST(1 AS Decimal(20, 0)), CAST(1 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'LessonReferences-1', N'Chính', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'LessonReferences-2', N'Tham khảo', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CommonCode] ([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'Document', N'LessonReferences-3', N'Mở rộng', NULL, NULL, CAST(2 AS Decimal(20, 0)), CAST(0 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)





Go

SET IDENTITY_INSERT [dbo].[Document] ON 

INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (1, 1, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Comspectus', N'Comspectus-1', NULL, N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (2, 1, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Comspectus', N'Comspectus-2', NULL, N'<p>Xưa ơi là xưa xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (3, 1, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'LessonReferences', N'LessonReferences-1', NULL, N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (4, 1, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'LessonReferences', N'LessonReferences-2', NULL, N'<p>Xưa ơi là xưa xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (5, 1, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'LessonReferences', N'LessonReferences-3', NULL, N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (6, 2, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'LessonReferences', N'LessonReferences-2', NULL, N'<p>Xưa ơi là xưa xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (7, 2, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Comspectus', N'Comspectus-1', NULL, N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (8, 2, N'40 tên cướp  Alibaba', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Comspectus', N'Comspectus-2', NULL, N'<p>Xưa ơi là xưa xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (9, 2, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'LessonReferences', N'LessonReferences-3', NULL, N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')
INSERT [dbo].[Document] ([Id], [ClassId], [Title], [Description], [Status], [CreatedBy], [CreateDate], [ModidiedBy], [ModidiedOn], [Image], [DocumentType], [Type], [Linkl], [Content]) VALUES (10, 2, N'Alibaba và 40 tên cướp', NULL, N'1', N'admin', CAST(N'2019-07-20 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'LessonReferences', N'LessonReferences-1', NULL, N'<p>Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn. Ngày xửa ngày xưa có 40 tên cướp rất táo bạo và hun hăn</p>')

SET IDENTITY_INSERT [dbo].[Document] OFF

Go


alter table document
add [FileName] text

Go

alter table document
add [FileExtension] varchar(200)

go

alter table document
drop column Linkl

go
alter table document
add Linkl text




