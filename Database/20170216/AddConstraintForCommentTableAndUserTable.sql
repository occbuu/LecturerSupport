USE [LSDB]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 2/16/2017 11:23:42 AM ******/
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Users] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
