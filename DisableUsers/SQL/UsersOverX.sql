SELECT 
	u.ArtifactID, 
	u.LastName, 
	u.FirstName, 
	u.EmailAddress, 
	u.LastLoginDate,
	DATEDIFF(d,u.LastLoginDate,GETDATE()) AS 'DaySinceLastLogin'
FROM EDDSDBO.[User] u WITH (NOLOCK)
WHERE  
	u.RelativityAccess = 1
AND 
	SUBSTRING(u.EmailAddress,CHARINDEX('@',u.EmailAddress,0)+1,(LEN(u.EmailAddress) - CHARINDEX('@',u.EmailAddress,0))) 
	NOT IN ('kcura.com','PreviewUser.com','relativity.com')
AND
	DATEDIFF(d,u.LastLoginDate,GETDATE()) > @NumOfDays
ORDER BY 6 DESC