CREATE PROCEDURE [dbo].[SearchUsersByName]
    @SearchName NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        Name,
        LastName,
        CreatDateTime
    FROM 
        [dbo].[UserTables]
    WHERE 
        Name LIKE '%' + @SearchName + '%';
END
