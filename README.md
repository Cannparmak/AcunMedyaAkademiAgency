# AcunMedyaAkademiAgency Projesi

## Açıklama
AcunMedyaAkademiAgency, ASP.NET MVC, Entity Framework ve MSSQL kullanarak geliştirilmiş bir ajans yönetim sistemidir. Code First yaklaşımını kullanarak veritabanı yönetimini kolaylaştırır ve Partial View'ler ile dinamik bir kullanıcı deneyimi sunar.

## Özellikler
- Kullanıcı yönetimi ve kimlik doğrulama
- Ajans verileri için CRUD işlemleri
- Partial View ile modüler ve dinamik arayüz
- Entity Framework ile MSSQL veritabanı entegrasyonu
- ASP.NET MVC tabanlı duyarlı (responsive) tasarım

## Gereksinimler
- .NET Framework ([uygun sürümü belirtin])
- Microsoft SQL Server (MSSQL)
- Visual Studio ([uygun sürümü belirtin])
- Entity Framework

## Kurulum

### 1. Depoyu Klonlayın
```sh
 git clone https://github.com/fthsrbst/AcunMedyaAkademi_Agency.git
 cd AcunMedya_Agency
```

### 2. Veritabanı Yapılandırması
- MSSQL üzerinde yeni bir veritabanı oluşturun veya mevcut bir veritabanını kullanın.
- `Web.config` dosyasındaki bağlantı dizesini kendi veritabanı bilgilerinizle güncelleyin:
  
```xml
<connectionStrings>
    <add name="DefaultConnection" connectionString="Server=YOUR_SERVER;Database=YOUR_DB_NAME;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3. Uygulamayı Çalıştırın
- Visual Studio'da projeyi açın.
- `NuGet Package Manager` kullanarak eksik bağımlılıkları yükleyin.
- Veritabanı şemasını oluşturmak için aşağıdaki komutu çalıştırın:
  ```sh
  Update-Database
  ```
- Uygulamayı derleyin ve çalıştırın.

## Katkıda Bulunma
Projeye katkıda bulunmak için `develop` dalından fork alabilir ve pull request oluşturabilirsiniz.

## Lisans
Bu proje [lisans türü] ile lisanslanmıştır.

---

Bu README, projenin temel bilgilerini, gereksinimlerini ve kurulum adımlarını içermektedir. Eğer eklemek istediğiniz özel bir bölüm varsa bana bildirebilirsiniz!



![Ekran görüntüsü 2025-03-14 015315](https://github.com/user-attachments/assets/c3ac5dc0-8731-4158-8778-79b0e43c36c3)
![Ekran görüntüsü 2025-03-14 015050](https://github.com/user-attachments/assets/77eb047c-a00c-455d-9ef5-012b6f438919)
![Ekran görüntüsü 2025-03-14 015041](https://github.com/user-attachments/assets/816a7edc-6443-4e87-8577-d37ac797b22c)
![Ekran görüntüsü 2025-03-14 015028](https://github.com/user-attachments/assets/76b5eef0-f559-4bce-beb3-0cf0134a9425)
![Ekran görüntüsü 2025-03-14 015012](https://github.com/user-attachments/assets/06031ff7-3e77-4986-831a-084375216346)
![Ekran görüntüsü 2025-03-14 015559](https://github.com/user-attachments/assets/92e5bb8d-23b2-4ebe-bbd7-117b084052ed)
![Ekran görüntüsü 2025-03-14 015535](https://github.com/user-attachments/assets/0ac2f19b-1ddd-4f27-a7d8-bbbf7453665c)
![Ekran görüntüsü 2025-03-14 015346](https://github.com/user-attachments/assets/cf9c64ff-f25f-4638-94a4-9f08ed700853)

