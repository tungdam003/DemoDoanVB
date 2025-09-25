

-- 1) Tạo database 
IF DB_ID('DoanQLphongtro') IS NULL
BEGIN
    CREATE DATABASE DoanQLphongtro;
END
GO

-- 2) Chọn database
USE DoanQLphongtro;
GO

-- 3) Xóa các bảng (theo thứ tự bỏ FK) nếu đã tồn tại
IF OBJECT_ID('Invoices', 'U') IS NOT NULL DROP TABLE Invoices;
IF OBJECT_ID('Contracts', 'U') IS NOT NULL DROP TABLE Contracts;
IF OBJECT_ID('Tenants', 'U') IS NOT NULL DROP TABLE Tenants;
IF OBJECT_ID('Rooms', 'U') IS NOT NULL DROP TABLE Rooms;
IF OBJECT_ID('MeterReadings', 'U') IS NOT NULL DROP TABLE MeterReadings;
IF OBJECT_ID('Settings', 'U') IS NOT NULL DROP TABLE Settings;
GO

-- 4) Bảng Rooms
CREATE TABLE Rooms (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber NVARCHAR(20) NOT NULL UNIQUE, -- tránh trùng số phòng
    Floor INT NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT(N'Trống'),
    Description NVARCHAR(250) NULL
);
GO

-- 5) Bảng Tenants (Khách thuê)
CREATE TABLE Tenants (
    TenantID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    IDNumber NVARCHAR(50) NULL UNIQUE,  -- CMND/CCCD nên unique
    Phone NVARCHAR(20) NULL,
    Address NVARCHAR(200) NULL,
    Email NVARCHAR(100) NULL
);
GO

-- 6) Bảng Contracts (Hợp đồng)
CREATE TABLE Contracts (
    ContractID INT IDENTITY(1,1) PRIMARY KEY,
    RoomID INT NOT NULL,
    TenantID INT NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT(N'Còn hiệu lực'),
    CONSTRAINT FK_Contracts_Rooms FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    CONSTRAINT FK_Contracts_Tenants FOREIGN KEY (TenantID) REFERENCES Tenants(TenantID)
);
GO

-- 7) Bảng Invoices (Hóa đơn)
CREATE TABLE Invoices (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
    ContractID INT NOT NULL,
    Month INT NOT NULL CHECK (Month BETWEEN 1 AND 12),
    Year INT NOT NULL CHECK (Year >= 2000),
    RoomPrice DECIMAL(18,2) NOT NULL,
    Electricity DECIMAL(18,2) NOT NULL,
    Water DECIMAL(18,2) NOT NULL,
    Internet DECIMAL(18,2) NOT NULL,
    TotalAmount AS (RoomPrice + Electricity + Water + Internet) PERSISTED, -- lưu sẵn
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Invoices_Contracts FOREIGN KEY (ContractID) REFERENCES Contracts(ContractID)
);
GO

-- 8) Bảng MeterReadings & Settings
CREATE TABLE MeterReadings (
    ReadingID INT IDENTITY(1,1) PRIMARY KEY,
    ContractID INT NULL,
    Year INT NULL,
    Month INT NULL,
    ElecReading DECIMAL(18,2) NULL,
    WaterReading DECIMAL(18,2) NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Settings (
    SettingKey NVARCHAR(50) PRIMARY KEY,
    SettingValue NVARCHAR(200)
);
GO

-- 9) Chèn dữ liệu mẫu
INSERT INTO Rooms (RoomNumber, Floor, Price, Status, Description)
VALUES 
(N'101', 1, 1500000, N'Trống', N'Phòng tầng 1, diện tích 20m2'),
(N'102', 1, 1700000, N'Đang thuê', N'Phòng tầng 1, có ban công'),
(N'201', 2, 1800000, N'Trống', N'Phòng tầng 2, có cửa sổ lớn');
GO

INSERT INTO Tenants (FullName, IDNumber, Phone, Address, Email)
VALUES 
(N'Phan Đức Anh', N'123456789', N'0912345678', N'Vĩnh Phúc', N'a@gmail.com'),
(N'Hoàng Anh Tuấn', N'987654321', N'0987654321', N'Nam Định cũ', N'b@gmail.com');
GO

INSERT INTO Contracts (RoomID, TenantID, StartDate, EndDate, Status)
VALUES 
(2, 1, '2025-01-01', '2025-12-31', N'Còn hiệu lực');
GO

INSERT INTO Invoices (ContractID, Month, Year, RoomPrice, Electricity, Water, Internet)
VALUES 
(1, 9, 2025, 1700000, 2500000, 100000, 100000);
GO

-- 10) Kiểm tra dữ liệu
SELECT DB_NAME() AS CurrentDB;
SELECT * FROM Rooms;
SELECT * FROM Tenants;
SELECT * FROM Contracts;
SELECT * FROM Invoices;
GO

ALTER TABLE Contracts
ADD Deposit DECIMAL(18,2) NULL,
    MonthlyRent DECIMAL(18,2) NULL,
    Notes NVARCHAR(255) NULL;
