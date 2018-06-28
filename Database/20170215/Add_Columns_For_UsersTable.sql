USE LSDB
GO

ALTER TABLE [dbo].[Users] ADD Birthday DateTime
GO
ALTER TABLE [dbo].[Users] ADD FullName nvarchar(100)
GO
ALTER TABLE [dbo].[Users] ADD Avatar varchar(255)
GO
ALTER TABLE [dbo].[Users] ADD Address1 nvarchar(255)
GO