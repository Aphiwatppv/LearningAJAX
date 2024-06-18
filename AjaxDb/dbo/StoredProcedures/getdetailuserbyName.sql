CREATE PROCEDURE [dbo].[getdetailuserbyName]
	@Name NVARCHAR(50)
AS
BEGIN
	SELECT * FROM [dbo].[UserTables]
	WHERE Name =@Name;
END

