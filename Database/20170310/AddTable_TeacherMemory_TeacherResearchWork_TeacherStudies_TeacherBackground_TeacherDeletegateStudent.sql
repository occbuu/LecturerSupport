USE [LSDB]
GO
/* Research Work */
Drop table [dbo].[ResearchWork]
Drop table [dbo].[TeacherBook]
Drop table [dbo].[TeacherResearch]
Go
Create TABLE [dbo].[TeacherResearchWork](
	[Id] [varchar](10) NOT NULL,
	[TeacherId] [bigint] NULL,
	[Title] [nvarchar](1000) NULL,
	[Description] [nvarchar](1000) NULL,
	[Level] [nvarchar](100) NULL,
	[Member] [nvarchar](1000) NULL,
	[Time] [varchar](20) NULL,
	[Type] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
	[CanDelete] [bit] NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	Primary Key(Id) 
)
ALTER TABLE [dbo].[TeacherResearchWork]
ADD CONSTRAINT fk_teacherresearchwork_teacher FOREIGN KEY (TeacherId) REFERENCES teacher(Id)
Go

/* Schedule */
Alter Table [dbo].[Schedule]
Add [TeacherId] [bigint] NULL
Go
ALTER TABLE [dbo].[Schedule]
ADD CONSTRAINT fk_schedule_teacher FOREIGN KEY (TeacherId) REFERENCES teacher(Id)
Go

/* [TeacherBackground] */
Create TABLE [dbo].[TeacherBackground](
	[Id] [varchar](10) NOT NULL,
	[TeacherId] [bigint] NULL,
	[Title] [nvarchar](1000) NULL,
	[Description] [nvarchar](2000) NULL,
	[Type] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
	[CanDelete] [bit] NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	Primary Key(Id) 
)
go
ALTER TABLE [dbo].[TeacherBackground]
ADD CONSTRAINT fk_background_teacher FOREIGN KEY (TeacherId) REFERENCES teacher(Id)
Go

/* TeacherDelegateStudent */
Create TABLE [dbo].[TeacherDelegateStudent](
	[StudentId] [bigint] NOT NULL,
	[TeacherId] [bigint] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Topic] [nvarchar](1000) NULL,
	[SupervisionType] [nvarchar](1000) NULL,
	[Time] [varchar](20) NULL,
	[Degree] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
	[CanDelete] [bit] NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,	 
)
Go
ALTER TABLE [dbo].[TeacherDelegateStudent]
ADD CONSTRAINT fk_teacherdelegatestudent_teacher FOREIGN KEY (TeacherId) REFERENCES teacher(Id)
ALTER TABLE [dbo].[TeacherDelegateStudent]
ADD CONSTRAINT fk_teacherdelegatestudent_student FOREIGN KEY (StudentId) REFERENCES student(Id)

/* [TeacherStudies] */
Create TABLE [dbo].[TeacherStudies](
	[Id] [bigint] NOT NULL,
	[TeacherId] [bigint] NOT NULL,
	[Title] [nvarchar](1000) NULL,
	[Description] [nvarchar](2000) NULL,
	[Type] [varchar](100) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[CanDelete] [bit] NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	Primary Key(Id) 
)
Go
ALTER TABLE [dbo].[TeacherStudies]
ADD CONSTRAINT fk_teacherstudies_teacher FOREIGN KEY (TeacherId) REFERENCES teacher(Id)

/* TeacherMemory */
Create TABLE [dbo].[TeacherMemory](
	[Id] [bigint] NOT NULL,
	[TeacherId] [bigint] NOT NULL,
	[Type] [varchar](100) NULL,
	[URL] [varchar](500) NULL,
	[FileExtension] [varchar](50) NULL,
	[FileName] [varchar](200) NULL,
	[UploadedBy] [varchar](200) NULL,
	[UploadedDate] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[CanDelete] [bit] NULL,
	[CreatedBy] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ModifiedDate] [datetime] NULL,
	Primary Key(Id) 
)
Go
ALTER TABLE [dbo].[TeacherMemory]
ADD CONSTRAINT fk_teachermemory_teacher FOREIGN KEY (TeacherId) REFERENCES teacher(Id)
Go
Alter Table [dbo].[Teacher]
Add Description nvarchar(MAX)