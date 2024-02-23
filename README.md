<p>Merhabalar. 25 Derste 25 Projenin son büyük projesi Pastane uygulumasını sizlere sunuyorum.</p>

<p>Uygulamamı genel olarak bir açıklayayım. Uygulamada Üretim ,takip ve satış işlemlerini gerçekleştiryoruz. </p>

<p><strong>Ürün kısmı benim açımdan çok değerli bir kısım oldu, Sql tarafında büyük işler çevirdim.(detaylar o kısımda)</strong></p>

<p>Pastane giriş ekranıyla başlayalım.&nbsp; id ve şifreyle giriş yapılıyoor.</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-09-753303b018277b7d91e9ef8d9e879fc5.png"></figure>

<p><br></p>

<p>Kasiyerleri böyle bir ekran karşılıyor</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-09-e1a068a9c8185799669110f23af27b2f.png"></figure>

<p><br></p>

<p>Kasiyer bu ekranda satış işlemlerini gerçekleştirebiliyor, Sol tarafda gözüken ListBoxtan Ürünleri ve stokları görüyor, Stokları azalmış ürünleri Üretim İste butonuyla üretim tarafına bildiriyor.&nbsp; &nbsp;</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-09-28eef7c82886eb35393021c3b4d564fc.png"></figure>

<p><br></p>

<p>Daha büyük ekran olan Üretim Ekranına Geçelim.</p>

<p>Üretim Ekranı Bizi böyle karşılıyor.&nbsp; </p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-09-b4bd337de0df7cc784b9d3a099f5c778.png"></figure>

<p><br></p>

<p>Malzeme Giriş kısmı Murat hocamkine benzer. ama <strong>Ürün oluşturma ve Fiyat güncelleme çok farklı.</strong></p>

<p>Ürün oluşturma kısmında Comboboxtan ürünlerimizi seçiyoruz ve adetimizi seçiyoruz. Maliyet otomatik geldi.&nbsp; <strong>Bu nasıl oluyor diye soruyorsunuz</strong>.&nbsp; Sql tarafında iş dönüyor.&nbsp; Şu şekilde açıklıyayım;</p>

<p>Malzeme tablomuzda öncellikle malzemelerimizi ve fiyatlarımızı stoklarımızı belirledik.</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-09-34dbe2b3f9ab3571c38b724f0c1015e9.png"></figure>

<p>Ürün malzeme tablosu diye bir tablo oluşturdum. Bu tabloda Gerçek ERP projelerinde de kullanılan Ürün Kartı mantığıyla işlem yaptım. </p>

<p>Kek ürünün baz alalım. Kek için gerekli olan malzemeler örnek olarak; 2 paket un , 1paket şeker, 3 yumurta ve 1 kabartma tozu. </p>

<p>Bu verileri tablomuza ekliyoruz. Artık KEK ürünün Ürün Kartı Oluştu.</p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-09-58c7d5533d183e034f3dd3b6bc78ea51.png"></figure>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-10-16bb58bb476ef4a030a161c488fd064c.png"></figure>

<p>Artık Ürünlerimizin Ürün Kartı tamamlandı.</p>

<p><strong>Şimdi Kafamızdaki Diğer soru</strong></p>

<p>1.Ben ürünlerin maliyetini nasıl oluşturacağım</p>

<p><strong>Bu sorunun cevabı bir Sql sorgusu, İşte o Sql sorgusu;</strong></p>

<p>UPDATE URUN</p>

<p>SET MALIYET = (</p>

<p>&nbsp; &nbsp; SELECT SUM(M.FIYAT * UM.Adet) </p>

<p>&nbsp; &nbsp; FROM UrunMalzemeTablosu UM</p>

<p>&nbsp; &nbsp; INNER JOIN MALZEME M ON UM.MALZEMEID = M.MALZEMEID</p>

<p>&nbsp; &nbsp; WHERE UM.UrunID = URUN.UrunID</p>

<p>)</p>

<p>Bunu bir Trigger haline getirdim. Eğer Malzeme Tarafında Herhangi bir Fiyat değişimi olursa tekrar tetikleniyor. Artık Ürün tarafında Malzemeleriyle vs... işlemimiz kalmıyor:)</p>

<p><strong>eee şimdi ben bu ürünü oluşturduğum zaman Malzememdeki stok nasıl düşecek?</strong></p>

<p>Şimdi üretim ekranındaki Üret butonuna tıklayınca yaptığımız işlemleri veriyorum:</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-10-02991748717d04c0da6739a6cb149aad.png"></figure>

<p>Stok düşürmek için kullandığım Sql sorgum: UPDATE MALZEME SET Stok = Stok - (UM.Adet * @UretimMiktar) FROM UrunMalzemeTablosu UM INNER JOIN MALZEME MST ON UM.MalzemeID = MST.MalzemeID WHERE UM.UrunID = @UrunID</p>

<p><br></p>

<p>Stok kısmını da ayarladığımıza göre: Şimdi Ürettiğimiz Ürünlere satış fiyatı da verelim:</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-10-ceaaaa4cacb59834c31359e6e0a44ccb.png"></figure>

<p>Güncelleme tarafında zaten sadece Fiyat kısmı Değiştrilebilir diğer taraflar readonly durumunda.</p>

<p><br></p>

<p>Hareket Butonuna tıklayınca Hareket ekranımız açılıyor. Bu ekranda Yapılan satışları izliyebiliyoruz. Hangi kasiyer hangi üründen kaç adet sattı gibi.</p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-22_17-18-10-da8ac475adb29f2c9ed11dc03af34967.png"></figure>

<p><br></p>

<p>Uygulama genel hatlarıyla bu şekilde, Kod tarafında sormak istediğiniz, öğrenmek istdeğiniz her ne olursa cevaplamaya hazırım. </p>

<p>Yazıları biraz uzun yazıyorum, Uygulamanın Daha net ve kolay anlaşılması açısından. </p>

<p>Murat Hocam' verdiği bilgiler için&nbsp; kucak dolusu sevgilerimi iletiyorum:)</p>

<p>Esenlikler Dilerim Herkese....</p>