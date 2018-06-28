Use LSDB 

Go

Alter table schedule
Drop Constraint fk_schedule_subject

Go

Alter table StudentClass
Drop Constraint FK_StudentClass_Student

Go

Alter table StudentAttendance
Drop Constraint FK_Attendance_Student 

Go
Alter table Evaluation
Drop Constraint FK_Evaluation_Student 

Go 

Drop table Student

Go

CREATE TABLE [dbo].[Student](
	[Id] bigint NOT NULL Primary key, 
	[Pwd] [varchar](500) NOT NULL,
	[LastLogin] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	[LastIP] [varchar](50) NULL,
	[Birthday] [datetime] NULL,
	[FullName] [nvarchar](100) NULL,
	[Avatar] [varchar](255) NULL,
	[Address] [nvarchar](255) NULL,

)

GO

Alter table Student
Add PhoneNumber varchar(200)

Go

Alter table StudentClass
Drop column StudentId

go 

Alter table StudentClass
Add StudentId bigint

Go

Alter table StudentClass
Add Constraint FK_StudentClass_Student foreign key(StudentId) references Student(Id)

Go

Alter table Schedule
Drop column SubjectId

Go

CREATE TABLE [dbo].[ClassAnnouncement](
	[Id] [bigint] NOT NULL IDENTITY(1,1) ,
	[ClassId] [bigint] NULL,
	[Title] [nvarchar](500) NULL,
	[Brief] [nvarchar](500) NULL,
	[Type] [nvarchar](500) NULL,
	[Value] [nvarchar](max) NULL,
	[Status] [varchar](200) NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[MofidiedOn] [datetime] NULL,
	Primary key(Id)
)

Go

Alter table [ClassAnnouncement]
Add Constraint fk_ClassAnnouncement_Class foreign key(ClassId) references Class(Id)

Go

CREATE TABLE [dbo].[ClassDiscuss](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClassId] [bigint] NULL,
	[ParentId] [bigint] NULL,
	[Status] [varchar](10) NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[Level] [varchar](20) NULL,
	[Content] [nvarchar](max) NULL,
)

Go

Alter table [ClassDiscuss]
Add constraint Pk_ClassDiscuss primary key(Id)
Go

Alter table [ClassDiscuss]
Add Constraint fk_ClassDiscuss_Class foreign key(ClassId) references Class(Id)

Go

CREATE TABLE [dbo].[Document](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClassId] [bigint] NULL,
	[Title] [nvarchar] (500) NULL,
	[Description] [varchar](500) NULL,
	[Status] [varchar](10) NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[ModidiedBy] [varchar](200) NULL,	
	[ModidiedOn] [datetime] NULL,
	[Linkl] [varchar](200) NULL,
	[Image] [varchar](200) NULL,
	DocumentType [varchar](20) NULL,
	[Type] [varchar](20) NULL,
)

go

Alter table [Document]
Add Constraint fk_Document_Class foreign key(ClassId) references Class(Id)

Go 


Alter table [Document]
Add Constraint Pk_Document Primary key(Id)

Go

ALter table [StudentClass]
Add Score varchar(5)

Go

CREATE TABLE [dbo].[ScoreConfig](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClassId] [bigint] NULL,
	[TypeScore] [nvarchar](50) NULL,
	[PercentScore] [varchar](50) NULL,
	Primary key(Id)
)

Go

Alter table [ScoreConfig]
Add Constraint fk_ScoreConfig_Class foreign key(ClassId) references Class(Id)

Go

Alter table [StudentAttendance]
Drop column StudentId

Go 

Go
Alter table StudentClass
Drop FK_StudentClass_Student
Go

Alter table StudentClass
Drop column StudentId
GO

Alter table StudentAttendance
Add StudentId varchar(200)

Go

Alter table StudentClass
Add StudentId varchar(200)

Go

Drop table Student

Go

CREATE TABLE [dbo].[Student](
	[Id] varchar(200) NOT NULL, 
	[Pwd] [varchar](500) NOT NULL,
	[LastLogin] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	[LastIP] [varchar](50) NULL,
	[Birthday] [datetime] NULL,
	[FullName] [nvarchar](100) NULL,
	[Avatar] [varchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	Primary key(Id)

)

Go

Alter table Student
Add PhoneNumber varchar(200)

Go

Alter table StudentClass
Add Constraint FK_StudentClass_Student foreign key(StudentId) references Student(Id)

Go

Alter table [StudentAttendance]
Add Constraint FK_StudentAttendance_Student foreign key(StudentId) references Student(Id)

Go

CREATE TABLE [dbo].[CourseScore](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClassId] [bigint] NULL,
	[StudentId] [varchar](200) NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedOn] [datetime] NULL,
	[Score] [varchar](5) NULL,
	[TypeScore] [nvarchar](50) NULL,
	[PercentScore] [varchar](50) NULL,
	Primary key(Id)
)
Go

Alter table CourseScore
Add Constraint FK_CourseScore_Student foreign key(StudentId) references Student(Id)

Go
Alter table CourseScore
Add Constraint FK_CourseScore_Class foreign key(ClassId) references Class(Id)


















