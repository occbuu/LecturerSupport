Use LSDB

Go

Alter table Schedule
Add AddressUniversityId bigint
Go
Alter table Schedule
Add constraint fk_Schedule_AddressUniversity foreign key(AddressUniversityId) references AddressUniversity(Id)

Go

Update Schedule set Status=1

go

Alter table [Subject]
add CanDelete bit