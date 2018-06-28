﻿ALTER TABLE SiteInfo ALTER COLUMN [ParentId] VARCHAR(20)
Go
Delete from [dbo].[SiteInfo]
DBCC CHECKIDENT ('SiteInfo',RESEED, 0)
Go
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a href="#"><i class="fa fa-map-marker"></i> Ho Chi Minh City, Vietnam, Asia</a></li>', N'Address', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a href="#"><i class="fa fa-envelope-o"></i> thanhdieutt@hcmussh.edu.vn </a></li>', N'Email', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a href="#"><i class="fa fa-phone"></i> (+84) 091-891-1737</a></li>', N'Phone', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a class="facebook itl-tooltip" data-placement="bottom" title="Facebook" href="https://www.facebook.com/dieu.tranthithanh.94"><i class="fa fa-facebook"></i></a></li>', N'FaceBook', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a class="twitter itl-tooltip" data-placement="bottom" title="Twitter" href="#"><i class="fa fa-twitter"></i></a></li>', N'Twitter', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a class="google itl-tooltip" data-placement="bottom" title="Google Plus" href="#"><i class="fa fa-google-plus"></i></a></li>', N'GooglePlus', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a class="wordpress itl-tooltip" data-placement="bottom" title="Wordpress" href="https://tranthithanhdieu.wordpress.com/"><i class="fa fa-wordpress"></i></a></li>', N'Wordpress', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a class="instgram itl-tooltip" data-placement="bottom" title="Instagram" href="#"><i class="fa fa-instagram"></i></a></li>', N'Instagram', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><a class="skype itl-tooltip" data-placement="bottom" title="Skype" href="#"><i class="fa fa-skype"></i></a></li>', N'Skype', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Top Bar', N'Top Bar', N'<li><select class="itl-tooltip" onchange="setLang(this);" style="margin-top:5%"><option value="en-US" @(resx.Culture.Name == "en-US" ? "selected=\"selected\"" : "")>English</option><option value="vi-VN" @(resx.Culture.Name == "vi-VN" ? "selected =\"selected\"" : "")>Tiếng Việt</option><option value="ja-JP" @(resx.Culture.Name == "ja-JP" ? "selected=\"selected\"" : "")>日本語</option></select></li>', N'MultiLanguage', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Phone')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<h4>Get In Touch<span class="head-line"></span></h4>', N'GetInTouch', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<h4>Social Network <span class="head-line"></span></h4>', N'SocialNetwork', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<h4>Images <span class="head-line"></span></h4>', N'FooterImages', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<h3 font-weight:500; padding-bottom:25px" class="accent-color">DR<span style="color:#eee; font-weight:500">. TranThiThanhDieu</span></h3>', N'FooterName', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<span>If you need documents, please leave your email address below</span>', N'IfYouNeed', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'GetInTouch')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<form class="subscribe"><input type="text" placeholder="mail@example.com"><input type="submit" class="btn-system" value="Send"><form>', N'Send', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'GetInTouch')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<li style="margin-top:22px"><span>Email Address :</span> www.thanhdieutt@hcmussh.edu.vn</li>', N'EmailAddress', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'FooterName')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<li><span>Website :</span>www.drthanhdieu.com</li>', N'Website', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'FooterName')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<li><span>Phone Number :</span> (+84) 091-891-1737 </li>', N'PhoneNumber', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'FooterName')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<span> 2016 DR TranThiThanhDieu - AllRightsReserved</span>', N'CopyRight', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<li><a href="/Home/TermAndCondition" style="color:#ccc;">Terms & Conditions</a></li>', N'TermAndCondition', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'CopyRight')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'<li><a href="/Home/Policy" style="color:#ccc;">Privacy Policy</a></li>', N'PrivacyPolicy', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'CopyRight')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Footer', N'Footer', N'class-2.jpg;class-3.jpg;class-4.jpg;class-5.jpg;class-6.jpg;class-7.jpg;class-8.jpg;class-9.jpg;class-2.jpg;', N'ImagesOfFooter', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'FooterImages')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<h1><strong>More About Lecturers</strong></h1>', N'MoreAboutLecturers', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<p class="title-desc">University of Social Sciences and Humanities</p>', N'University', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<li><i class="fa fa-check-circle"></i> BA of English – University of Pedagogy.</li>', N'BAPedagory', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'MoreAboutLecturers')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<li><i class="fa fa-check-circle"></i> BA of Oriental Studies – The Studies of Japan – University of Social Sciences and Humanitiest.</li>', N'BASSaH', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'MoreAboutLecturers')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<li><i class="fa fa-check-circle"></i> MA of TESOL – Victoria University – Australia.</li>', N'MAVictoria', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'MoreAboutLecturers')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<li><i class="fa fa-check-circle"></i> PhD of English Language and Literature – Atlantic International University – USA.</li>', N'PhDAtlantic', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'MoreAboutLecturers')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'<li><i class="fa fa-check-circle"></i> PhD of Comparative Linguistics – University of Social Sciences and Humanities Department of English Linguistics.</li>', N'PhDSSaHD', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'MoreAboutLecturers')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Content', N'Content', N'teacher.png', N'ImagesOfTeacher', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'<h1><strong>This is My Classes</strong></h1>', N'ThisisMyClasses', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class1.jpg;', N'ImagesOfClass1', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class-8.png;', N'ImagesOfClass8', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class-22.jpg;', N'ImagesOfClass22', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class-31.jpg;', N'ImagesOfClass31', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class-42.jpg;', N'ImagesOfClass42', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class-62.png;', N'ImagesOfClass62', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'class-8.jpg;', N'ImagesOfClass8jpg', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesClass')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Images Class', N'Images Class', N'<p class="text-center"><a href="#" class="btn-system btn-medium border-btn"><i class="icon-brush"></i>View Full Portfolio</a></p>', N'ViewFullPortfolio', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ThisisMyClasses')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Dashboard', N'Dashboard', N'<p class="title-desc" style="font-weight:600; font-style:italic">We Always Satisfy You</p>', N'WeAlwaysSatisfyYou', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Dashboard', N'Dashboard', N' <h2 style="font-weight:800; text-transform:uppercase"><i><span class="accent-color">Quality </span>Is More Important Than <span class="accent-color">Quantity</span></i></h2>', N'Quality', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Dashboard', N'Dashboard', N'<p>Diplomas</p><div class="progress"><div class="progress-bar" role="progressbar" data-percentage="60"><span class="progress-bar-span">5</span></div></div>', N'Diplomas', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'WeAlwaysSatisfyYou')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Dashboard', N'Dashboard', N'<p>Work Years</p><div class="progress"><div class="progress-bar" role="progressbar" data-percentage="80"><span class="progress-bar-span">> 20</span></div></div>', N'WorkYears', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'WeAlwaysSatisfyYou')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Dashboard', N'Dashboard', N'<p>Schools Taught</p><div class="progress"><div class="progress-bar" role="progressbar" data-percentage="90"><span class="progress-bar-span">> 3</span></div></div>', N'SchoolsTaught', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'WeAlwaysSatisfyYou')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Dashboard', N'Dashboard', N'<p>Students</p><div class="progress"><div class="progress-bar" role="progressbar" data-percentage="100"><span class="progress-bar-span">> 500</span></div></div>', N'Students', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'WeAlwaysSatisfyYou')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'ISlide Show', N'Slide Show', N'a.jpg;', N'ImagesOfSlideShowA', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Slide Show', N'Slide Show', N'class-7.png;', N'ImagesOfSlideShowClass7', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Slide Show', N'Slide Show', N'bg2.jpg;', N'ImagesOfSlideShowBg2', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Slide Show', N'Slide Show', N'bg3.jpg;', N'ImagesOfSlideShowBg3', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Slide Show', N'Slide Show', N'<h2 class="animated2"><span style="color:white">HELLO I''m</span></h2>', N'HelloIm', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ISlideShow')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Slide Show', N'Slide Show', N'<h3 class="animated3"><span style="color:#ee3733; font-weight:500">DR. TRAN THI THANH DIEU</span></h3>', N'NameInSlideShow', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ISlideShow')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Slide Show', N'Slide Show', N'<p class="animated4">Welcome</p>', N'Welcome', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ISlideShow')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'phuongngoc.jpg;', N'ImagesOfPN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'phuongthao.jpg;', N'ImagesOfPth', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'phuonglan.jpg;', N'ImagesOfPL', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'vuminhnga.jpg;', N'ImagesOfVMN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Vu Minh Nga', N'NameOfVMN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfVMN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'BA – AP', N'DegreeOfVMN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfVMN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Some differences between English and Vietnamese compound noun', N'TopicOfVMN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfVMN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'University', N'SupervisionOfVMN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfVMN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'2010', N'YearOfVMN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfVMN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Phan Thi Phuong Ngoc', N'NameOfPN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'BA – AP', N'DegreeOfPN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Is it true that politeness and indirectness are closely related to each other?', N'TopicOfPN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'University', N'SupervisionOfPN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'2008', N'YearOfPN', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPN')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Nguyen Phuong Thao', N'NameOfPTh', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPth')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'BA – AP', N'DegreeOfPTh', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPth')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'A small-scale research on English and Vietnamese sentence classification based on their structure', N'TopicOfPTh', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPth')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'University', N'SupervisionOfPTh', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPth')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'2009', N'YearOfPTh', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPth')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Nguyen Phuong Lan ', N'NameOfPL', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPL')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'BA – AP', N'DegreeOfPL', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPL')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'Some differences between English and Vietnamese compound noun', N'TopicOfPL', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPL')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'University', N'SupervisionOfPL', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPL')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Delegate Student', N'Delegate Student', N'2007', N'YearOfPL', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'ImagesOfPL')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Comment', N'Comment', N'<h4 class="classic-title"><span>Comments</span></h4>', N'Comment', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Comment', N'Comment', N'<div class="testimonial-content"><p>She taught receptive.</p></div><div class="testimonial-author"><span>Vu Minh Nga</span> - Student</div>', N'CommentContent1', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Comment')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Comment', N'Comment', N' <div class="testimonial-content"><p>After learn with her, My knowledge was improved.</p></div><div class="testimonial-author"><span>Phan Thi Phuong Ngoc</span> - Student</div>', N'CommentContent2', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Comment')
INSERT [dbo].[SiteInfo] ([lang], [brief], [type], [Value], [Name], [URL1], [URL2], [Status], [CanDelete], [qty], [Sequence], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [ParentId]) VALUES (N'eng', N'Comment', N'Comment', N'<div class="testimonial-content"><p>After 3 months, My English Communication skill better than.</p></div><div class="testimonial-author"><span>Nguyen Phuong Thao</span> - Student</div>', N'CommentContent3', NULL, NULL, N'1', NULL, 1, NULL, NULL, NULL, NULL, NULL, N'Comment')
