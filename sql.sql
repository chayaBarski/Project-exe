alter PROCEDURE getAllProductItType
AS
BEGIN
create table #ProductTypesName ([ProductTypeName] nchar(10) not null)
create table #ProductTypes ([ProductTypeName] nchar(10) not null, CountProductTypeName int not null)
select reverse(substring(reverse([QuantityPerUnit]),1,charindex(' ',reverse([QuantityPerUnit])))) as ProductTypeName
into #ProductTypesNames from Products


select ProductTypeName,count(ProductTypeName) as CountProductTypeName
into #ProductType
from #ProductTypesNames
group by ProductTypeName
select * from #ProductType

END
GO
exec getAllProductItType
-----
alter PROCEDURE getAllProductItTypeCount
AS
BEGIN
create table #ProductTypesName ([ProductTypeName] nchar(10) not null,CountProductTypeName int not null)
create table #ProductTypes ([ProductTypeName] nchar(10) not null, CountProductTypeName int not null)
select LEFT([QuantityPerUnit],2) as CountProductTypeName, reverse(substring(reverse([QuantityPerUnit]),1,charindex(' ',reverse([QuantityPerUnit])))) as ProductTypeName

into #ProductTypesNames from Products

select ProductTypeName,sum(CAST(CountProductTypeName AS int)) as CountProductTypeName
into #ProductType
from #ProductTypesNames
group by ProductTypeName
select * from #ProductType

END
GO
exec getAllProductItTypeCount
-----------------------------------
update [dbo].[Products]
set QuantityPerUnit='1 pkg' 
where ProductID=45
select * from Products
