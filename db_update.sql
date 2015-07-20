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


