USE DB
GO

SELECT П.ИМЯ + '-' + К.ИМЯ
FROM продукты П
INNER JOIN категории К ON К.ID = П.ID