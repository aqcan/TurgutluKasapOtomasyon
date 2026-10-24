# Turgutlu Kasap – Butcher Shop Automation

A desktop automation system for a butcher shop, built with **C# Windows Forms** and **SQL Server** as the team project of the 2nd-year *Object-Oriented Programming* course at Manisa Celal Bayar University, Software Engineering (December 2021).

## Features

**Customer side**
- Sign up and log in
- Browse products and place orders
- Pay by credit card or cheque

**Admin side**
- Admin login and control panel
- List registered customers
- Add, remove and update products

## Structure

| Path | Contents |
|---|---|
| `TurgutluKasap/Proje/Formlar` | Windows Forms screens (main menu, sign-up, customer login, order, payments, admin panel, product management, customer list) |
| `TurgutluKasap/Proje/Sınıflar` | Model classes: `musteriClass`, `urunClass`, `Program` |
| `TurgutluKasap/Proje/*DataSet*` | Typed DataSets for the `kasapprojeMusteriler` and `kasapprojeUrunler` databases |
| `TurgutluKasap/Proje/txt_database` | Sample customer and product records as text files |

## Tech

C# · .NET Framework 4.7.2 · Windows Forms · Microsoft SQL Server (ADO.NET)

## Running

Open `TurgutluKasap/Proje.sln` in Visual Studio. The connection strings in `App.config` point to the SQL Server instance on the original development machine; change `Data Source` to your own server and create the `kasapprojeMusteriler` and `kasapprojeUrunler` databases before running.

## Team

- Sinan Akcan
- Atakan Kaya
- Efecan Şenol

---

**TR:** Celal Bayar Üniversitesi Yazılım Mühendisliği 2. sınıf Nesneye Yönelik Programlama dersi proje ödevi (26.12.2021). Müşteri kaydı/girişi, sipariş, kredi kartı ve çek ile ödeme; admin tarafında müşteri listeleme ve ürün ekleme/çıkarma/güncelleme ekranları bulunan bir kasap otomasyonu. Hazırlayanlar: Sinan Akcan, Atakan Kaya, Efecan Şenol.
