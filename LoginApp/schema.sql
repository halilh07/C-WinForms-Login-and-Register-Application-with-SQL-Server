-- Veritabanını oluşturma
CREATE DATABASE Logs;
GO

USE Logs;
GO

-- Tabloyu oluşturma
CREATE TABLE tbl_Register (
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Name NVARCHAR(50),
    Age INT
);