CREATE TABLE "Categories" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	PRIMARY KEY("Id")
)

CREATE TABLE "Products" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	PRIMARY KEY("Id")
)

CREATE TABLE "ProductCategories" (
	"Product_Id"	INTEGER NOT NULL,
	"Category_Id"	INTEGER NOT NULL,
	PRIMARY KEY("Product_Id","Category_Id"),
	FOREIGN KEY("Category_Id") REFERENCES "Categories"("Id"),
	FOREIGN KEY("Product_Id") REFERENCES "Products"("Id")
)