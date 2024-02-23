<p>Herkese selamlar. Ders videosunda Murat Hocamın yaşadığı teknik aksaklıktan dolayı videonun devamı yüklenmemiş. </p>

<p>Sorun yok, Biz Murat Yücedağ'ın öğrencileriyiz:)</p>

<p>şaka bir yana tamamlanmış ve eklentileri olan projemizi sizlere sunuyorum.</p>

<p><strong>Ders yarıda kesildiğinden dolayı devamını getiremeyen arkadaşlara yardımcı olmasını dilerim. </strong></p>

<p>PROJE: Yönetici girişi ve müşteri girişi olarak iki kullanıcı tipi var. </p>

<p><strong>Giriş kısmı bu şekilde:</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-5b2bf1f9f3853d68a0cf5bd813191ac9.png"></figure>

<p><strong>Yeni Üye kaydı bu şekilde:</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-a6224024a6c5ea70e027e8d048543a9d.png"></figure>

<p><br></p>

<p>İlk olarak Yolcu Ekranından başlıyacağım göstermeye ve anlatmaya. Yolcu ekranında, kullanıcı tanımlanmış seferleri combobox üzerinde görüp seçebiliyor, saatini tarihini güzergahını seçiyor. </p>

<p>Yolcu koltuk seçimi kısmına gelince sol tarafta bulunan koltuk butonlarından boş olan koltuğu seçiyor.</p>

<p><strong>Uygulamamızda Seçilmiş koltukları tekrar seçemiyorsunuz, Seçilmiş koltuğu Erkek bir yolcu tarafından mı Kadın bir Yolcu Tarafından mı seçildiğini de görebiliyoruz</strong></p>

<p><strong>ÖRNEK GÖRSEL:</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-f270eeae748dc1f81061e3690feea7a6.png"></figure>

<p>Seçilmiş olan koltuklar hem pasif hale geliyor hemde erkek kadın seçtiğini gösteriyor. </p>

<p><br></p>

<p>Kullandığım kod ise Algoritmalı şu şekilde; <strong>Bu arada ALGORİTMA HIZ KAZANDIRIR</strong></p>

<p>void KONTROL()</p>

<p>{</p>

<p>&nbsp; &nbsp; try</p>

<p>&nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; conn.Open();</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; SqlCommand cmd = new SqlCommand("Select KoltukNo, Cinsiyet from Rezervasyon where SeferID=@sefer", conn);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; cmd.Parameters.AddWithValue("@sefer", seferID);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; SqlDataReader reader = cmd.ExecuteReader();</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; while (reader.Read())</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; int koltukNo = Convert.ToInt32(reader["KoltukNo"]);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; int cinsiyet = Convert.ToInt32(reader["Cinsiyet"]);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; // KoltukNo ve Cinsiyet bilgilerine göre ilgili butonun rengini ayarla voidinden çekiyorum</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; AyarlaButtonRengi(koltukNo, cinsiyet);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; }</p>

<p>&nbsp; &nbsp; }</p>

<p>&nbsp; &nbsp; catch (Exception ex)</p>

<p>&nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);</p>

<p>&nbsp; &nbsp; }</p>

<p>&nbsp; &nbsp; finally</p>

<p>&nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp;conn.Close();</p>

<p>&nbsp; &nbsp; }</p>

<p>}</p>

<p><strong>Burada da rengini, pasifliğini ve Textini&nbsp; belirliyorum;</strong></p>

<p>private void AyarlaButtonRengi(int koltukNo, int cinsiyet)</p>

<p>{</p>

<p>&nbsp; &nbsp; string buttonName = "Btn" + koltukNo; // Buton adını oluştur</p>

<p><br></p>

<p>&nbsp; &nbsp; // Buton adına göre formdaki butonu bul</p>

<p>&nbsp; &nbsp; Control[] controls = this.Controls.Find(buttonName, true);</p>

<p><br></p>

<p>&nbsp; &nbsp; if (controls.Length &gt; 0 &amp;&amp; controls[0] is Button)</p>

<p>&nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; Button button = (Button)controls[0];</p>

<p><br></p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; // Cinsiyete göre buton rengini ayarla</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; if (cinsiyet == 1)</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.BackColor =Color.RoyalBlue;</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.Enabled= false;</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.Text = "E";</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; }</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; else if (cinsiyet == 0)</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.BackColor = Color.HotPink;</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.Enabled = false;</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.Text = "K";</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; }</p>

<p>&nbsp; &nbsp; }</p>

<p>}</p>

<p><strong>Biz bu butonları renklendirdik textler verdik, ee biz bunları diğer seferde nasıl sıfırlayacağız diye sorular duyuyorum:) </strong></p>

<p><strong>Bu şekilde;</strong></p>

<p>void temizle()</p>

<p>{</p>

<p>&nbsp; &nbsp; for (int i = 1; i &lt;= 15; i++)</p>

<p>&nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; string buttonName = "Btn" + i;</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; Control[] controls = this.Controls.Find(buttonName, true);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; if (controls.Length &gt; 0 &amp;&amp; controls[0] is Button)</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; {</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Button button = (Button)controls[0];</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.BackColor = Color.FromArgb(76, 175, 80);</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.Enabled = true;</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; button.Text = i.ToString();</p>

<p>&nbsp; &nbsp; &nbsp; &nbsp; }</p>

<p>&nbsp; &nbsp; }</p>

<p>}</p>

<p><br></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-fc02c72ef475127c99b384252a8e7c99.png"></figure>

<p><br></p>

<p>Yolcu Ekranında Son Kısım <strong>Müşteri Temsilcisiyle Mesajlaşma;</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-e0b4a6133956d3af4e1e1a58e8818fb9.png"></figure>

<p> <strong>Herhangi bir sorunu olduğunda Müşteri Temsilcisine soru sorabiliyoruz</strong></p>

<p><strong>Müşteri Temsilcisini Gördüğü:</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-5138512905ce176c211efcc9f2b53611.png"></figure>

<p><br></p>

<p><strong>Gelelim Yönetim Ekranına:</strong></p>

<figure><img src="https://img-c.udemycdn.com/redactor/raw/q_and_a/2024-02-19_13-30-34-6a3b908b4a8be5fa26c1e5aa331a1da4.png"></figure>

<p>Koltuk kısımları vs... aynı zaten. Ekstraları Sefer oluşturabiliyorsun, Şoför oluşturabiliyorsun. Çağrı merkezini cep telefonuyla arayan hesabı olmayan müşteriye rezervasyon yapabiliyorsun.&nbsp; DatagridView tıklayınca değerler otomatik geçiyor.</p>

<p><br></p>


<p><strong>UMARIM SONUNA KADAR OKUMUŞSUNUZDUR.&nbsp; 

<p><strong>Esenlikle Kalın...</strong></p>
