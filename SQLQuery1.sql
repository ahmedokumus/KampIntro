--select * from Customers
--select ContactName, CompanyName, City from Customers
--select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers
--select * from Customers where City = 'London' --customer içinde şehri london olanları getir
--select * from Products where CategoryId=1
--select * from Products where CategoryID=1 or CategoryID=3
--select * from Products where CategoryID=1 and UnitPrice>=10
--select * from Products order by ProductName
--select * from Products order by UnitPrice asc --ascending(artan sıralama)
--select * from Products order by UnitPrice desc --descending(düşen sıralama)
--select * from Products where CategoryID=1 order by UnitPrice desc
--select count(*) from Products
--select count(*) Adet from Products where CategoryID=2
--select CategoryID, count(*) Adet from Products group by CategoryID
--select CategoryID, count(*) Adet from Products group by CategoryID having count(*)<10
--select CategoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

--select Products.ProductID, Products.ProductName, Categories.CategoryName, Products.UnitPrice
--from Products inner join Categories
--on Products.CategoryID = Categories.CategoryID

--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
--from Products inner join Categories --sadece iki tabloda da eşleşen dataları getirir
--on Products.CategoryID = Categories.CategoryID
--where Products.UnitPrice>50

--select * 
--from Products p left join [Order Details] od --sol da olup sağ da olmayanları getir
--on p.ProductID = od.ProductID
--*** 27-29 satırlarında ki kodlar ile 31-33 satırlarında ki kodlar aynı sonucu getirir. ***--
--select * 
--from [Order Details] od right join Products p --sağ da olup sol da olmayanları getir
--on p.ProductID = od.ProductID

--select * 
--from Customers c left join Orders o --sol da olup sağda olmayanları getir
--on c.CustomerID = o.CustomerID

--select *
--from Customers c left join Orders o
--on c.CustomerID = o.CustomerID
--where o.CustomerID is null

--select * 
--from Products p inner join [Order Details] od --sol da olup sağda olmayanları getir
--on p.ProductID = od.ProductID
--inner join Orders o
--on o.OrderID = od.OrderID

--DTO(Data Transformation object) --joinli yapılar
