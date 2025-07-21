# 📊 Tarih Aralıklı Veri Görselleştirme Uygulaması | Date Range-Based Data Visualization App

Bu proje, iki tarih arasındaki verileri grafiksel formatta gösteren bir web uygulamasıdır. **Clean Architecture** ve **Repository Design Pattern** prensipleriyle geliştirilmiş olup, .NET tabanlı Web API ve Blazor WebAssembly kullanılarak oluşturulmuştur. Grafik gösterimleri için **ApexCharts** kütüphanesi tercih edilmiştir.

This project is a web application that displays data between two selected dates in graphical format. It is built using **Clean Architecture** and **Repository Design Pattern**, with a .NET-based Web API and Blazor WebAssembly frontend. **ApexCharts** is used for chart visualizations.

---

## 🚀 Teknolojiler / Technologies

- ASP.NET Core Web API (.NET 7/8)
- Blazor Web App
- ApexCharts
- Entity Framework Core
- SQL Server
- Clean Architecture
- Repository Design Pattern

---

## ⚙️ Kurulum / Setup

### Türkçe

Projeyi lokal ortamınızda çalıştırmak için:

1. **Visual Studio 2022** veya üzeri bir sürüm kurulu olmalıdır.
2. `src/` klasörü altındaki `.bak` uzantılı SQL Server yedeğini SQL Server üzerinde geri yükleyin.
3. `appsettings.json` dosyasındaki `ConnectionStrings` kısmını kendi veritabanı bağlantınıza göre düzenleyin.
4. Çözümü Visual Studio ile açın ve hem API'yi hem de Blazor istemcisini başlatın.

### English

To run the project locally:

1. You must have **Visual Studio 2022** or later installed.
2. Restore the SQL Server backup file (`.bak`) located in the `src/` folder to your SQL Server instance.
3. Update the `ConnectionStrings` section in the `appsettings.json` file with your own database connection.
4. Open the solution in Visual Studio and run both the API and Blazor client projects.

---

## 🧪 Demo Veriler / Demo Data

### Türkçe

- Yedek dosyasında örnek veriler yer almaktadır.
- İlk veri tarihi: **16.10.2024**
- Son veri tarihi: **günümüz tarihi**
- Grafik görüntülemek için bu tarih aralığını seçebilirsiniz.

### English

- The backup file includes sample data.
- First record date: **2024-10-16**
- Last record date: **today's date**
- You can select this date range to view the charts.

---

## 🗂️ Proje Yapısı / Project Structure

## 📝 Notlar / Notes

- Web API, Blazor istemcisine veri sağlar.
- Blazor istemcisi, tarih aralığına göre verileri çeker ve ApexCharts ile grafiksel olarak sunar.
- `appsettings.json` dosyasındaki bağlantı dizesi doğru yapılandırılmalıdır, aksi takdirde API çalışmaz.

- The Web API provides data to the Blazor client.
- The Blazor client fetches data based on date range and displays it using ApexCharts.
- Make sure the connection string in `appsettings.json` is correctly configured; otherwise, the API won't work.


