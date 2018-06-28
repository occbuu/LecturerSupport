Use LSDB

go

Alter table CourseScore
drop FK_CourseScore_Student


Go

Alter table StudentAttendance
drop FK_StudentAttendance_Student

go

Alter table StudentClass
drop FK_StudentClass_Student

go

Drop table Student

go

CREATE TABLE [dbo].[Student](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ObjectId] [varchar](20) NULL,
	[Code] [varchar](20) NULL,
	[Status] [varchar](20) NULL,
	[SchoolId] bigint NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[ModifiedOn] [datetime] NULL,
	primary key(Id)
)

go

Alter table Student
Add constraint fk_Student_Object foreign key(ObjectId) references Object(ObjectId)

Go

Alter table Student
Add constraint fk_Student_University foreign key(SchoolId) references University(Id)





