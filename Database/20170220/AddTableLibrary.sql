USE [LSDB]
GO

/****** Object:  Table [dbo].[Library]    Script Date: 2/20/2017 3:32:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO
Drop table [dbo].[Library]

CREATE TABLE [dbo].[Library](
	[Id]			[bigint]		IDENTITY(1,1)	NOT NULL,
	[Type]			[nvarchar]		(200)			NULL,
	[Title]			[nvarchar]		(1000)			NULL,
	[Brief]			[nvarchar]		(2000)			NULL,
	[Links]			[varchar]		(max)			NULL,
	[Keyword]		[nvarchar]		(4000)			NULL,
	[Description]	[nvarchar]		(4000)			NULL,
	[Status]		[varchar]		(50)			NULL,
	[Images]		[nvarchar]		(50)			NULL,
	[CreatedBy]		[varchar]		(250)			NULL,
	[CreateDate]	[smalldatetime]					NULL,
	[ModifiedBy]	[varchar]		(250)			NULL,
	[ModifiedDate]	[smalldatetime]					NULL,

 CONSTRAINT [PK_Library] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO