/* CommonCode */
DELETE FROM CommonCode WHERE CommonTypeId = 'CommentType'
DELETE FROM CommonCode WHERE CommonTypeId = 'CountryID'
DELETE FROM CommonCode WHERE CommonTypeId = 'CustomerType'
DELETE FROM CommonCode WHERE CommonTypeId = 'LinkType'
DELETE FROM CommonCode WHERE CommonTypeId = 'LogType'
DELETE FROM CommonCode WHERE CommonTypeId = 'MessageType'
DELETE FROM CommonCode WHERE CommonTypeId = 'NewsCategory'
DELETE FROM CommonCode WHERE CommonTypeId = 'ObjectGroup'
DELETE FROM CommonCode WHERE CommonTypeId = 'OrderType'
DELETE FROM CommonCode WHERE CommonTypeId = 'PaymentType'
DELETE FROM CommonCode WHERE CommonTypeId = 'ProvinceID'
DELETE FROM CommonCode WHERE CommonTypeId = 'QuestionType'
DELETE FROM CommonCode WHERE CommonTypeId = 'SiteInfoType'
DELETE FROM CommonCode WHERE CommonTypeId = 'ObjectType'

/* CommonType */
DELETE FROM CommonType WHERE CommonTypeId = 'CommentType'
DELETE FROM CommonType WHERE CommonTypeId = 'CountryID'
DELETE FROM CommonType WHERE CommonTypeId = 'CustomerType'
DELETE FROM CommonType WHERE CommonTypeId = 'EventType'
DELETE FROM CommonType WHERE CommonTypeId = 'LinkType'
DELETE FROM CommonType WHERE CommonTypeId = 'Location'
DELETE FROM CommonType WHERE CommonTypeId = 'LogType'
DELETE FROM CommonType WHERE CommonTypeId = 'MessageType'
DELETE FROM CommonType WHERE CommonTypeId = 'NewsCategory'
DELETE FROM CommonType WHERE CommonTypeId = 'ObjectGroup'
DELETE FROM CommonType WHERE CommonTypeId = 'ObjectType'
DELETE FROM CommonType WHERE CommonTypeId = 'OrderType'
DELETE FROM CommonType WHERE CommonTypeId = 'PaymentType'
DELETE FROM CommonType WHERE CommonTypeId = 'Price'
DELETE FROM CommonType WHERE CommonTypeId = 'ProductDetailGroup'
DELETE FROM CommonType WHERE CommonTypeId = 'ProductDetailType'
DELETE FROM CommonType WHERE CommonTypeId = 'ProductType'
DELETE FROM CommonType WHERE CommonTypeId = 'ProvinceID'
DELETE FROM CommonType WHERE CommonTypeId = 'QuestionType'
DELETE FROM CommonType WHERE CommonTypeId = 'SearchType'
DELETE FROM CommonType WHERE CommonTypeId = 'SiteInfoType'
DELETE FROM CommonType WHERE CommonTypeId = 'Unit'
DELETE FROM CommonType WHERE CommonTypeId = 'ValueType'
DELETE FROM CommonType WHERE CommonTypeId = 'PromotionType'
 
 /* Insert Commontype */
Insert Into CommonType(CommonTypeId,Description) Values('Home','Home')
Insert Into CommonType(CommonTypeId,Description) Values('Introduction','Introduction')
Insert Into CommonType(CommonTypeId,Description) Values('Announcement','Announcement')
Insert Into CommonType(CommonTypeId,Description) Values('English','English')
Insert Into CommonType(CommonTypeId,Description) Values('JapaneseStudies','Japanese Studies')

  /* Insert CommonCode */
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-1','About Me','AboutMe','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-2','Teaching','Teaching','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-3','Studies','Studies','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-4','Research Works','ResearchWorks','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-5','My Class','MyClass','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-6','Delegate Students','DelegateStudents','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-7','Memory And Gallery','Gallery','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-8','Schedule','Schedule','About')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Introduction','Introduction-9','Contact','Contact','About')

Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Announcement','Announcement-1','Survey','Survey','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Announcement','Announcement-2','Announcement','Announcement','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Announcement','Announcement-3','Open Library','OpenLibrary','Library')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Announcement','Announcement-3-1','English Linguistic','EnglishLinguistic','Library')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('Announcement','Announcement-3-2','Japan Studies','JStudies','Library')

Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1','English Linguistic','EnglishLinguistic','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English1-1','Phonology','Phonology','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1-2','Morphonology','Morphonology','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1-3','Syntax','Syntax','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1-4','Semantic','Semantic','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1-5','Pragmatic','Pragmatic','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1-6','Functional Grammar','FunctionalGrammar','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-1-7','Literature Linguistic','LiteratureLinguistic','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-2','Grammar','Grammar','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-3','Translation','Translation','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-4','Skill','Skill','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-5','Comparation','Comparation','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('English','English-6','English Teaching Methodology','TeachingMethodology','Posts')

/* Japanese Studies */
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('JapaneseStudies','JapaneseStudies-1','Japanese Culuture','JCulture','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('JapaneseStudies','JapaneseStudies-2','Japanese Literature','JLiterature','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('JapaneseStudies','JapaneseStudies-3','Japanese History','JHistory','Posts')
Insert Into CommonCode(CommonTypeId,CommonId,StrValue1,StrValue2,StrValue3) Values('JapaneseStudies','JapaneseStudies-4','Japanese Linguistic','JLinguistic','Posts')