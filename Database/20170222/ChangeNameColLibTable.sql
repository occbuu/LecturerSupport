/*
   Wednesday, February 22, 201710:25:44 AM
   User: ls_web
   Server: .\SQLEXPRESS
   Database: LSDB
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.Library.CreateDate', N'Tmp_CreatedDate', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Library.Tmp_CreatedDate', N'CreatedDate', 'COLUMN' 
GO
ALTER TABLE dbo.Library SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
