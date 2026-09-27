<div align="center">

  # 🔐 LoginApp — C# WinForms & SQL Server

  **C# Windows Forms ve Microsoft SQL Server kullanılarak geliştirilmiş güvenli, modern ve kullanıcı dostu kimlik doğrulama uygulaması.**

  ![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
  ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
  ![SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC292B?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
  ![License](https://img.shields.io/badge/License-MIT-blue.style=for-the-badge)

</div>

---

## 📌 Proje Hakkında

**LoginApp**, kullanıcı kaydı (Register) ve kullanıcı girişi (Login) işlemlerini katmanlı bir yapıda ve güvenli SQL sorguları ile yöneten bir C# Windows Forms masaüstü uygulamasıdır. 

Uygulama, veritabanı işlemlerinde `Microsoft.Data.SqlClient` kütüphanesini kullanır ve SQL Enjeksiyonu (SQL Injection) zafiyetlerine karşı **Parametreli Sorgular (Parameterized Queries)** ile korunmaktadır.

---

## ✨ Öne Çıkan Özellikler

* 👤 **Kullanıcı Kaydı (Registration):** `Kullanıcı Adı`, `Şifre`, `Ad-Soyad` ve `Yaş` bilgilerini alarak SQL Server'daki `tbl_Register` tablosuna güvenli bir şekilde kaydeder.
* 🔑 **Kullanıcı Girişi (Authentication):** Girilen bilgileri veritabanındaki kayıtlarla karşılaştırarak doğrulama yapar.
* 🛡️ **Girdi Doğrulama (Input Validation):** Yaş gibi alanlar için tip dönüşüm kontrolleri (`int.TryParse`) yaparak hatalı veri girişini ve uygulama çökmelerini engeller.
* ⚡ **SQL Injection Koruması:** Veritabanına gönderilen tüm sorgular parametreize edilerek güvenli hale getirilmiştir.
* 💬 **Kullanıcı Bildirimleri:** Başarılı ve başarısız durumlarda açıklayıcı `MessageBox` bildirimleri sunar.

---

## 🛠️ Teknolojiler ve Gereksinimler

* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** Microsoft SQL Server (`.\SQLEXPRESS`)
* **Kütüphane:** `Microsoft.Data.SqlClient`
* **Geliştirme Ortamı:** Visual Studio 2022 / .NET Core

---

## 🗄️ Veritabanı Kurulumu

Proje, yerel SQL Server Express (`.\SQLEXPRESS`) üzerinde `Logs` adında bir veritabanı kullanır. Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1. SQL Server Management Studio (SSMS) veya Azure Data Studio'yu açın.
2. Proje ana dizininde yer alan [`schema.sql`](./schema.sql) dosyasını çalıştırın veya aşağıdaki SQL sorgusunu yürütün:

```sql
-- 1. Veritabanını Oluştur
CREATE DATABASE Logs;
GO

USE Logs;
GO

-- 2. Kullanıcılar Tablosunu Oluştur
CREATE TABLE tbl_Register (
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Name NVARCHAR(50),
    Age INT
);
