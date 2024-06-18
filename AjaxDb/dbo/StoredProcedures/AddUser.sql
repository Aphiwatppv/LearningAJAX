CREATE PROCEDURE [dbo].[AddUser]
    @Name NVARCHAR(50),
    @LastName NVARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[UserTables] (Name, LastName)
    VALUES (@Name, @LastName)
END