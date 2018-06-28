/*
   Tuesday, 7 Fer 2017 4:00:00 PM
   User: 
   Server: localhost
   Database: LSDB
   Application: 

*/

USE LSDB
GO

DELETE FROM News
DBCC CHECKIDENT ('News',RESEED, 0)

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status])
VALUES ('2017-01-01 00:00:00.000', 'Japan Culture', N' Quan Niệm Chữ Trung Phần 1 ', N'Nội dung mô tả ngắn A', N'Nội dung chi tiết A', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status])
VALUES ('2017-01-01 00:00:00.000', 'Japan Culture', N' Quan Niệm Chữ Trung Phần 2', N'Nội dung mô tả ngắn B', N'Nội dung chi tiết B', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status])
VALUES ('2017-01-01 00:00:00.000', 'Japan Culture', N' Quan Niệm Chữ Trung Phần 3 ', N'Nội dung mô tả ngắn C', N'Nội dung chi tiết C', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status])
VALUES ('2017-01-01 00:00:00.000', 'Japan Culture', N' Quan Niệm Chữ Trung Phần 4 ', N'Nội dung mô tả ngắn D', N'Nội dung chi tiết D', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT')

INSERT INTO News ([Time], CategoryId, Title, NewsBrief, NewsDetail, CreatedBy, Editor, Links, Keyword, [Description], [Status])
VALUES ('2017-01-01 00:00:00.000', 'Japan Culture', N' Quan Niệm Chữ Trung Phần 5 ', N'Nội dung mô tả ngắn E', N'Nội dung chi tiết E', 'admin', N'Dr Thanh Diệu', 'Workpress', 'Culture', 'Descrption' ,'ACT')