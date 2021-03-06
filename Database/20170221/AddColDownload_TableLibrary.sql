/*
   Tuesday, February 21, 20173:23:35 PM
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
ALTER TABLE dbo.Library ADD
	Download bigint NULL
GO
ALTER TABLE dbo.Library SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
