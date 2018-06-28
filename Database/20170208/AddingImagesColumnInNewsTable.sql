
USE LSDB
GO

ALTER TABLE [dbo].[News] ADD Images varchar(255)
GO

UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 1';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 2';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 3';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 4';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 5';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 6';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 7';
UPDATE News SET Images='tsan_chu_trung_00.png' WHERE Title=N'Category Archives: Ngữ Pháp 8';