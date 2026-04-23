# ☕ C# DevExpress Katmanlı Mimari ile Cafe Otomasyon Sistemi

Bu proje, C# Windows Forms ve kurumsal seviyede esnek/görsel bileşenler sunan DevExpress araçları kullanılarak geliştirilmiş, Çok Katmanlı Mimari (N-Tier Architecture) prensiplerine sadık kalınarak oluşturulmuş kapsamlı bir **Cafe / Restoran Otomasyon Sistemidir**.

Proje, hem şık ve kullanıcı dostu bir arayüz (UI) sunmayı hem de arka planda güçlü, performansı yüksek bir veritabanı altyapısıyla çalışmayı hedefler. Gerçek zamanlı masa takibi, paket sipariş yönetimi, satış analizleri ve kullanıcı yetkilendirmesi gibi bir işletmenin tüm ihtiyaçlarını karşılamak üzere tasarlanmıştır.

## 🚀 Öne Çıkan Özellikler

*   **🔒 Kullanıcı ve Yetki Yönetimi:** Şifreli giriş sistemi, yetki seviyesine göre ekran erişimi.
*   **📊 Dinamik Gösterge Paneli (Dashboard):** Günlük cirolar, anlık açık masa sayısı, en çok satan ürünler gibi özet bilgilerin grafiksel gösterimi.
*   **🍽️ Masa Takibi ve Yönetimi:** Masaların anlık durumu (Boş, Dolu, vs.), renk kodları ile kolay ayrıştırma. Masadan masaya taşıma vb. işlemler.
*   **🍔 Menü ve Ürün Konfigürasyonu:** Farklı kategorilerde (Yiyecekler, İçecekler, Tatlılar vb.) menü tanımlama, alt ürünleri fiyat, resim ve porsiyon bazlı listeleme.
*   **📝 Sipariş ve Adisyon Sistemi:** Hızlı sipariş ekleme/çıkarma, kısmi (parçalı) veya tam ödeme alabilme imkanı.
*   **🛵 Paket Servis Modülü:** Müşteri kaydı oluşturma, kurye ve sipariş durum takibi (Hazırlanıyor, Yolda, Teslim Edildi).
*   **💳 Kasa ve Ödeme Yöntemleri:** Nakit, Kredi Kartı veya Ticket (Yemek Kartı) seçenekleri.
*   **🖨️ Fiş / Adres Yazdırma:** Siparişler mutfak veya kasa yazıcısına otomatik yönlendirilebilir.
*   **📈 Detaylı Raporlar:** Tarih bazlı satış raporları, ürün hareketleri, sistem ve personel log (hareket) raporları.
*   **⚙️ Sistem Ayarları:** İşletme bilgilerini ve varsayılan yazıcı donanımlarını tanımlayabilme.

## 🛠 Kullanılan Teknolojiler

*   **Dil:** C#
*   **Platform:** .NET Framework 4.7.2
*   **Kullanıcı Arayüzü (UI):** Windows Forms & DevExpress UI Components
*   **Veritabanı:** Microsoft SQL Server
*   **Veritabanı Yaklaşımı:** ADO.NET kullanılarak yazılmış merkezi `DatabaseHelper` sınıfı tabanlı veri iletişim katmanı.

## 📸 Ekran Görüntüleri

*(Projenizi GitHub'a yükledikten sonra, ilgili ekran görüntülerini `docs/` veya `images/` klasörüne ekleyip aşağıdaki yolları güncelleyebilirsiniz)*

| Dashboard / Ana Ekran | Masa Görünümü |
| :---: | :---: |
| ![Dashboard Resmi Gelecek](https://via.placeholder.com/400x250.jpg?text=Dashboard+Ekrani) | ![Masalar Resmi Gelecek](https://via.placeholder.com/400x250.jpg?text=Masa+Takip+Ekrani) |
| **Sipariş & Adisyon** | **Satış Raporları** |
| ![Sipariş Ekranı](https://via.placeholder.com/400x250.jpg?text=Siparis+Adisyon+Ekrani) | ![Raporlar Ekranı](https://via.placeholder.com/400x250.jpg?text=Satis+Raporlari) |

---

## 💻 Kurulum ve Çalıştırma Ana Yönergesi

Projeyi kendi bilgisayarınızda çalıştırabilmeniz için aşağıdaki adımları sırasıyla uygulamanız gerekmektedir.

### 1. Gereksinimler

*   **Visual Studio 2019 veya 2022**
*   **Microsoft SQL Server** (LocalDB veya Express sürümü yeterlidir)
*   **DevExpress WinForms Bileşenleri** (Projeyi hatasız derlemek için sisteminizde DevExpress'in lisanslı veya trial sürümü kurulu olmalıdır)

### 2. Projeyi Klonlama

```bash
git clone https://github.com/KULLANICI_ADINIZ/PROJE_REPOSITORY_ADINIZ.git
cd "C# DevExpress Katmalı Mimari ile Cafe Otomasyonu"
```

### 3. Veritabanı (SQL Server) Kurulumu

Projenin veritabanı tablolarının oluşturulması gerekmektedir. (Eğer projenizde bir `.sql` script veya yedek dosyası varsa, onu çalıştırın.)
1. SQL Server Management Studio (SSMS) açın.
2. `CafeOtomasyonDB` adında (veyahut scriptinizdeki ada göre) yeni bir veritabanı oluşturun.
3. Proje klasöründeki veritabanı oluşturma betiğini (kodu) çalıştırarak tabloları ve varsayılan test verilerini içeri aktarın.
4. **Bağlantı Ayarını Yapma:**
   Visual Studio üzerinden projeyi açın. Data Access Layer (DAL) klasöründeki veya kök dizindeki `DatabaseHelper.cs` (bağlantıyı sağlayan sınıf) dosyasını bulun. `ConnectionString` ifadesini kendi yerel SQL Server sunucunuza `(Server=SizinSunucuAdınız;Database=CafeOtomasyonDB;...)` göre güncelleyin.

### 4. Projeyi Derleme (Build)

1. `CafeOtomasyonu.sln` çözüm dosyasını Visual Studio ile açın.
2. Çözüm Gezgini (Solution Explorer) üzerinde projeye sağ tıklayıp **Rebuild** (Yeniden Derle) seçeneğine tıklayın.
3. Eksik olan NuGet paketleri varsa geri yüklenecektir. DevExpress hatalı uyarılar veriyorsa `DevExpress Project Converter` aracını çalıştırarak PC'nizdeki DevExpress sürümüne yükseltebilirsiniz.

### 5. Çalıştırma
F5 tuşuna basarak veya yukarıdaki sekmeden **Start (Başlat)** butonuna tıklayarak projeyi çalıştırın.

---

## 📖 Nasıl Kullanılır?

1. **Giriş Yapma:** Varsayılan yönetici bilgileriyle (Örnek: Kullanıcı Adı: `admin`, Şifre: `1234` vb.) sisteme giriş yapın.
2. **Gerekli Tanımlamalar:** 
   Sistemi kullanmaya başlamadan önce, **Kullanıcılar / Personeller**, **Ürün Kategorileri (Menüler)** ve **Ürünler** menülerine girerek işletmenizin menüsünü sisteme tanımlayın. Masalar menüsünden işletmenizdeki masaları (Bahçe-1, Salon-2, VIP vb.) oluşturun.
3. **Masa ve Sipariş İşlemleri:**
   "Masalar" sekmesinden boş olan (yeşil) bir masaya tıklayarak masayı açabilir, sağ taraftaki menü panellerinden ürün seçip adisyona ekleyebilirsiniz.
4. **Ödeme Alma:**
   Masa sipariş ekranında "Ödeme Al" ekranına geçerek, Nakit/KK/Ticket seçeneklerinden biriyle ödemeyi kabul edebilir ve fiş yazdırarak masayı (kapatıp) tekrar yeşil/boş duruma getirebilirsiniz.
5. **Ayarlar:**
   "Ayarlar" ekranına geçerek işletme adı, anlık fiş cihazı ve saat/tarih konfigürasyonunu kontrol edebilirsiniz.

## 🤝 Katkıda Bulunma (Contributing)

Bu proje eğitim veya geliştirme amaçlı herkese açıktır. Repoyu "fork"layabilir, "Pull Request" oluşturabilir veya "Issue" sekmesinden tespit ettiğiniz açıkları/hataları bildirebilirsiniz.

## ⚖️ Lisans

Bu proje **MIT Lisansı** ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına göz atabilirsiniz.

---
⭐ Projeyi beğendiyseniz sağ üst köşeden repoya Yıldız (Star) vermeyi unutmayın!
