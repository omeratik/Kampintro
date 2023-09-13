--Select calistirmak istenilen kod seçilir.* seçilecek kolonu temsil eder. * tüm kolonları seçer sadece yazılırsa.
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin' -- metinler ANSII standartında tek tırnakla yazılır

--case insensitive büyük küçük harf duyarsızlığı sELEct Select sElect
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

--order by sırala demektir  --asc defaulttur yazılmasa da sistem kabul eder ona göre sıralar.
select * from Products order by UnitPrice asc     --ascending ( en alttan artan)

select * from Products  where CategoryID=1 order by UnitPrice desc     --decending (en yüksekten azalan)

--count say demektir.
select count(*)	 from Products where CategoryID=2


--group by her bir grup elemanı için ayrıca hesap yapılmasını sağlar.
select CategoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10  --having


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories -- innerjoin yalnızca iki tabloda da eşleşenleri bir araya getirir eşleşmeyen data varsa onu getirmez.
on Products.CategoryID = Categories.CategoryID  --on şartında demektir. neye göre birleştireceğimizi on üzerinden yazarız
where Products.UnitPrice>10


--DTO Data Transformation Object
                                   --boşluk olursa iki ayrı veri olark algılar [] kullanılarak tablo olarak alır.
Select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o --left solda olup sağda olmayanları da getir.
on c.CustomerID=o.CustomerID
where o.CustomerID is null  --primary key e uygulanır





