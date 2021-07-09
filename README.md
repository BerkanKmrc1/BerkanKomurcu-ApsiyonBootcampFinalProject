# Proje İsterleri
Bir sitede yöneticisiniz
sitenizde yer alan dairelerin aidat ve ortak kullanım elektrik, su ve doğalgaz faturalarının yönetimini bir sistem üzerinden yapacaksınız.

İki tip kullanıcınız var 
1-Admin/Yönetici
 --- Daire bilgilerini girebilir.
 --- İkamet eden kullanıcı bilgilerini girer.
 18 --- Daire başına ödenmesi gereken aidat ve fatura bilgilerini girer(Aylık olarak). Toplu veya tek tek atama yapılabilir.
 19 --- Gelen ödeme bilgilerini görür.
 20 --- Gelen mesajları görür.
 21 --- Aylık olarak borç-alacak listesini görür.
 22 --- Kişileri listeler, düzenler, siler.
 23 --- Daire/konut bilgilerini listeler, düzenler siler.
2-Kullanıcı
 24 --- Kendisine atanan fatura ve aidat bilgilerini görür.
 25 --- Kredi kartı ile ödeme yapabilir.
 26 --- Yöneticiye mesaj gönderebilir.

Daire/Konut bilgilerinde
 --- Hangi blokda
 --- Durumu (Dolu-boş)
 --- Tipi (2+1 vb.)
 --- Bulunduğu kat
 --- Daire numarası
 --- Daire sahibi veya kiracı 

Kullanıcı bilgilerinde
 --- Ad-soyad
 --- TCNo
 --- E-Mail
 --- Telefon
 --- Araç bilgisi(varsa plaka no)

-----------------------------------------------------------------------------
Sistem kullanılmaya başladığında ilk olarak
1.Yönetici daire bilgilerini girer.
2.Kullanıcı bilgilerini girer.Giriş yapması için otomatik olarak bir şifre oluşturulur.
3.Kullanıcıları dairelere atar
4.Ay bazlı olarak aidat bilgilerini girer.
5.Ay bazlı olarak fatura bilgilerini girer


Proje .NET CORE MVC teknolojisiyle geliştirilmiştir.Projede Code FİRST, Entity Framework, MSSQL JWT, IdentityCore, MongoDb, Dependency İnjection, UnitOfWork gibi teknolojiler, toollar ve design patternlar kullanılmıştır.
