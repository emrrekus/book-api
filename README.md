# Book API Project

Bu proje, kitap yönetimi için geliştirilmiş bir API ve web uygulamasıdır. N-Tier Architecture prensiplerine uygun olarak geliştirilmiştir.

## Proje Yapısı

Proje 4 ana katmandan oluşmaktadır:

- **BookAPI.EntityLayer**: Veritabanı tablolarını temsil eden entity sınıflarını içerir
- **BookAPI.DataAccessLayer**: Veritabanı işlemlerini ve repository pattern implementasyonunu içerir
- **BookAPI.BusinessLayer**: İş mantığı katmanını içerir
- **BookAPI.WebAPI**: RESTful API endpoints'lerini içerir
- **BookAPI.WebUI**: Kullanıcı arayüzünü içerir

## Teknolojiler

- ASP.NET Core 6.0
- Entity Framework Core
- SQL Server
- Repository Pattern
- N-Tier Architecture
- ViewComponents
- DTOs (Data Transfer Objects)

## Özellikler

- Kitap listeleme, ekleme, güncelleme, silme
- Kategori bazlı kitap filtreleme
- Yazar bazlı kitap filtreleme
- Son eklenen kitapları listeleme
- Rastgele kitap önerisi
- Kategoriye göre kitap listeleme

## API Endpoints

- `GET /api/Book`: Tüm kitapları listeler
- `GET /api/Book/{id}`: ID'ye göre kitap getirir
- `POST /api/Book`: Yeni kitap ekler
- `PUT /api/Book`: Kitap günceller
- `DELETE /api/Book/{id}`: Kitap siler
- `GET /api/Book/GetLast4Book`: Son eklenen 4 kitabı getirir
- `GET /api/Book/GetRandomBook`: Rastgele bir kitap önerir
- `GET /api/Book/GetBookByCategory`: Kategoriye göre kitapları listeler


![6](https://github.com/user-attachments/assets/3abd0082-01ab-45c9-85e4-8f835590999f)
![5](https://github.com/user-attachments/assets/391e9dfc-7e52-484d-b877-56e68e1caa1e)
![4](https://github.com/user-attachments/assets/bb12c3a4-0ff7-4521-91d6-e3b3a8ab685e)
![3](https://github.com/user-attachments/assets/3584d13e-4ccb-46bf-9d83-5097a378f197)
![2](https://github.com/user-attachments/assets/feacd4c6-6ac1-4156-bac5-fd46bf4bfc38)
![1](https://github.com/user-attachments/assets/43c38dfc-2863-4c1a-ba9e-ee644c1840f1)




