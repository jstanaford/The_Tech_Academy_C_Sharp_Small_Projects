USE AdventureWorks2014
GO
CREATE PROCEDURE dbo.uspGetAddress1 @City nvarchar(30) = NULL, @AddressLine1 nvarchar(60) = NULL
AS 
SELECT *
FROM Person.Address
RIGHT JOIN Person.AddressType
ON Person.Address.AddressID = Person.AddressType.AddressTypeID
INNER JOIN Person.StateProvince
ON Person.Address.StateProvinceID = Person.StateProvince.StateProvinceID
WHERE City = ISNULL(@City,City)
AND AddressLine1 LIKE '%' + ISNULL(@AddressLine1 ,AddressLine1) + '%'
GO

EXEC dbo.uspGetAddress1 @AddressLine1 = '%'

