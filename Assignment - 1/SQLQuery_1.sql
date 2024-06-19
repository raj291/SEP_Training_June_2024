--Q1
SELECT ProductID , Name, Color, ListPrice
FROM Production.Product;
--Q2
SELECT ProductID , Name, Color, ListPrice
FROM Production.Product WHERE ListPrice = 0;
--q3
SELECT ProductID , Name, Color, ListPrice
FROM Production.Product WHERE Color IS NULL;
--q4
SELECT ProductID , Name, Color, ListPrice
FROM Production.Product WHERE Color IS NOT NULL;
--Q5
SELECT ProductID , Name, Color, ListPrice
FROM Production.Product WHERE Color IS NOT NULL AND ListPrice > 0;
--Q6
SELECT Name + ' - ' + color AS Namecolor FROM Production.Product WHERE Color IS NOT NULL;
--Q7
SELECT 'NAME:' + Name + ' -- COLOR:' + color AS Namecolor 
FROM Production.Product WHERE color IS NOT NULL ORDER BY color;  
--q8
SELECT ProductID , name
FROM Production.Product WHERE ProductID BETWEEN 400 AND 500;
--q9
SELECT ProductID , name, color FROM Production.Product WHERE color = 'Black' OR color = 'blue';
--q10
SELECT ProductID , name , color FROM Production.Product WHERE name LIKE 'S%';
--q11
SELECT Name , ListPrice FROM Production.Product WHERE name LIKE 'S%' ORDER BY ListPrice ;
--q12
SELECT Name , ListPrice FROM Production.Product WHERE name LIKE 'A%' OR name LIKE'S%' ORDER BY name;
--q13
SELECT name , ListPrice FROM Production.Product WHERE name LIKE 'SPO%' AND name NOT LIKE 'SPOK%' ORDER BY name;
--Q14
SELECT DISTINCT color FROM Production.Product ORDER BY Color DESC;
--q15
SELECT DISTINCT ProductSubcategoryID, color
FROM Production.Product WHERE color IS NOT NULL AND ProductSubcategoryID IS NOT NULL;

