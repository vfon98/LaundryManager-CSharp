USE QuanLyGiatUi
GO

CREATE TABLE Services (
	STT INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Price MONEY NOT NULL CHECK (Price > 0)
)
Go
SELECT * FROM Services

CREATE TABLE Orders (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	CustomerName NVARCHAR(100) NOT NULL,
	Phone NVARCHAR(20),
	[Address] NVARCHAR(200),
	OrderName NVARCHAR(100),
	[Service] NVARCHAR(50) NOT NULL,
	[Weight] FLOAT NOT NULL,
	Delivery BIT NOT NULL,
	Price DECIMAL(18,0) NOT NULL,
	[Status] NVARCHAR(100) NOT NULL,
	[Date] DATETIME NOT NULL DEFAULT GETDATE()
)
SELECT * FROM Orders
GO

INSERT INTO Orders (CustomerName, Phone, Address, OrderName, Service, Weight, Delivery, Price, Status) VALUES ('Phong', '2115', 'NVC', 'Ao', 'Giat kho', 0.2, 1, 12000 , 'CHua hoan thanh')
GO
SELECT * FROM Orders, Services