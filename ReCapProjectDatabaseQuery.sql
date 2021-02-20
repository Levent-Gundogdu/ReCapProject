
Create Table CARS
(
	CarId int Primary Key identity (1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	CarDescription nvarchar,  --varchar = string variable
)

Create Table BRAND
(
	BrandId int Primary Key Identity (1,1),
	BrandName nvarchar, --nvarchar [ ( n | max ) ] Variable-size string data. n defines the string size in byte-pairs and can be a value from 1 through 4,000.
)

Create Table COLORS
(
	ColorId int Primary Key Identity (1,1),
	ColorName nvarchar,
)

Insert Into Cars(BrandId, ColorId, ModelYear, DailyPrice, CarDescription)
Values
	(324, 1, 2001, 500, 'C180 Sedan'),
	(543, 1, 1998, 379, 'A10 Sedan'),
	(753, 2, 2010, 246, 'IX3 HatchBag'),
	(12, 2, 1999, 645, 'C3 Sedan'),
	(244, 6, 2018, 657.5, 'Regenade Sport');


Insert Into Brands(BrandName)
Values
	('Mercedes Benz'),
	('Renault'),
	('BMW'),
	('Citroen'),
	('Jeep');

Insert Into Colors(ColorName)
Values
	('White'),
	('White'),
	('Red'),
	('Red'),
	('Navy Blue');

	Select * From Cars; 
	Select * From Brands;
	Select * From Colors;