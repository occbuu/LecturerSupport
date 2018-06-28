use LSDB
go

/*--Step 1--*/

Alter table [dbo].[Comment] 
Alter column [ObjectLinkID] bigint

/*--Step 2--*/
Alter table [dbo].[Comment] 
Add constraint fk_Comment_News foreign key(ObjectLinkID) references News(Id)
