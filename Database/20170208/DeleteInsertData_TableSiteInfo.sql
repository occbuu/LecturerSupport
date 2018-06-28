Delete SiteInfo
where Id>=1 and Id<=15
GO

/*Add Column ParentID in table SiteInfo*/
Alter table SiteInfo
Add ParentId varchar(5)
GO

/*Insert Data in Table SiteInfo*/
insert into [dbo].[SiteInfo](lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<a href="/Home" class="accent-color" style="font-weight:500; font-size:23px">DR. <span style="color:#555; font-weight:500">Tran Thi Thanh Dieu</span></a>','Name',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<a class="active" href="/" style="padding-top: 28px; padding-bottom: 28px;">Home</a>','Home',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<a href="javascript:void(0);" style="padding-top: 28px; padding-bottom: 28px;">Introduction</a>','Introduction',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<a href="javascript:void(0);">Announcement</a>','Announcement',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<a href="javascript:void(0);">English</a>','English',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<a href="javascript:void(0);">Japanese Studies</a>','JapanStudies',null,null,1,null,1,null,null,null,null,null,null)

/* INTRODUCTION */

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/About">About Me</a></li>','AboutMe',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Teaching">Teaching</a></li>','Teaching',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Studies">Studies</a></li>','Studies',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/ResearchWorks">Research Work</a></li>','ResearchWork',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/MyClass">My Class</a></li>','MyClass',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/DelegateStudents">Delegate Students</a></li>','DelegateStudents',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Gallery">Memory And Gallery</a></li>','MemoryAndGallery',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Schedule">Schedule</a></li>','Schedule',null,null,1,null,1,null,null,null,null,null,'18')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Contact">Contact</a></li>','Contact',null,null,1,null,1,null,null,null,null,null,'18')

/* Announcement */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/Survey">Survey</a></li>','Survey',null,null,1,null,1,null,null,null,null,null,'19')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/Annoucement">Annoucement</a></li>','Annoucement',null,null,1,null,1,null,null,null,null,null,'19')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="javascript:void(0);">Open Post</a><ul class="dropdown-submenu"><li><a href="/Library/EnglishLinguistic"> English Linguistic</a></li><li><a href="/Library/JStudies"> Japan Studies</a></li></ul></li>','OpenPost',null,null,1,null,1,null,null,null,null,null,'19')

/* English */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li>
                        <a href="javascript:void(0);">English Linguistic</a>
                        <ul class="dropdown-submenu">
                            <li><a href="/Posts/Phonology">Phonology</a></li>
                            <li><a href="/Posts/Morphology">Morphology</a></li>
                            <li><a href="/Posts/Syntax">Syntax</a></li>
                            <li><a href="/Posts/Semantic">Semantic</a></li>
                            <li><a href="/Posts/Pragmantic">Pragmatic</a></li>
                            <li><a href="/Posts/FunctionalGrammar">Functional Grammar</a></li>
                            <li><a href="/Posts/LiteratureLinguistic">Literature Linguistic</a></li>
                        </ul>
                    </li>','EnglishLinguistic',null,null,1,null,1,null,null,null,null,null,'20')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/Grammar">Grammar</a></li>','Grammar',null,null,1,null,1,null,null,null,null,null,'20')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/Translation">Translation</a></li>','Translation',null,null,1,null,1,null,null,null,null,null,'20')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/Skills">Skills</a></li>','Skills',null,null,1,null,1,null,null,null,null,null,'20')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/Comparation">Comparation</a></li>','Comparation',null,null,1,null,1,null,null,null,null,null,'20')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/TeachingMethodology">English Teaching Methodology</a></li>','TeachingMethodology',null,null,1,null,1,null,null,null,null,null,'20')

/* Japanese */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/JCulture">Japanese Culture</a></li>','JapaneseCulture',null,null,1,null,1,null,null,null,null,null,'21')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/JLiterature">Japanese Literature</a></li>','JapaneseLiterature',null,null,1,null,1,null,null,null,null,null,'21')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/JCulture">Japanese History</a></li>','JapanHistory',null,null,1,null,1,null,null,null,null,null,'21')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Header','Header','<li><a href="/Posts/JCulture">Japanese Linguistic</a></li>','JapaneseLinguistic',null,null,1,null,1,null,null,null,null,null,'21')

/* Top Bar */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','TopBar','TopBar','<li><a href="#"><i class="fa fa-map-marker"></i> Ho Chi Minh City, Vietnam, Asia</a></li>','Address',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','TopBar','TopBar','<li><a href="#"><i class="fa fa-envelope-o"></i> thanhdieutt@hcmussh.edu.vn </a></li>','Email',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','TopBar','TopBar','<li><a href="#"><i class="fa fa-phone"></i> (+84) 091-891-1737</a></li>','Phone',null,null,1,null,1,null,null,null,null,null,null)

/* Icon TopBar */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar','<li><a class="facebook itl-tooltip" data-placement="bottom" title="Facebook" href="https://www.facebook.com/dieu.tranthithanh.94"><i class="fa fa-facebook"></i></a></li>','FaceBook',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar','<li><a class="twitter itl-tooltip" data-placement="bottom" title="Twitter" href="#"><i class="fa fa-twitter"></i></a></li>','Twitter',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar','<li><a class="google itl-tooltip" data-placement="bottom" title="Google Plus" href="#"><i class="fa fa-google-plus"></i></a></li>','GooglePlus',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar','<li><a class="wordpress itl-tooltip" data-placement="bottom" title="Wordpress" href="https://tranthithanhdieu.wordpress.com/"><i class="fa fa-wordpress"></i></a></li>','Wordpress',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar','<li><a class="instgram itl-tooltip" data-placement="bottom" title="Instagram" href="#"><i class="fa fa-instagram"></i></a></li>','Instagram',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar','<li><a class="skype itl-tooltip" data-placement="bottom" title="Skype" href="#"><i class="fa fa-skype"></i></a></li>','Skype',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','IconTopBar','IconTopBar',N'<li><select class="itl-tooltip" onchange="setLang(this);" style="margin-top:5%"><option value="en-US" @(resx.Culture.Name == "en-US" ? "selected=\"selected\"" : "")>English</option><option value="vi-VN" @(resx.Culture.Name == "vi-VN" ? "selected =\"selected\"" : "")>Tiếng Việt</option><option value="ja-JP" @(resx.Culture.Name == "ja-JP" ? "selected=\"selected\"" : "")>日本語</option></select></li>','MultiLanguage',null,null,1,null,1,null,null,null,null,null,null)

/* Footer */

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<h4>Get In Touch<span class="head-line"></span></h4>','GetInTouch',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<h4>Social Network <span class="head-line"></span></h4>','SocialNetwork',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<h4>Images <span class="head-line"></span></h4>','FooterImages',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<h3 font-weight:500; padding-bottom:25px" class="accent-color">DR<span style="color:#eee; font-weight:500">. TranThiThanhDieu</span></h3>','FooterName',null,null,1,null,1,null,null,null,null,null,null)

/* sub GetInTouch */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<span>If you need documents, please leave your email address below</span>','IfYouNeed',null,null,1,null,1,null,null,null,null,null,'54')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<form class="subscribe"><input type="text" placeholder="mail@example.com"><input type="submit" class="btn-system" value="Send"><form>','Send',null,null,1,null,1,null,null,null,null,null,'54')

/* sub FooterName*/
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<li style="margin-top:22px"><span>Email Address :</span> www.thanhdieutt@hcmussh.edu.vn</li>','EmailAddress',null,null,1,null,1,null,null,null,null,null,'57')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<li><span>Website :</span>www.drthanhdieu.com</li>','Website',null,null,1,null,1,null,null,null,null,null,'57')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<li><span>Phone Number :</span> (+84) 091-891-1737 </li>','PhoneNumber',null,null,1,null,1,null,null,null,null,null,'57')

/* Policy and Term And Condition */

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<span> 2016 DR TranThiThanhDieu - AllRightsReserved</span>','CopyRight',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<li><a href="/Home/TermAndCondition" style="color:#ccc;">Terms & Conditions</a></li>','TermAndCondition',null,null,1,null,1,null,null,null,null,null,'63')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Footer','Footer','<li><a href="/Home/Policy" style="color:#ccc;">Privacy Policy</a></li>','PrivacyPolicy',null,null,1,null,1,null,null,null,null,null,'63')

/* More About */
insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<h1><strong>More About Lecturers</strong></h1>','MoreAboutLecturers',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<p class="title-desc">University of Social Sciences and Humanities</p>','University',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<li><i class="fa fa-check-circle"></i> BA of English – University of Pedagogy.</li>','BAPedagory',null,null,1,null,1,null,null,null,null,null,'66')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<li><i class="fa fa-check-circle"></i> BA of Oriental Studies – The Studies of Japan – University of Social Sciences and Humanitiest.</li>','BASSaH',null,null,1,null,1,null,null,null,null,null,'66')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<li><i class="fa fa-check-circle"></i> MA of TESOL – Victoria University – Australia.</li>','MAVictoria',null,null,1,null,1,null,null,null,null,null,'66')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<li><i class="fa fa-check-circle"></i> PhD of English Language and Literature – Atlantic International University – USA.</li>','PhDAtlantic',null,null,1,null,1,null,null,null,null,null,'66')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','<li><i class="fa fa-check-circle"></i> PhD of Comparative Linguistics – University of Social Sciences and Humanities Department of English Linguistics.</li>','PhDSSaHD',null,null,1,null,1,null,null,null,null,null,'66')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','Content','Content','teacher.png','ImagesOfTeacher',null,null,1,null,1,null,null,null,null,null,null)

/* Images My Class */

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','<h1><strong>This is My Classes</strong></h1>','ThisisMyClasses',null,null,1,null,1,null,null,null,null,null,null)

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','class1.jpg','ImagesOfClass1',null,null,1,null,1,null,null,null,null,null,'74')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','class-8.png','ImagesOfClass8',null,null,1,null,1,null,null,null,null,null,'74')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','class-22.jpg','ImagesOfClass22',null,null,1,null,1,null,null,null,null,null,'74')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','class-31.jpg','ImagesOfClass31',null,null,1,null,1,null,null,null,null,null,'74')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','class-42.jpg','ImagesOfClass42',null,null,1,null,1,null,null,null,null,null,'74')

insert into SiteInfo(lang,brief,type,Value,Name,URL1,URL2,Status,CanDelete,qty,Sequence,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ParentId)
Values('eng','ImageClass','ImageClass','class-62.jpg','ImagesOfClass62',null,null,1,null,1,null,null,null,null,null,'74')
