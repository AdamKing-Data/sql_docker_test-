CREATE PROCEDURE [dbo].[usp_add_person_address]
	@personid int,
	@line1 NVARCHAR(50),
	@line2 NVARCHAR(50),
	@line3 NVARCHAR(50),
	@city NVARCHAR(50),
	@postcode NVARCHAR(10)
AS
	INSERT INTO docker.Address(personid, Line1 ,
	Line2,
	Line3,
	City,
	Postcode)
	VALUES(@personid ,
	@line1,
	@line2,
	@line3,
	@city,
	@postcode)
RETURN 0
