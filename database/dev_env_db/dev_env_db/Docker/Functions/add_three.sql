CREATE FUNCTION [docker].[add_three]
(
	@number INT
)
RETURNS INT
AS
BEGIN
	RETURN @number + 3
END
