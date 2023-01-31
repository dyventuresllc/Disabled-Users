SELECT 
	u.ArtifactID, u.FirstName, u.LastName, u.EmailAddress
FROM eddsdbo.[user] u with (NOLOCK)
JOIN eddsdbo.GroupUser gu WITH (NOLOCK) 
	ON gu.UserArtifactID = u.ArtifactID
JOIN eddsdbo.[Group] g WITH (NOLOCK) 
	ON g.ArtifactID = gu.GroupArtifactID
JOIN
(
	SELECT gu.UserArtifactID, COUNT(gu.GroupArtifactID) 'Group Count'
	FROM eddsdbo.GroupUser gu WITH (NOLOCK)
	GROUP BY gu.UserArtifactID
	HAVING COUNT(gu.GroupArtifactID) = 1
) gc
	ON gc.UserArtifactID = u.ArtifactID 
WHERE	
	u.RelativityAccess = 1
AND	g.[Name] = 'Everyone'
AND u.EmailAddress NOT like '%kcura.com%'
AND u.EmailAddress NOT like '%relativity.com%';