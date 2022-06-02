INSERT INTO dsSinhVien VALUES
(1610098,'Nguyen Van Hai Dang','CTK40'),(1610099,'Nguyen Van A','CTK40'),
(1610001,'Nguyen Van B','CTK39'),(161092,'Nguyen Van D','CTK40'),
(1610091,'Nguyen Van E','CTK44'),(1620099,'Nguyen Van F','CTK43'),
(1640099,'Nguyen Van G','CTK40'),(1610199,'Nguyen Van H','CTK41'),
(1612099,'Nguyen Van I','CTK40'),(1610099,'Nguyen Van K','CTK43');

SELECT TOP (1000) [MSSV]
      ,[HoVaTen]
      ,[Lop]
  FROM [dsSinhVien]

DELETE TOP (30)
FROM [SinhVien].[dbo].[dsSinhVien]