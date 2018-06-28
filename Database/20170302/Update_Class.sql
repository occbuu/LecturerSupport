use LSDB
go
update Class set [Status]='1' where [Status]='ACT'


Go

CREATE TABLE [dbo].[Teacher](
	[Id] bigint identity(1,1) NOT NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	[Birthday] [datetime] NULL,
	[FullName] [nvarchar](200) NULL,
	[Address] [nvarchar](200) NULL,
	[Status] [varchar](20) NULL,
	[PhoneNumber] [varchar](200) NULL,
	[TypeTeacherId] bigint NULL,
	Primary key(Id)
)

go

SET IDENTITY_INSERT [dbo].[Teacher] ON 
INSERT [dbo].[Teacher] ([Id], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Birthday], [FullName], [Address], [Status], [PhoneNumber], [TypeTeacherId]) VALUES (1, N'Admin', CAST(N'2015-07-20 00:00:00.000' AS DateTime), N'Admin', CAST(N'2015-07-20 00:00:00.000' AS DateTime), CAST(N'2015-07-20 00:00:00.000' AS DateTime), N'Nguyễn Thị Lan', N'75A Điện Biên Phủ', N'1', N'0918723389', 1)
INSERT [dbo].[Teacher] ([Id], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Birthday], [FullName], [Address], [Status], [PhoneNumber], [TypeTeacherId]) VALUES (2, N'Admin', CAST(N'2015-07-20 00:00:00.000' AS DateTime), N'Admin', CAST(N'2015-07-20 00:00:00.000' AS DateTime), CAST(N'2015-07-20 00:00:00.000' AS DateTime), N'Trần Thị Tuyết Anh', N'900A Điện Biên Phủ', N'1', N'0963880753', 2)
SET IDENTITY_INSERT [dbo].[Teacher] Off
Go

Alter table Class
Add constraint fk_class_teacher foreign key(TeacherId) references Teacher(Id)


Alter table Class
Drop column TeachingAssistantId

Go

Alter table Class
Add TeachingAssistantId bigint

go

update Class set TeachingAssistantId=2

Go

Alter table Class
Add constraint fk_class_teacherassitant foreign key(TeachingAssistantId) references Teacher(Id)


