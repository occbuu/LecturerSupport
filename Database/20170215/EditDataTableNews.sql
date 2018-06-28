/*
   Tuesday, 15 Fer 2017 4:50:00 PM
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
VALUES ('2017-01-01 01:30:30.000', 'JStudies', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JStudies', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JStudies', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JStudies', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status], Images)
VALUES ('2017-01-01 01:30:30.000', 'JStudies', N'Japan Linguistic Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT', N'tsan_chu_trung_00.png')