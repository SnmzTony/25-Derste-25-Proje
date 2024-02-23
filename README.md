<p>Öncellikle Murat Hocama Teşekkürle başlıyorum.&nbsp; Bu projede Sql Tarafında kendimi daha da geliştirdiğimi düşünüyorum. Nacizane tavsiyem hayal gücünüzle(programda neler olmasını istiyorsanız) düşünün ve bunu yapmaya çalışın, O arada yeni bakış açıları keşfediyorsunuz ve yazılıma hakim oluyorsunuz. </p>

<p>Gelelim Projeme:)</p>

<p>Öncellikle Projemde ben Öğrenci ve Öğretmen girişi olarak iki farklı giriş sundum. </p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-25-2c4535ee6d0bff5c477cfc1becb1a6a2.png"></figure>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-25-e2c57f762c43f0066ab50f39fd3083b5.png"></figure>

<p><br></p>

<p><br></p>

<p>Tbl Öğrenciler ve TblÖğretmenler olarak iki tablo oluşturdum, Genel bilgilerini bu tabloda tuttum. </p>

<p>Giriş bilgileri ve birazdan anlatacağım mesajlaşma için TBLKISI adında bir tablo daha oluştrudum.</p>

<p>Girerken Öğrenci kendi ID ve şifresiyle Öğretmende Kkendi ıd ve şlifrsiyle giriyor. </p>

<p><strong>Uygulamya giriş yapınca Öğretmeni böyle bir Ekran Karşılıyor</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-25-88890ed25990d2fd6d6f1f0ae0635dd6.png"></figure>

<p><strong>Öğrencileri de Böyle bir Ekran;</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-25-b62a4528db5dc241e9784e6930f51d81.png"></figure>

<p><br></p>

<p>Öğretmen Ekranında Yeni bir Etüt tanımlanıyor ve Yeni bir öğrenci tanımlanabiliyor.&nbsp; <strong>Aktif Etütler Tablosunda gördüğünüz gibi</strong> <strong>DERS DURUMU kısmı var. Burayı SQL sayesinde yazdım. Aslında veri tipi bit olan durum satırıydı.&nbsp; &nbsp;</strong></p>

<p><strong>SQL SORGUM BU ŞEKİLDE "</strong> SELECT D.ID, B.DERSAD, (A.AD + ' ' + A.SOYAD) AS 'ÖĞRETMEN', (C.AD + ' ' + C.SOYAD) AS 'ÖĞRENCİ', D.TARIH, D.SAAT,CASE WHEN D.DURUM=1 THEN 'ALINMIŞ DERS' ELSE 'BOŞ DERS' END AS'DERS DURUMU'</p>

<p>&nbsp; &nbsp; FROM TBLETUT D</p>

<p>&nbsp; &nbsp; LEFT JOIN TBLDERSLER B ON B.DERSID = D.DERSID</p>

<p>&nbsp; &nbsp; LEFT JOIN TBLOGRETMEN A ON A.OGRTID = D.OGRETMENID</p>

<p>&nbsp; &nbsp; LEFT JOIN TBLOGRENCI C ON C.OGRID = D.OGRENCIID;<strong>"</strong></p>

<p><br></p>

<p>Önemli bir yer olan Mesajlaşma Kısmına Gelelim:</p>

<p>Burada Mesaj kısmına girince <strong>mesajlaşacağın kişinin Çevrim içi mi Çevrim dışı mı olduğunu Görebiliyoruz</strong></p>

<p>Mesajları DataGridView de görmek istemedim onun yerine ListBox kullandım. </p>

<p><strong>Okunmamış Mesaj sayımıda Görebiliyorum.&nbsp; &nbsp;</strong>Bunuda Mesaj tablosuna Durum ekledim eklediğim durum veri tipi bit. veri default olarak 0 gidiyor. 0 giden veri Tablomda Gönderildi olarak düşürüyorum ve Mesaj Akan kişi mesajı görüp tıklama işlemi yapana kadar&nbsp; Okunmamış Mesaj Kısmında duruyor. </p>

<p>Uygulamaya Giriş yaptığında Çevrimiçi gözüken durumu, Çıkış yapıncada aynı şekilde çevrim dışı oluyor. </p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-25-791a2e20f2d5f960314420b10a51ae6e.png"></figure>

<p><br></p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-25-3f464ba8b2ec1b7ca6d19f3aeb9feedb.png"></figure>

<p><br></p>

<p><strong>BU DA ÇEVRİM DIŞI OLDUĞU DURUM</strong></p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a_edit/2024-02-15_20-39-51-14d4c02c3a42c6e757f611b46edea533.png"></figure>

<p><br></p>

<p>Öğrenci Ekranına tekrar gelecek olursak Öğrenci buradan Mesjalaşabiliyor, gelen duyuruları görüyor ve Etüte kayıt olabiliyor.&nbsp; </p>

<p><strong>DUYURU EKRANI ÖĞRETMEN TARAFI</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-26-3597445fb0e6592ef46970fbfd7297d1.png"></figure>

<p><br></p>

<p><strong>Etüt Kayıtı </strong></p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-26-f34f0d49006a8f9bc962394d710bdc5e.png"></figure>

<p><br></p>

<p><strong>Öğretmen Ekranında Öğrenci kayıt kısmı</strong></p>

<p>Öğrenci kayıt yapmadan önce ön onay </p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-26-8991cef376eef20cc0c1f60ffb2114d7.png"></figure>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-15_20-35-26-b1aee00b2bd5c3f1e899e1ecde70829c.png"></figure>

<p><br></p>

<p>Sql tarafında da büyük yoğunluğu var tabi triggerlar , viewler diagramlar derken aslında işin büyük bir kısmında Sql tarafında dönüyor. </p>

<p><br></p>

<p><strong>UMARIM AÇIKLAYICI VE BİLGİLENDİRİC OLMUŞTUR.</strong></p>

<p><br></p>