USE Northwind
Go
/* 1 */
/*Select ca.CategoryID, pr.ProductID, pr.ProductName from Categories ca 
inner join Products pr on ca.CategoryID = pr.CategoryID 
WHERE ca.CategoryID >= 2 and ca.CategoryID <=4 
order by ca.CategoryID, pr.ProductID */

/* 2 */
/*select pr.CategoryID,pr.ProductID, pr.ProductName from Products pr 
WHERE pr.CategoryID = 1 or pr.CategoryID = 4 or pr.CategoryID = 5 
or pr.CategoryID = 7 
order by pr.CategoryID, pr.ProductID*/

/* 3 */
/*select categoryid, productid, productname from Products where ProductName like 'ch%'
order by CategoryID, ProductID*/

/* 4 */
/*select companyname, city, Region, country from Customers where Region is not null/*