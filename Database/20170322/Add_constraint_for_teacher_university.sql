USE LSDB
GO

ALTER TABLE Teacher ADD SchoolId bigint
GO

Alter table Teacher
Add constraint fk_Teacher_University foreign key(SchoolId) references University(Id)