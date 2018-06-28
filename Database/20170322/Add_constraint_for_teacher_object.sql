USE LSDB
GO

ALTER TABLE Teacher ADD ObjectId varchar(20)
GO

Alter table Teacher
Add constraint fk_Teacher_Object foreign key(ObjectId) references Object(ObjectId)