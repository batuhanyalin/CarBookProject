# 💻 Asp.Net Core 6 MVC CodeFirst - RapidAPI RESTful API Hotel Rezervasyon Projesi
📢 Murat YÜCEDAĞ' ın udemyde sunduğu 202 Ders 24 saatlik Asp.Net Core Api - Rapid Api ve Api Consume Hotel Rezervasyon Sitesi eğitimi kapsamında geliştirmiş olduğum proje API, Rapid API, RESTful API consume yapısını kavramamı sağladı. Proje bir hotelde kullanıcıların odaları görebildikleri, rezervasyon talebi gönderip sisteme mail aboneliği oluşturup, sistem yöneticileriyle iletişime geçebildikleri, aldıkları hizmet neticesinde yorum yapabildikleri bir ön panele sahiptir. Bununla birlikte bütün bunlar API ile veritabanında kaydedilirken yönetici panelinde de bunların hepsini yönetebilirken ekstra rol-yetkilendirme işlemleri, istatistiki veri alma vb. özellikleri mevcuttur.

## 🪶 Projeye Ait Bazı Özellikler;
* Kullanıcılar aktif odaları görebilmekte, odalar için rezervasyon oluşturabilmekte, isterlerse sistem yöneticileriyle iletişime geçebilmektedirler.
* E-posta bültenine kayıt olunabilmektedir.
* Yönetici paneli aracılığıyla bütün sistem kontrol edilebilmektedir.

## 🛠️ Kullanılan Bazı Teknolojiler
* 🌟 RapidAPI' den çekilen API' lar consume edildi. Parametreli olarak API' üzerinden consume işlemi yapıldı.
* ✨ Bütün Hotelier projesi RESTful API' larla bütün CRUD işlemlerini yapabilir şekilde oluşturuldu.
* 🌟 JWT Token ile süre bazlı token oluşturup POSTMAN ile testleri yapıldı.
* ✨ Proje Admin adlı bir Area vardır ve ana ekrandan ayrılmaktadır. 
* 🌟 Bütün proje SOLID prensipleriyle ve folder structure yapısıyla oluşturuldu.
* ✨ Structural Repository design pattern ile oluşturulmuştur.
* 🌟 DbCodeFirst ile MSSQL veritabanı oluşturulup yönetimi sağlandı.
* ✨ MimeKit ve Smtp ile mail gönderme sistemi oluşturuldu.
* 🌟 Identity kütüphanesiyle login-logout-role-register sistemi kullanıldı.
* ✨ Entity Framework 6.0 Veritabanı etkileşimi ve ORM için kullanıldı.
* 🌟 Area sistemiyle paneller birbirinden ayrılıp yönetimi kolaylaştırıldı.
* ✨ Projede bol bol iç içe layout ve ViewComponent yapısı kullanıldı.
* 🌟 DTO katmanıyla veri yönetimi kolaylaştırıldı.	
* ✨ HTML-CSS Bootstrap ile arayüzler tasarlandı.
* 🌟 Fluent Validation - kontrol sistemi kullanılarak veirlerin belli kurallara göre alınması sağlandı.
* ✨ ViewBaglerle verilerin taşınması.
* 🌟 403 - 404 sayfalarının bulunması.
* ✨ Proje seviyesinde Authentication - authorize oturum yönetim sistemi oluşturuldu.
* 🌟 AutoMapper ile Generic yapıyla DTO katmanıyla entitylerin eşleşmesi sağlandı.
* ✨ Login sistemi
* 🌟 Linq sorguları


# Veritabanı
![Veritabanı](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/database.png?raw=true)
### Giriş
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/login.png?raw=true)
### Yeni Üyelik
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/register.png?raw=true)
### Jwt Erişim Kısıtlaması
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/forbidden.png?raw=true)

### Yönetim Paneli
#### Dashboard
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_dashboard.png?raw=true)
#### İstatistikler
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_statistic.png?raw=true)
#### Araçlar
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_carList.png?raw=true)
#### Bloglar
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_blogList.png?raw=true)
#### Araç Özellikleri
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_featureList.png?raw=true)
#### Araç Özellik Eşleme
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_featureSelect.png?raw=true)
#### Etiketler
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_tagList.png?raw=true)
#### Lokasyonlar
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_locationList.png?raw=true)
#### Blog Yorumları
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_commentListBlog.png?raw=true)
#### Rezervasyonlar
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_reservation.png?raw=true)
###### Rezervasyon Güncelle
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_updateReservation.png?raw=true)
#### İletişim Mesajları
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/admin_contact.png?raw=true)
#### Mail Aboneliği 
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/subscribeList.png?raw=true)
#### Rol Listesi
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/roleList.png?raw=true)
#### Hakkında
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/aboutUpdate.png?raw=true)
#### Dosya Yükleme
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/fileUpload.png?raw=true)

#### Ana Ekran
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_banner.png?raw=true)
######
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_about-offerCar.png?raw=true)
######
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_service.png?raw=true)
######
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_testimonial.png?raw=true)
######
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_footer.png?raw=true)
#### Bloglar
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_blogList.png?raw=true)
##### Blog Detayları
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_blogDetail.png?raw=true)
##### Blog Yorumları
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_comment.png?raw=true)
#### Araçlar
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_cars.png?raw=true)
##### Araç Fiyatları
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_carPrice.png?raw=true)
##### Araç Kiralama
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_rentacar.png?raw=true)
##### Araç Filtreleme
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_carFilter.png?raw=true)
#### İletişim Sayfası
![](https://github.com/batuhanyalin/CarBookProject/blob/master/Frontends/CarBook.WebUI/wwwroot/images/projectScreenshots/ui_contact.png?raw=true)
