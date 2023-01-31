SELECT 
	u.ArtifactID, 
	u.LastName, 
	u.FirstName, 
	u.EmailAddress, 
	a.CreatedOn,
	DATEDIFF(d,a.CreatedOn,GETDATE()) 'DaysSinceAccountCreated'
FROM EDDSDBO.[User] u WITH (NOLOCK)
JOIN EDDSDBO.[Artifact] a WITH (NOLOCK)
ON u.ArtifactID = a.ArtifactID
WHERE  
	u.RelativityAccess = 1
AND 
	SUBSTRING(u.EmailAddress,CHARINDEX('@',u.EmailAddress,0)+1,(LEN(u.EmailAddress) - CHARINDEX('@',u.EmailAddress,0))) 
	NOT IN ('kcura.com','PreviewUser.com','relativity.com')
AND
	DATEDIFF(d,u.LastLoginDate,GETDATE()) IS NULL
AND
	DATEDIFF(d,a.CreatedOn,GETDATE()) > @NumofDays
ORDER BY 6 DESC