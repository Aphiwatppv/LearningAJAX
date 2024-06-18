CREATE PROCEDURE [dbo].[EditUser]
    @Id INT,
    @Name NVARCHAR(50),
    @LastName NVARCHAR(50)
AS
BEGIN
		UPDATE [dbo].[UserTables]
		SET Name = @Name, LastName = @LastName
		WHERE Id = @Id

END
