USE [LSDB]
GO
/****** Object:  Table [dbo].[Library]    Script Date: 172/2/2017 04:40:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Library(

	[Id]			[bigint]	IDENTITY(1,1)	NOT NULL,
	[Type]			[nvarchar]	(max)			NULL,
	[ObjectId]		[bigint]					NULL,
	[Title]			[nvarchar]	(2000)			NULL,
	[NewBrief]		[nvarchar]	(2000)			NULL,
	[NewsDetail]	[ntext]						NULL,
	[CreatedBy]		[varchar]	(250)			NULL,
	[Editor]		[varchar]	(250)			NULL,
	[Links]			[varchar]	(max)			NULL,
	[Files]			[varchar]	(max)			NULL,
	[Keyword]		[nvarchar]	(max)			NULL,
	[Description]	[nvarchar]	(max)			NULL,
	[Status]		[nvarchar]	(max)			NULL,
	[Images]		[nvarchar]	(max)			NULL,
	[CreateDate]	[datetime]					NULL,
	[UpdateDate]	[datetime]					NULL,
	[DeleteDate]	[datetime]					NULL,

 CONSTRAINT [PK_Library] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Library]  WITH NOCHECK ADD  CONSTRAINT [FK_Library_Links] FOREIGN KEY([ObjectId])
REFERENCES [dbo].[Links] ([Id])
GO
--Information
/*
 * Author       : 
 * Email        : 
 * Phone        : 
 * ------------------------------- *
 * Create       : 17/2/2017 16:55
 * Update       : 
 * Checklist    : 1.1
 * Status       : OK
 */