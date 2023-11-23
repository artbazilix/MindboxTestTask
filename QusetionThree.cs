﻿/* 

Предположим, что есть две таблицы: Products и Categories 
и они связаны через таблицу ProductCategories, 
т.к по условиям задачи в одной категории может быть много продуктов

SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN Categories ON ProductCategories.CategoryID = Categories.CategoryID;



Если таблицы связаны напрямую:

SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN Categories ON Products.CategoryID = Categories.CategoryID;

*/
