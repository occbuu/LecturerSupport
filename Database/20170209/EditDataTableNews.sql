/*
   Thursday, 9 Fer 2017 12:00:00 PM
   User: 
   Server: localhost
   Database: LSDB
   Application: 

*/

USE LSDB
GO

DELETE FROM News
DBCC CHECKIDENT ('News',RESEED, 0)

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn B', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-04 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn D', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-05 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 5 ', N'Nội dung mô tả ngắn E', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 6 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn G', N'Nội dung chi tiết G', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 02:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-02 01:35:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-05-01 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 01:30:30.000', 'JCulture', N'Japan Culture Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 03:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 10 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-07 01:35:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 02:30:30.000', 'JCulture', N' Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

/*Japan Literature*/
 
INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn B', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-04 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn D', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-05 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 5 ', N'Nội dung mô tả ngắn E', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 6 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn G', N'Nội dung chi tiết G', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 02:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-02 01:35:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-05-01 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 01:30:30.000', 'JLiterature', N'Japan Literature Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 03:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 10 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-07 01:35:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 02:30:30.000', 'JLiterature', N' Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

/*Japan History*/
 
INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn B', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-04 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn D', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-05 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 5 ', N'Nội dung mô tả ngắn E', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 6 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn G', N'Nội dung chi tiết G', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 02:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-02 01:35:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-05-01 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 01:30:30.000', 'JHistory', N'Japan History Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 03:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 10 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-07 01:35:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 02:30:30.000', 'JHistory', N' Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')


/*Japan Linguistic*/
 
INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn B', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-04 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn D', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-05 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 5 ', N'Nội dung mô tả ngắn E', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 6 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn F', N'Nội dung chi tiết F', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn G', N'Nội dung chi tiết G', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-01 02:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 2 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-02-02 01:35:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-05-01 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 01:30:30.000', 'JLinguistic', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-03 01:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-04-01 03:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 10 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-07 01:35:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-02 02:30:30.000', 'JLinguistic', N' Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')
