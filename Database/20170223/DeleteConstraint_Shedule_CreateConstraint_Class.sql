USE LSDB

GO

ALTER TABLE SCHEDULE
DROP CONSTRAINT FK_University

Go

Alter table Class
Add UniversityId bigint

Go 

ALTER TABLE CLASS
ADD CONSTRAINT FK_Class_University foreign key(UniversityId) references University(Id) 