Herkese selamlar. Ders videosunda Murat Hocamın yaşadığı teknik aksaklıktan dolayı videonun devamı yüklenmemiş. 

Sorun yok, Biz Murat Yücedağ'ın öğrencileriyiz:)

şaka bir yana tamamlanmış ve eklentileri olan projemizi sizlere sunuyorum.

Ders yarıda kesildiğinden dolayı devamını getiremeyen arkadaşlara yardımcı olmasını dilerim. 

PROJE: Yönetici girişi ve müşteri girişi olarak iki kullanıcı tipi var. 

Giriş kısmı bu şekilde:

Yeni Üye kaydı bu şekilde:

İlk olarak Yolcu Ekranından başlıyacağım göstermeye ve anlatmaya. Yolcu ekranında, kullanıcı tanımlanmış seferleri combobox üzerinde görüp seçebiliyor, saatini tarihini güzergahını seçiyor. 

Yolcu koltuk seçimi kısmına gelince sol tarafta bulunan koltuk butonlarından boş olan koltuğu seçiyor.

Uygulamamızda Seçilmiş koltukları tekrar seçemiyorsunuz, Seçilmiş koltuğu Erkek bir yolcu tarafından mı Kadın bir Yolcu Tarafından mı seçildiğini de görebiliyoruz

ÖRNEK GÖRSEL:

Seçilmiş olan koltuklar hem pasif hale geliyor hemde erkek kadın seçtiğini gösteriyor. 

Kullandığım kod ise Algoritmalı şu şekilde; Bu arada ALGORİTMA HIZ KAZANDIRIR

void KONTROL()

{

    try

    {

        conn.Open();

        SqlCommand cmd = new SqlCommand("Select KoltukNo, Cinsiyet from Rezervasyon where SeferID=@sefer", conn);

        cmd.Parameters.AddWithValue("@sefer", seferID);

        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())

        {

            int koltukNo = Convert.ToInt32(reader["KoltukNo"]);

            int cinsiyet = Convert.ToInt32(reader["Cinsiyet"]);

            // KoltukNo ve Cinsiyet bilgilerine göre ilgili butonun rengini ayarla voidinden çekiyorum

            AyarlaButtonRengi(koltukNo, cinsiyet);

        }

    }

    catch (Exception ex)

    {

        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

    finally

    {

       conn.Close();

    }

}

Burada da rengini, pasifliğini ve Textini  belirliyorum;

private void AyarlaButtonRengi(int koltukNo, int cinsiyet)

{

    string buttonName = "Btn" + koltukNo; // Buton adını oluştur

    // Buton adına göre formdaki butonu bul

    Control[] controls = this.Controls.Find(buttonName, true);

    if (controls.Length > 0 && controls[0] is Button)

    {

        Button button = (Button)controls[0];

        // Cinsiyete göre buton rengini ayarla

        if (cinsiyet == 1)

        {

            button.BackColor =Color.RoyalBlue;

            button.Enabled= false;

            button.Text = "E";

        }

        else if (cinsiyet == 0)

        {

            button.BackColor = Color.HotPink;

            button.Enabled = false;

            button.Text = "K";

            

        }

    }

}

Biz bu butonları renklendirdik textler verdik, ee biz bunları diğer seferde nasıl sıfırlayacağız diye sorular duyuyorum:) 

Bu şekilde;

void temizle()

{

    for (int i = 1; i <= 15; i++)

    {

        string buttonName = "Btn" + i;

        Control[] controls = this.Controls.Find(buttonName, true);

        if (controls.Length > 0 && controls[0] is Button)

        {

            Button button = (Button)controls[0];

            button.BackColor = Color.FromArgb(76, 175, 80);

            button.Enabled = true;

            button.Text = i.ToString();

        }

    }

}

Yolcu Ekranında Son Kısım Müşteri Temsilcisiyle Mesajlaşma;

 Herhangi bir sorunu olduğunda Müşteri Temsilcisine soru sorabiliyoruz

Müşteri Temsilcisini Gördüğü:

Gelelim Yönetim Ekranına:

Koltuk kısımları vs... aynı zaten. Ekstraları Sefer oluşturabiliyorsun, Şoför oluşturabiliyorsun. Çağrı merkezini cep telefonuyla arayan hesabı olmayan müşteriye rezervasyon yapabiliyorsun.  DatagridView tıklayınca değerler otomatik geçiyor.


UMARIM SONUNA KADAR OKUMUŞSUNUZDUR. 