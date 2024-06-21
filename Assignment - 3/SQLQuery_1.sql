--q1
SELECT DISTINCT e.city
FROM Employees e JOIN Customers c ON e.City = c.City

--q2
--a.
SELECT DISTINCT c.City 
FROM Customers c WHERE c.City NOT IN (
    SELECT e.city 
    FROM Employees e 
)
--b.
SELECT DISTINCT c.city
FROM Customers c LEFT JOIN Employees e ON c.city = e.city
GROUP BY c.City
HAVING COUNT(e.city) = 0
--q3
SELECT DISTINCT  p.ProductName ,SUM(Quantity) AS [Total Order]
FROM [Order Details] od JOIN Products p ON od.ProductID = p.ProductID
GROUP BY  p.ProductName;
--q4
SELECT c.City , SUM(Quantity) AS [Total Products]
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderId
GROUP BY c.city
--q5
--a.
SELECT city , COUNT(CustomerID)
FROM (
    SELECT c.City , c.CustomerID 
    FROM Customers c 
    UNION
    SELECT cu.city , cu.CustomerID
    FROM Customers cu

) AS Cust
GROUP BY City
HAVING COUNT(CustomerID) >=2
--b.
SELECT City , COUNT(CustomerID)
FROM Customers
WHERE City IN (
    SELECT City
    FROM Customers
    GROUP BY City
    HAVING COUNT(CustomerID) >= 2
)
GROUP BY city
--q6
SELECT c.City
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;

--q7
SELECT DISTINCT c.CompanyName ,c.City
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity 
--q8
SELECT Top(5) p.ProductName , AVG(od.UnitPrice) AS [AVG Price], c.city , SUM(od.Quantity) AS TotalQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID 
JOIN Orders o ON od.OrderID = o.OrderID JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductName, c.City
ORDER BY TotalQuantity DESC 
--q9
SELECT  e.city , o.ShipCity
FROM Employees e LEFT JOIN Orders o ON e.city = o.ShipCity
WHERE o.OrderID IS NULL
--q10
SELECT TOP 1 o.ShipCity , COUNT(o.OrderID) as [Most Orders]
FROM Orders o JOIN Employees e ON e.EmployeeID = o.EmployeeID 
GROUP BY o.ShipCity
ORDER BY [Most Orders] DESC 

SELECT od.OrderID,  SUM(Quantity) AS [Total Quantity] FROM [Order Details] od 
GROUP BY od.OrderID
ORDER BY [Total Quantity] DESC

--q11
-- There are few ways which i think can solve the issue for Removing Duplicates Rows From the Table.
-- Use of Distinct Key words while using Select Clause to produce a Result SET for a Paticular Table 
-- Which contains Duplicates rows. However There can be Possibility if The is no Normalization Implemented 
-- in the Database. So Implementing First Normal Form and Second Normal Form can remove duplicate Records of a Table.
-- Which ensures that the data is organized and reduce any Redundancy With 1NF and 2NF.