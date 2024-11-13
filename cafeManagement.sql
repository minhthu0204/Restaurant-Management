CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- Billinfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)  NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100)  NOT NULL DEFAULT N'Trống' --trống || có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100)  NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000)  NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1:ADMIN || 0: STAFF
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)  NOT NULL DEFAULT N'Chưa đặt tên',
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)  NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT  NOT NULL DEFAULT 0 -- 1:ĐÃ THANH TOÁN || 0: CHƯA THANH TOÁN

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)

)
GO

INSERT INTO dbo.Account
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
VALUES
(
	N'K9',
	N'Rong K9',
	N'1',
	1
);

INSERT INTO dbo.Account
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
VALUES
(
	N'phulinh1912',
	N'Linh',
	N'1912',
	0
);

SELECT * FROM dbo.Account;

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'K9'

SELECT * FROM dbo.Account WHERE UserName = N'K9' AND PassWord = N'1'

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100) 
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

DECLARE @i INT = 0

WHILE @i <= 10
BEGIN 
	INSERT dbo.TableFood (name) VALUES ( N'Bàn ' + CAST(@i AS nvarchar(100) ))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS 
SELECT * FROM dbo.TableFood
GO

UPDATE dbo.TableFood SET status = N'Có người' WHERE id = 9

EXEC USP_GetTableList


--thêm category
INSERT dbo.FoodCategory
		(name)
VALUES ( N'Hải sản')
INSERT dbo.FoodCategory
		(name)
VALUES ( N'Nông sản' )
INSERT dbo. FoodCategory
	(name)
VALUES ( N'Lâm sản' )
INSERT dbo.FoodCategory
	(name)
VALUES ( N'Sản sản' )
INSERT dbo.FoodCategory
	( name )
VALUES ( N'Nước' )

--thêm food
INSERT dbo. Food
(name, idCategory, price)
VALUES( N'Mực một nắng nước sa tế',
1,120000)
INSERT dbo.Food
(name, idCategory, price)
VALUES ( N'Nghêu hấp xả', 1, 50000)
INSERT dbo.Food
(name, idCategory, price)
VALUES ( N'Dú dê nướng sữa', 2, 750000)
INSERT dbo.Food
(name, idCategory, price)
VALUES ( N'Heo rừng nướng muối ớt', 3, 1350000)
INSERT dbo.Food
(name, idCategory, price)
VALUES ( N'Cơm chiên mushi', 4, 50000)
INSERT dbo.Food
(name, idCategory, price)
VALUES (N'7Up', 5, 15000)
INSERT dbo.Food
(name, idCategory, price)
VALUES (N'Coca', 5, 12000)


--thêm bill
INSERT dbo.Bill
(DateCheckIn, DateCheckOut, idTable, status)	
VALUES( GETDATE(), NULL, 1, 0 )
INSERT dbo.Bill
(DateCheckIn, DateCheckOut, idTable, status)	
VALUES( GETDATE(), NULL, 2, 0 )
INSERT dbo.Bill
(DateCheckIn, DateCheckOut, idTable, status)	
VALUES( GETDATE(),GETDATE(), 1, 1 )

DELETE FROM dbo.BillInfo
WHERE id = 5;


--thêm billInfo
INSERT dbo.BillInfo
(idBill, idFood, count)
VALUES (1,1,2)
INSERT dbo.BillInfo
(idBill, idFood, count)
VALUES (1,4,1)

INSERT dbo.BillInfo
(idBill, idFood, count)
VALUES (4,1,3)
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Food
SELECT * FROM dbo.FoodCategory

SELECT * FROM dbo.BillInfo WHERE idBill = 1 

SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo. Bill AS b, dbo. Food AS f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 1 and b.status = 0


SELECT 
    name 
FROM sys.foreign_keys 
WHERE parent_object_id = OBJECT_ID('Bill');
GO

ALTER TABLE Bill
DROP CONSTRAINT FK__Bill__status__22AA2996;
GO

DROP TABLE TableFood;
GO

ALTER TABLE Bill
ADD CONSTRAINT FK_Bill_TableFood
FOREIGN KEY (idTable) REFERENCES TableFood(id);
GO
