Use LSDB


go

Drop table StutdentScore
go


Alter table Document
Add Content ntext

Go

Alter table ScoreConfig
Add 
[Status] varchar(20),
CreatedBy nvarchar(200),
CreatedOn datetime,
ModifiedBy nvarchar(200),
ModifiedOn datetime

Go

CREATE TABLE [dbo].[AddressUniversity](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	UniversityId bigint,
	[Address] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedOn] [datetime] NULL,
	[Status] [varchar](50) NULL,
	Primary key(Id)
)

Alter table [AddressUniversity]
Add constraint dk_AddressUniversity_University foreign key(UniversityId) references University(Id)








