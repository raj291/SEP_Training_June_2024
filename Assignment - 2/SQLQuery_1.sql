--q1
SELECT COUNT(NAME) AS [LIST OF PRODUCTS] FROM Production.Product;
--Q2
SELECT Count(Name) AS Count FROM  Production.Product WHERE ProductSubcategoryID IS NOT NULL;
--q3
SELECT ProductSubcategoryID , COUNT(name) AS CountedProducts
FROM Production.Product WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID; 
--q4
SELECT COUNT(ProductID)
From Production.Product WHERE ProductSubcategoryID IS NULL;
--q5
SELECT i.ProductID , SUM(i.Quantity) AS [Quantity Count]
FROM Production.Product p JOIN Production.ProductInventory i ON p.ProductID = i.ProductID
GROUP BY i.ProductID;

SELECT ProductId , SUM(Quantity) AS TheSum
FROM Production.ProductInventory
GROUP BY ProductID;

--q6
SELECT ProductID , SUM(Quantity) As TheSum
FROM Production.ProductInventory WHERE LocationID = 40 
GROUP BY ProductID HAVING SUM(Quantity) < 100;

SELECT dt.ProductID , TheSum  FROM(
    SELECT i.ProductID , SUM(i.Quantity) AS TheSum
    FROM Production.Product p JOIN Production.ProductInventory i ON p.ProductID = i.ProductID
    WHERE i.LocationID = 40 
    GROUP BY i.ProductID ) dt 
WHERE TheSum < 100
ORDER BY TheSum;

--q7
SELECT dt.ProductID , TheSum  FROM(
    SELECT i.ProductID , SUM(i.Quantity) AS TheSum
    FROM Production.Product p JOIN Production.ProductInventory i ON p.ProductID = i.ProductID
    WHERE i.LocationID = 40 
    GROUP BY i.ProductID ) dt 
WHERE TheSum < 100
ORDER BY TheSum;

SELECT ProductID , SUM(Quantity) As TheSum, Shelf
FROM Production.ProductInventory WHERE LocationID = 40 
GROUP BY ProductID , Shelf HAVING SUM(Quantity) < 100;
--q8
SELECT AVG(Quantity) AS Average, LocationID  
FROM Production.ProductInventory WHERE LocationID = 10
GROUP BY LocationID;
--q9
SELECT ProductID, Shelf , AVG(Quantity) as TheAvg
FROM Production.ProductInventory 
GROUP BY ProductID, Shelf;
--q10
SELECT ProductID, Shelf , AVG(Quantity) as TheAvg
FROM Production.ProductInventory 
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf;
--q11
SELECT Color , Class , COUNT(ProductID) AS TheCount , AVG(ListPrice) AS AvgPrice
FROM Production.Product 
WHERE color IS NOT NULL AND class IS NOT NULL
GROUP BY Color , class;
--q12
SELECT pc.name AS Country , ps.name AS Province
FROM Person.StateProvince ps JOIN Person. CountryRegion pc ON ps.CountryRegionCode = pc.CountryRegionCode
ORDER BY pc.name;
--q13
SELECT pc.name AS Country , ps.name AS Province
FROM Person.StateProvince ps JOIN Person. CountryRegion pc ON ps.CountryRegionCode = pc.CountryRegionCode
WHERE pc.name IN ('Germany', 'Canada')
ORDER BY pc.name;
--q14
SELECT DISTINCT od.ProductID , p.ProductName , o.OrderDate
FROM Orders o JOIN [Order Details] od on o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
WHERE o.OrderDate >= '1997-01-01'
ORDER BY o.OrderDate desc
--q15
SELECT  TOP(5)o.ShipPostalCode , od.Quantity
FROM Orders o JOIN [Order Details] od on o.OrderID = od.OrderID
ORDER BY od.Quantity Desc
--q16
SELECT  TOP(5)o.ShipPostalCode , od.Quantity
FROM Orders o JOIN [Order Details] od on o.OrderID = od.OrderID
WHERE o.OrderDate >= '1997-01-01'
ORDER BY od.Quantity Desc
--q17
SELECT ShipCity , COUNT(CustomerID) AS [No.Customers]
FROM Orders 
GROUP BY ShipCity
--q18
SELECT ShipCity , COUNT(CustomerID) AS [No.Customers]
FROM Orders
GROUP BY ShipCity
HAVING COUNT(CustomerID) > 2
ORDER BY [No.Customers]
--q19
SELECT c.CompanyName
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate >= '1998-01-01'
--q20
SELECT c.CompanyName , o.OrderDate
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
ORDER BY o.OrderDate DESC
--q21
SELECT c.CompanyName , o.OrderId , SUM(od.Quantity) AS [No.Products]
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName , o.OrderID
--q22
SELECT c.CompanyName , o.OrderId , SUM(od.Quantity) AS [No.Products]
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName , o.OrderID
HAVING SUM(od.Quantity) > 100
--q23
SELECT s.CompanyName AS [Supplier Company Name] ,sh.CompanyName AS [Shipping Company Name] 
FROM Shippers sh JOIN Orders o ON sh.ShipperID = o.ShipVia 
JOIN [Order Details] od ON o.OrderID = od.OrderID 
JOIN Products p ON od.ProductID = p.ProductID 
JOIN Suppliers s ON p.SupplierID = s.SupplierID
--q24
SELECT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate, p.ProductName;
--q25
SELECT e.FirstName + ' ' + e.LastName AS E1 , em.FirstName + ' ' + em.LastName AS E2
FROM Employees e JOIN Employees em ON e.Title = em.Title 
WHERE e.EmployeeID <> em.EmployeeID
--q26
SELECT e.FirstName + ' ' + e.LastName AS FullName 
FROM Employees e WHERE e.EmployeeID IN
 (
  SELECT ReportsTo
  FROM Employees
  GROUP BY ReportsTo
  HAVING COUNT(*) > 2
);
--q27
SELECT 
    c.City, 
    c.CompanyName AS Name, 
    c.ContactName, 
    'Customer' AS Type
FROM Customers c
UNION 
SELECT 
    s.City, 
    s.CompanyName, 
    s.ContactName, 
    'Supplier' AS Type
FROM Suppliers s

ORDER BY City, Type, Name;