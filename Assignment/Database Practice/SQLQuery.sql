INSERT INTO Category (CategoryName) VALUES ('Stationery')
INSERT INTO Category (CategoryName) VALUES ('Computer')


INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Pen',10,15,'Good pen for exam')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Pencil',100,5,'Good pencil for drawing')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Notebook',50,25,'Notebook for primary students')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Fullscape',200,15,'Fullscape for higer secondary students')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Eraser',1000,1.50,'Eraser for KG Students')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (2,'Mouse',20,200,'USB 2.0 Mouse')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (2,'Keyboard',20,250,'USB 3.0 Keyboard')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (2,'USB Stick',1000,450,'4 GB Pendrives')


-- 1.Get all columns and all rows from ‘Product’ table--
Select * FROM Product

-- 2.Get Column with their respective values from the table.
Select ProductName,Price,Description from Product

-- 3.Get all columns from ‘Product’ table with where clause.
Select * from Product where ProductName='Pen'

-- 4.Get all columns from ‘Product’ table using Between Operator.
Select * from Product where ProductId Between 2 and 6

-- 5.Get all rows from ‘Product’ table where ProductName is Mouse,Keyboard,USB Stick
Select * from Product where ProductName in ('Mouse','Keyboard','USB Stick')

-- 6.Get all rows from ‘Product’ table where the name starts with ‘K’ letter.
Select * From Product where ProductName like 'u%'

-- 7.Get all rows from ‘Product’ table where the name ends with ‘K’ letter.
Select * from Product where ProductName like '%k'

-- 8.Get all rows from ‘Product’ table where the name starts with ‘E/F’ letter.
select * from Product where Description like '[gn]%'

-- 9.Get all rows from ‘Product’ table where the name not starts with ‘E/F’ letter.
select * from product where ProductName like '[^pn]%'

-- 10.Get single column with a combination of Product and Qty added together with a space from Product’ table.
select (ProductName +SPACE(2)+CONVERT(varchar,Price)) as product_and_price   from Product

-- 11.Get all rows from ‘Product’ table where ProductName column is not containing null values
select * from product where Description IS NOT NUll 

-- 12.Get all rows from ‘Product’ table in descending order of ProductId
select * from product  order by ProductId  desc

-- 13.Get all rows from ‘Product’ table in ascending order of Price
select * from product  order by price asc

-- 14. Get Unique row from ‘Product’ table based on CategoryId
select distinct CategoryId from Product

-- 15. Get top 5 Rows from ‘Product’ table
select top 5 * from Product

-- 16.Get maximum Price Of Price from ‘Product’ table
select MAX(Price)  from Product 

-- 17.Get maximum value Of Qty from ‘Product’ table
select MAX(qty) from Product

-- 18.Get even row from table 'Product'
select temp. * from (select row_number() over (order by ProductID) As row_number,Product.* from Product)temp
where((temp.row_number)%2) = 0

-- 19.Get odd row from table 'Product'
select temp. * from (select row_number() over (order by ProductID) As row_number,Product.* from Product)temp
where((temp.row_number)%2) = 1

-- 20.Count number of records in a 'Product' table
select count(*) As Record_Count from Product

-- 21.List all the categories with products (Inner Join)
select * from Category inner join Product on Category.CategoryId=Product.CategoryId

-- 22.List all rows from category, even if there are no matches in the product table (Left Join)
select * from category left join Product on Category.CategoryId=Product.CategoryId

-- 23.List all the rows from product, even if there are no matches in the category table (Right Join)
select * from Category right join Product on Category.CategoryId=Product.CategoryId 

-- 24.List all the rows from the category table and all the rows from the product table (Full Join)
select * from Category full join Product on Category.CategoryId=Product.CategoryId 

-- 25. Get average value of price from product table
select AVG (price) As Averag_Price from Product

-- 26. Get number of products from product table
SELECT COUNT(ProductName) AS NoOfProducts FROM Product

--27. Get minimum price of product from product table
SELECT MIN(Price) AS MinimumPrice FROM Product

--28. Get Maximum price of product from product table
SELECT MAX(Price) AS MaximumPrice FROM Product

--29. Get total number of qty of products from product table
SELECT SUM(Qty) AS TotalProducts FROM Product

--30. Get all product name is in upper case from product table
SELECT UPPER(ProductName) AS PRODUCTS FROM Product

--31. Get all product name is in lower case from product table
SELECT LOWER(ProductName) AS products FROM Product