<p>Murat Hocamın anlatımıyla pek çok bilgi edindiğim Baştan Sona C# eğitiminden sonra Buradaki Tüm projeleri Tek yapıyorum ve İstediğim şekilde(hayalimdeki gibi işlevselleştiriyorum) Bencede Yazılım öğrenmeyi en iyi şekilde kafandaki yapmak istediğin projeyi yaparken öğreniyorsun, velhasıl kelam çok konuştum. </p>

<p><strong>Projenin İçeriği:</strong> Bir Banka Uygulaması, Murat Hocanın yaptığına benze fakat çok farklı bölümlere de değindim. Bankaya Giriş yaparken İster T.C no ister Hesap no ile giriş yapabiliyorsun. Kayıt olurkende Murat Hoca gibi yapmadım, bana daha mantıklı gelen ve gerçekte de işleyişinin böyle olduğunu düşündüğüm sistemle yaptım. Sql tarafında <strong>Hesap No bir identity bağladım ve başlangıcının "100000" yaptım,</strong> her yeni bir kayıtta da bir bir arttırmasını söylediim.&nbsp; Aynı zamanda <strong>T.C noyu da unique </strong>yaptım bu sayede bir T.C sadece bir kere kayıt yapabiliyor.</p>

<p>Kayıt Ekranında kayıt yapılırken Hesap No vermiyoruz, Kayıt işlemini yapınca bize sırada olan Hesap no veriyor. Zaten giriş için Hesap No gerkemiyor. </p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-21-f7350c584db74ed14d370eaf9c82966c.png"></figure>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-21-0ed3f1a01bc38babe599dc16340b18d1.png"></figure>

<p><br></p>

<p><strong>Uygulamamda Bankalarda olduğu gibi Giriş yapmadan döviz fiyatı öğrenme Kredi hesaplama işlemlerini Giriş yapmadan Gerçekleştirdim. </strong> Faizi %5.7 olunca kredi hesaplayan&nbsp; biraz&nbsp; üzülsede bir şey yapamıyoruz.</p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a_edit/2024-02-14_07-15-59-f5996b76477062427dccb6776d375559.png"></figure>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-21-bd4ab401f4c7e451c190373a27601c2b.png"></figure>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-21-9cfab7bc269aec078b0bf7ee647fba1e.png"></figure>

<p><br></p>

<p>Detay ekranında Kişisel bilgilerini ve Para Transferi İşlemini Gerçekleştiriyoruz, Para Transferi yaparken transfer yaptığımız kişiye çok sıklıkla transfer yapıyorsak her seferinde hesap no neydi diye uğraşmamak için <strong>Hızlı İşlemler butonu ekledim.</strong> <strong>Eğer Hızlı işlemler butonuna tıklayıp daha sonra da transferi gerçekleştirirse, o işlem artık hızlı işlemlere geçiyor</strong>. Daha sonra hızlı işlemler butonuyla erişip tıklayarak otomatik dolduruyor. </p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-22-fa553178e626889ef346e866c2616509.png"></figure>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-22-894edcde608d88a3782a7a309eb42c69.png"></figure>

<p><br></p>

<p>En son bölüm olarakta Geçmiş İşlemler bölümü yaptım. <strong>Burada Transfer işlemini gelen Transfer mi Giden Transfer mi onu görebiliyoruz. </strong></p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-14_06-57-22-34221d892a09bb78e9fc6cc4e1e281ad.png"></figure>

<p><br></p>

<p><br></p>
