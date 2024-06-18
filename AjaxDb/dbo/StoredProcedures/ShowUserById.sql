CREATE PROCEDURE [dbo].[ShowUserById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[UserTables]
	WHERE Id = @Id
END
	
