SELECT
	p.Name
	, c.Name
FROM 
	product p
	LEFT JOIN ProductCategory pc ON p.id = pc.ProductId 
	LEFT JOIN Category c ON c.Id = pc.CategoryId 
GROUP BY 
	p.Name
	, c.Name
ORDER BY 
	p.Name
	, c.Name