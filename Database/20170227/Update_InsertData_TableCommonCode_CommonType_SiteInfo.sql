/* CommonCode */
Update CommonCode Set StrValue1 = 'Images Class', CommonTypeId = 'Teacher' Where CommonId = 'ImagesClass'
Update CommonCode Set CommonTypeId = 'Teacher' Where CommonId = 'Comment'
Update CommonCode Set CommonTypeId = 'Teacher' Where CommonId = 'Content'

/* CommonType */
Delete from CommonType where Type = 'Setting'
INSERT [dbo].[CommonType]([CommonTypeId], [Description], [Note], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Qty], [Type]) VALUES (N'SiteInfoHome',N'SiteInfo Home',NULL,NULL,NULL,NULL,NULL,NULL,N'Setting')
Insert into CommonType([CommonTypeId], [Description] ,[Type]) Values ('Teacher','Teacher','InformationManagement')

/* SiteInfo */
Update SiteInfo Set type = 'TopBar' Where type = 'Top Bar'
Update SiteInfo Set type = 'SocialNetwork' Where type = 'Social Network'
Update SiteInfo Set type = 'SlideShow' Where type = 'Slide Show'
Update SiteInfo Set brief = 'Address' Where Name = 'Address'
Update SiteInfo Set brief = 'Email' Where Name = 'Email'
Update SiteInfo Set brief = 'Phone' Where Name = 'Phone'
Update SiteInfo Set brief = 'FaceBook' Where Name = 'FaceBook'
Update SiteInfo Set brief = 'Twitter' Where Name = 'Twitter'
Update SiteInfo Set brief = 'GooglePlus' Where Name = 'GooglePlus'
Update SiteInfo Set brief = 'Wordpress' Where Name = 'Wordpress'
Update SiteInfo Set brief = 'Instagram' Where Name = 'Instagram'
Update SiteInfo Set brief = 'Skype' Where Name = 'Skype'
Update SiteInfo Set brief = 'Multi Language' Where Name = 'MultiLanguage'



