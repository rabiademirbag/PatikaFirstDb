# 📘 PatikaFirstDb Web API

Bu proje, Entity Framework Core kullanılarak **Code First** yaklaşımıyla geliştirilmiş basit bir ASP.NET Core Web API uygulamasıdır. Uygulama içerisinde `Movie` ve `Game` varlıkları yer almaktadır.

---

## 🛠️ Kullanılan Teknolojiler

- ASP.NET Core
- Entity Framework Core
- SQL Server Express
- Swagger (OpenAPI)

## 🔌 Veritabanı Bağlantısı

Veritabanı bağlantısı `appsettings.json` dosyasındaki `Default` isimli bağlantı dizesi üzerinden sağlanır:

```json
"ConnectionStrings": {
  "Default": "Server=.\\SQLEXPRESS;Database=PatikaCodeFirstDb1;Trusted_Connection=True;TrustServerCertificate=True"
}
