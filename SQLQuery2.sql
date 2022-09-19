--Select
--ANSII
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive
Select * from Products where CategoryId=1 or CategoryID=3

Select * from Products where CategoryId=1 and UnitPrice>10

Select * from Products Where CategoryID=1 order by UnitPrice desc --ascending --descending

select count(*) Adet from Products where CategoryId=2

select CategoryID,count(*) Adet from products group by CategoryID

select CategoryId,count(*) Adet from products 
group by CategoryID having count(*)<10

select CategoryId,count(*) from products where UnitPrice>20
group by CategoryID having count(*)<10

select 
Products.ProductId, 
Products.ProductName UrunAdi, 
Products.UnitPrice Fiyat, 
Categories.CategoryName Kategori
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice<10

--DTO -> Data Transformation object

select * from Products p inner join [Order Details] od
on p.ProductID = od.Order ID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerId is null