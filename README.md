# .NET Unit Test & Repository Practice

Bu proje, .NET platformunda Entity Framework Core, MSSQL, Repository Pattern, xUnit ve Moq kullanılarak hazırlanmış örnek bir çalışmadır.

## Proje İçeriği

- Entity Framework Core ile MSSQL üzerinde CRUD işlemleri
- Repository Pattern kullanımı
- Console Application üzerinden CRUD işlemlerinin çalıştırılması
- xUnit ile unit test yazımı
- Moq kullanılarak bağımlılıkların mock’lanması
- Fact ve Theory kullanımı

## Kullanılan Teknolojiler

- .NET
- Entity Framework Core
- MSSQL (LocalDB)
- xUnit
- Moq

## Proje Yapısı

- **Entities**: Veritabanı modelleri
- **Context**: DbContext ve EF Core yapılandırması
- **Repos**: Repository sınıfları
- **Services**: İş mantığı katmanı
- **ConsoleApp**: CRUD işlemlerinin çalıştırıldığı demo uygulama
- **xunit**: Unit testlerin bulunduğu proje

## Unit Testler

Unit testler xUnit kullanılarak yazılmıştır.  
Repository ve veritabanı bağımlılıkları Moq kullanılarak mock’lanmış, servis katmanı izole şekilde test edilmiştir.

- `[Fact]` ile tek senaryolu testler
- `[Theory]` ve `[InlineData]` ile parametreli testler

## Not

Bu proje öğrenme ve pratik amaçlı hazırlanmıştır.
