ALTER TABLE [dbo].[CommonType]
ADD Qty int, Type nvarchar(100)
Go
INSERT [dbo].[CommonType]([CommonTypeId], [Description], [Note], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Qty], [Type]) VALUES (N'SiteInfoHome',N'SiteInfo Home',NULL,NULL,NULL,NULL,NULL,NULL,N'Setting')

ALTER TABLE [dbo].[CommonCode]
ADD Qty int, Type nvarchar(100)
Go
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'TopBar','Top Bar',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,4,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'SocialNetwork','Social Network',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,6,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'Footer','Footer',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,15,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'Content','Content',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,8,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'ImagesClass','ImagesClass',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,10,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'Dashboar','Dashboar',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,6,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'SlideShow','Slide Show',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,10,N'Setting')
INSERT [dbo].[CommonCode]([CommonTypeId], [CommonId], [StrValue1], [StrValue2], [StrValue3], [NumValue1], [NumValue2], [CanDelete], [CreatedDate], [ModifiedBy], [ModifiedDate], [Sequence], [Qty], [Type]) VALUES (N'SiteInfoHome',N'Comment','Comment',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,4,N'Setting')




