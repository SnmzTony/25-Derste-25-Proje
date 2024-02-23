using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTest
{
    public partial class Detay : Form
    {
        public Detay()
        {
            InitializeComponent();
        }
        public string kimlik;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");

        private void Detay_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                LblHesapNo.Text = kimlik;
                SqlCommand cmd = new SqlCommand("Select * From Kullanicilar where  HesapNo=@hesapno", conn);
                cmd.Parameters.AddWithValue("@hesapno", LblHesapNo.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LblAdSoyad.Text = reader[3] + " " + reader[4];
                    LblTC.Text = reader[1].ToString();
                    LblTelefon.Text = reader[5].ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Bağlantıyı kapat
            }

            try { conn.Open(); SqlCommand cmd2 = new SqlCommand("Select * From TBLHESAP Where HESAPNO=@hesapno", conn);
                cmd2.Parameters.AddWithValue("@hesapno", LblHesapNo.Text);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    LblBakiye.Text = reader2[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Bağlantıyı kapat
            }
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            string kimlik;
            kimlik = LblHesapNo.Text;
            DialogResult result = MessageBox.Show("Transfer İşlemini Gerçekleştirmek İstiyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE = BAKIYE + @Tutar WHERE HESAPNO = @Hesap", conn);
                    cmd.Parameters.AddWithValue("@Tutar", decimal.Parse(TxtTutar.Text));
                    cmd.Parameters.AddWithValue("@Hesap", MskHesapNo.Text);

                    SqlCommand cmd2 = new SqlCommand("UPDATE TBLHESAP SET BAKIYE = BAKIYE - @Tutar WHERE HESAPNO = @Hesapno", conn);
                    cmd2.Parameters.AddWithValue("@Hesapno", kimlik);
                    cmd2.Parameters.AddWithValue("@Tutar", decimal.Parse(TxtTutar.Text));
                    SqlCommand cmd4 = new SqlCommand("INSERT INTO TBLHAREKET (GONDEREN,ALICI,TUTAR) values(@gonderıcıhesap,@alıcı,@tutar) ", conn);
                    cmd4.Parameters.AddWithValue("@gonderıcıhesap", LblHesapNo.Text);
                    cmd4.Parameters.AddWithValue("@alıcı", MskHesapNo.Text);
                    cmd4.Parameters.AddWithValue("@tutar", TxtTutar.Text);
                    cmd4.ExecuteNonQuery();
                    if (radioButton1.Checked == true)
                    {
                        SqlCommand cmd3 = new SqlCommand("INSERT INTO TBLHIZLIISLEMLER (GONDEREN, MIKTAR,ALICI) values(@gonderici,@miktar,@alicihesap) ", conn);
                        cmd3.Parameters.AddWithValue("@gonderici", LblHesapNo.Text);
                        cmd3.Parameters.AddWithValue("@alicihesap", MskHesapNo.Text);
                        cmd3.Parameters.AddWithValue("@miktar", TxtTutar.Text);
                        cmd3.ExecuteNonQuery();
                       
                    }
                    else
                    {

                    }

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Transfer İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // Final ile Bağlantıyı kapattım
                }
            }
            else
            {
                MessageBox.Show("Transfer işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gecmis fr=new Gecmis();
            fr.hesap = LblHesapNo.Text;
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HizliIslem fr =new HizliIslem();
            fr.hesaphızlı=LblHesapNo.Text;  
            fr.Show();
        }
    }
}
