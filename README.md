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
![Veritabanı](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/database.png?raw=true)
### Giriş
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/login.png?raw=true)
### Yeni Üyelik
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/register.png?raw=true)

### Yönetim Paneli
#### Dashboard
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/dashboard.png?raw=true)
###### Dashboard
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/dashboardMessageNotification.png?raw=true)
#### Mesajlar
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/message.png?raw=true)
###### Mesaja Yanıt
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/answerMessage.png?raw=true)
###### Mesaj Kategorileri
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/messageCategory.png?raw=true)
#### Rezervasyonlar
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/reservationList.png?raw=true)
###### Rezervasyon Güncelleme
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/reservationUpdate.png?raw=true)
#### Ekip Listesi
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/staffList.png?raw=true)
###### Ekip Çalışan Güncelleme
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/staffUpdate.png?raw=true)
#### Kullanıcı Listesi
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/userList.png?raw=true)
###### Kullanıcı Güncelleme
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/userUpdate.png?raw=true)
#### Oda Listesi
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/roomList.png?raw=true)
#### Mail Aboneliği 
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/subscribeList.png?raw=true)
#### Rol Listesi
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/roleList.png?raw=true)
#### Hakkında
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/aboutUpdate.png?raw=true)
#### Dosya Yükleme
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/fileUpload.png?raw=true)

#### Ana Ekran
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/defaultPage.png?raw=true)
######
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/defaultPage2.png?raw=true)
######
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/footer.png?raw=true)
######
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/aboutPage.png?raw=true)
#### Rezervasyon Sayfası
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/reservationPage.png?raw=true)
#### Oda Sayfası
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/roomPage.png?raw=true)
#### Hizmet Sayfası
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/servicePage.png?raw=true)
#### Ekip Sayfası
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/staffPage.png?raw=true)
#### Referans Sayfası
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/testimonialPage.png?raw=true)
#### İletişim Sayfası
![](https://github.com/batuhanyalin/HotelApiProject/blob/master/Frontend/HotelApiProject.WebUI/wwwroot/images/projectScreenshots/contactPage.png?raw=true)
