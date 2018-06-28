use LSDB

go

Alter table Class
Add constraint fk_class_subject foreign key(subjectId) references Subject(id)