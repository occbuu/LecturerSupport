Alter table [dbo].[CommonCode] 
Alter column [CreatedBy] varchar(200)

Insert Into [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [NumValue1] ,[NumValue2]) Values('NewsCategory','Announcement','Announcement',0,1)
Update [dbo].[Users] 
set Pwd = 'e10adc3949ba59abbe56e057f20f883e'
where UserId = 'admin'
