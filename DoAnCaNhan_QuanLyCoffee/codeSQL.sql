CREATE TABLE [dbo].[informationTable] (
    [idTable]   INT        NOT NULL,
    [nameTable] NCHAR (20) NULL,
    [status]    INT        NULL,
    PRIMARY KEY CLUSTERED ([idTable] ASC)
);

CREATE TABLE [dbo].[infoBill] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [idBill] INT NULL,
    [idFood] INT NULL,
    [count]  INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[foodBill] (
    [IdGiaoDich] INT IDENTITY (1, 1) NOT NULL,
    [idFood]     INT NULL,
    [countFood]  INT NULL,
    [idTable]    INT NULL,
    [idBill]     INT NULL,
    PRIMARY KEY CLUSTERED ([IdGiaoDich] ASC)
);

CREATE TABLE [dbo].[food] (
    [idFood]    INT        NOT NULL,
    [nameFood]  NCHAR (20) NULL,
    [moneyFood] INT        NULL,
    [category]  INT        NULL,
    PRIMARY KEY CLUSTERED ([idFood] ASC)
);


CREATE TABLE [dbo].[dataLogin] (
    [account]    NCHAR (20) NOT NULL,
    [password]   NCHAR (20) NOT NULL,
    [checkLogin] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([account] ASC)
);

CREATE TABLE [dbo].[category] (
    [maFoodCategory] INT        NOT NULL,
    [nameCategory]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([maFoodCategory] ASC)
);

CREATE TABLE [dbo].[bill] (
    [IdBill]       INT      IDENTITY (1, 1) NOT NULL,
    [dateCheckIn]  DATETIME NULL,
    [dateCheckout] DATETIME NULL,
    [idTable]      INT      NULL,
    [status]       INT      NULL,
    PRIMARY KEY CLUSTERED ([IdBill] ASC)
);

BEGIN TRANSACTION;
INSERT INTO informationTable (idTable, nameTable, status) VALUES
(1, 'bàn 1', 0),
(2, 'bàn 2', 0),
(3, 'bàn 3', 0),
(4, 'bàn 4', 0),
(5, 'bàn 5', 0),
(6, 'bàn 6', 0),
(7, 'bàn 7', 0),
(8, 'bàn 8', 0),
(9, 'bàn 9', 0),
(10, 'bàn 10', 0),
(11, 'bàn 11', 0),
(12, 'bàn 12', 0);
COMMIT;

INSERT INTO food (idFood, nameFood, moneyFood,category) VALUES
(1, N'Cà Phê Sữa Đá', 15000,1),
(2, N'Cà Phê Dừa', 35000,1),
(3, N'Cà phê Trứng', 30000,1),
(4, N'Bạc Xỉu', 15000,1),
(5, N'Nước Cam', 30000,2),
(6, N'Nước ép Táo', 25000,2),
(7, N'Sữa Dừa', 35000,2),
(8, N'Coca', 15000,3),
(9, N'String', 15000,3),
(10, N'RedBull', 25000,3),
(11, N'Nước lọc', 10000,3);
insert into infoBill (idBill,idFood,count) values (1,9,2);
select idBill from bill where  idTable= 7
DELETE FROM bill WHERE IdBill = 20 OR IdBill = 19 OR IdBill = 18 OR IdBill = 17 OR IdBill = 16

