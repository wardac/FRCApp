INSERT INTO dbo.Races
SELECT 'Multi-racial'
GO

ALTER PROC dbo.GetInactiveEFARequestsByClientID(@ClientID NVARCHAR(36)) AS BEGIN
SELECT dis.*
FROM dbo.EFARequestsDisplay dis
	JOIN dbo.EFARequests r
		ON dis.EFARequestID = r.EFARequestID
	JOIN (SELECT EFARequestID FROM dbo.EFASubrequests WHERE DateClosed IS NOT NULL GROUP BY EFARequestID) sub
		ON r.EFARequestID = sub.EFARequestID
WHERE r.ClientID = @ClientID
ORDER BY dis.DateRequested DESC
END
GO

ALTER PROC dbo.GetActiveEFARequestsByClientID(@ClientID NVARCHAR(36)) AS BEGIN
SELECT dis.*
FROM dbo.EFARequestsDisplay dis
	JOIN dbo.EFARequests r
		ON dis.EFARequestID = r.EFARequestID
	JOIN (SELECT EFARequestID FROM dbo.EFASubrequests WHERE DateClosed IS NULL GROUP BY EFARequestID) sub
		ON r.EFARequestID = sub.EFARequestID
WHERE r.ClientID = @ClientID
ORDER BY dis.DateRequested DESC
END
GO

ALTER proc clientLookUp(@searchTerm nvarchar(100)) as begin 
SELECT * FROM (
select * from Clients where FirstName like '%' + @searchTerm + '%' or LastName like '%' + @searchTerm + '%'


UNION

SELECT c.*
FROM Clients c
	JOIN HouseholdMembers hm
		ON c.HouseholdID = hm.HouseholdID
WHERE hm.FirstName LIKE '%' + @searchTerm + '%' OR hm.LastName LIKE '%' + @searchTerm + '%') q
ORDER BY q.LastName ASC, q.FirstName ASC
end
GO

CREATE PROC dbo.GetUserByUserName(@UserName NVARCHAR(100))
AS BEGIN
	SELECT * FROM Users WHERE UserName = @UserName
END
GO

CREATE PROC DeleteUserByUserName(@UserName NVARCHAR(100)) AS BEGIN
	DELETE FROM Users WHERE UserName = @UserName
END
GO

CREATE PROC dbo.AddOrUpdateUser (@UserName NVARCHAR(100), @FirstName NVARCHAR(100), @LastName NVARCHAR(100), @Password NVARCHAR(100), @AccessLevel NVARCHAR(20)) AS BEGIN
	IF EXISTS (SELECT 1 FROM Users WHERE UserName = @UserName) BEGIN
		UPDATE Users
		SET FirstName = @FirstName, LastName = @LastName, Password = @Password, AccessLevel = @AccessLevel
		WHERE UserName = @UserName
	END
	ELSE BEGIN
		INSERT INTO Users
		SELECT @UserName, @FirstName, @LastName, @Password, @AccessLevel
	END
END
GO

