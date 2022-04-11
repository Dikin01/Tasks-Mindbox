SELECT Products.Name, Categories.Name
FROM Products 
LEFT JOIN ProductCategories ON ProductCategories.Product_Id = Products.Id
LEFT JOIN Categories ON ProductCategories.Category_Id = Categories.Id