
DECLARE @TempData TABLE( Id int IDENTITY(1,1) NOT NULL, 
						 Manufacturer  varchar(100) NULL,
						 Backing  varchar(100) NULL,
						 Suitability  varchar(100) NULL,
						 Range  varchar(100) NULL,
						 Colour  varchar(100) NULL,
						 Price  money NULL,
						 Style  varchar(100) NULL,
						 Material  varchar(100) NULL,
					     FourMetre bit,
						 FiveMetre bit);

INSERT INTO @TempData
SELECT  Manufacturer,
		Backing,
		Suitability,
		Range,
		Colour,
		Price,
		Style,
		Material,
		CASE [4metre]
			WHEN 'Y' THEN 1
			ELSE 0
		END,
		CASE [5metre]
			WHEN 'Y' THEN 1
			ELSE 0
		END 
FROM   OPENROWSET('Microsoft.ACE.OLEDB.12.0',
       'Excel 12.0 Xml;HDR=YES;Database=C:\Users\dackers\Downloads\Carpet Test Data.xlsx',
       'SELECT * FROM [Sheet1$]')



 /*** Insert Ranges ***/
 --INSERT INTO Ranges
 --select distinct Range from @TempData where Range is not null


 /** Insert Manufacturers **/
 --INSERT INTO Manufacturers
 --select distinct Manufacturer from @TempData where Manufacturer is not null

 /** Insert Colours **/
 --INSERT INTO Lookups
 --select distinct '6', Colour from @TempData where Colour is not null

 /** Insert Materials **/
 --INSERT INTO Lookups
 --select distinct '7', Material from @TempData where Material is not null

 /** Insert Style **/
 --INSERT INTO Lookups
 --select distinct '8', Style from @TempData where Style is not null


/** Insert Products **/
--INSERT INTO Products(TypeId, RangeId, ManufacturerId, ColourId, MaterialId, StyleId, Price)	   
--	SELECT 2, 
--	       r.Id, 
--		   m.Id, 
--		   c.Id, 
--		   ma.Id, 
--		   s.Id, 
--		   td.Price
--	FROM @TempData TD
--	INNER JOIN Ranges R ON R.Description = TD.Range
--	INNER JOIN Manufacturers m on m.Name = TD.Manufacturer
--	INNER JOIN Lookups c on c.LookupId = 6 AND c.Description = td.Colour
--	INNER JOIN Lookups ma on ma.LookupId = 7 and ma.Description = td.Material
--	INNER JOIN Lookups s on s.LookupId = 8 and s.Description = td.Style

/** Add Widths **/
--INSERT INTO Widths
--SELECT p.Id, 21 FROM @TempData td
--INNER JOIN Products p on td.Id = p.Id
--WHERE TD.FourMetre = 1
--UNION ALL
--SELECT p.Id, 22 FROM @TempData td
--INNER JOIN Products p on td.Id = p.Id
--WHERE TD. FiveMetre = 1

