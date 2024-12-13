# 💻 Asp.Net Core Api 8.0 Onion Architecture ile CarBook Projesi
📢 Murat YÜCEDAĞ' ın udemyde sunduğu 313 Ders 38.5 saatlik Asp.Net Core Api 8.0 Onion Architecture ile CarBook Projesi eğitimi kapsamında geliştirmiş olduğum proje API, RESTful API, CQRS ve Mediator Design Patterns ve Onion Architecture konularını kavramamı sağladı. 

## 🪶 Projenin Amacı;
Proje bir araç kiralama uygulamasıdır. Kullanıcılar lokasyona göre araçları filtreleyebilir ve seçilen araçlar için rezervasyon oluşturabilirler. Bununla birlikte blogları görüp okuyabilir, etiket sistemine, yazarlara ve kategorilere göre bloglarda listeleme yapabilmektedirler. Okudukları bloglara ve aldıkları araca yorum yapabilmektedirler. İletişim formundan sistem yöneticisine mesaj atabilmektedir. Bununla birlikte güçlü bir yönetim arayüzü olan uygulamada bütün bu sistem rol bazlı yönetim sistemiyle kontrol edilmektedir.

## 🛠️ Kullanılan Bazı Teknolojiler
* 🌟 Onion Architecture mimarisiyle ve 
* ✨ Proje CQRS ve Mediator design patterns üzerine kuruldu.
* 🌟 DbCodeFirst ile MSSQL veritabanı oluşturulup yönetimi sağlandı.
* ✨ Entity Framework 8.0 Veritabanı etkileşimi ve ORM için kullanıldı.
* 🌟 JWT Token ile süre bazlı token oluşturup POSTMAN ile testleri yapıldı.
* ✨ SignalR ile anlık veri güncellemesi sistemi projeye dahil edilmiştir.
* 🌟 Üyelik sistemi Jwt ile kontrol edilip rol bazlı yetkilendirme sağlanmıştır.
* ✨ Bütün proje RESTful API' larla bütün CRUD işlemlerini yapabilir şekilde oluşturuldu.
* 🌟 Proje Admin adlı bir Area vardır ve ana ekrandan ayrılmaktadır. 
* ✨ Bütün proje SOLID prensipleriyle ve folder structure yapısıyla oluşturuldu.
* 🌟 DTO katmanıyla veri yönetimi kolaylaştırıldı.
* ✨ HTML-CSS Bootstrap ile arayüzler tasarlandı.
* 🌟 Fluent Validation - kontrol sistemi kullanılarak veirlerin belli kurallara göre alınması sağlandı.
* ✨ Area sistemiyle paneller birbirinden ayrılıp yönetimi kolaylaştırıldı.
* 🌟 Projede bol bol iç içe layout ve ViewComponent yapısı kullanıldı.
* ✨ Linq sorguları


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
