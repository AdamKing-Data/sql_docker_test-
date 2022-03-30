CREATE VIEW [docker].[vw_person]
	AS SELECT [p].[Id], [p].[Firstname], [p].[Lastname], [p].[date_of_birth], [a].[Line1], [a].[Line2], [a].[Line3], [a].[City], [a].[Postcode] 
	FROM Docker.person p
	LEFT OUTER JOIN docker.address a ON p.id = a.personid
