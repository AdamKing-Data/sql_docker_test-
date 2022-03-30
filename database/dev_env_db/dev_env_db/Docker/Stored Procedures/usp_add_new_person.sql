CREATE PROCEDURE [docker].[usp_add_new_person]
	@firstname NVARCHAR(50),
	@lastname NVARCHAR(50),
	@dob DATE

AS
	INSERT INTO docker.person ([Firstname], Lastname, date_of_birth)
	VALUES (@firstname, @lastname, @dob)
RETURN SCOPE_IDENTITY()
