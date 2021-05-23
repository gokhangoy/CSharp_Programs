select * from  Customers

select ContactName, CompanyName, City from Customers

select ContactName as Adi, CompanyName as Sirket_Adi, City as Sehir from Customers

select ContactName Adi, CompanyName Sirket_Adi, City Sehir from Customers

select * from Products where CategoryID=1 and UnitPrice<10

select * from Products order by ProductName

select * from Products order by ProductName desc

select * from Products where CategoryID=2 order by UnitPrice asc --default is asc

select * from Products where CategoryID=2 order by ProductName desc

select CategoryID from Products group by CategoryID

select CategoryID,count(*) Adet from Products group by CategoryID


select CategoryID,count(*) Adet from Products group by CategoryID having count(*) < 10


--DTO : Data Transformation Object
select Products.ProductID,  Products.CategoryID,Categories.CategoryName, Products.ProductName, Products.UnitPrice
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice > 10


select * 
from Products p left join [Order Details] od 
on p.ProductID = od.ProductID


--Bizden ürün almayan kişilerin bilgilerini (is null) kontrolü ile elde edebiliriz...
select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null


--İkiden fazla da tabloyuda  joinleyebiliriz.
select * 
from Products p left join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID=od.OrderID