using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Rezervasyon;Integrated Security=True");
      
        
        void Soforcek()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select (Ad+' '+Soyad) AS ADSOYAD,SoforId From Sofor", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbKaptan.ValueMember = "SoforID";
            CmbKaptan.DisplayMember = "ADSOYAD";
            CmbKaptan.DataSource = dt;
        }

        void SeferCek()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SeferView;", conn);
            DataTable dt = new DataTable(); dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try { conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Sefer (KalkisYeri,VarisYeri,Tarih,Saat,SoforId,Fiyat) values(@kalkis,@varis,@tarih,@saat,@sofor,@fiyat)", conn);
                cmd.Parameters.AddWithValue("@kalkis", CmbKalkis.Text);
                cmd.Parameters.AddWithValue("@varis", CmbVaris.Text);
                cmd.Parameters.AddWithValue("@tarih", MskTarih.Text);
                cmd.Parameters.AddWithValue("@saat", MskSaat.Text);
                cmd.Parameters.AddWithValue("@sofor", CmbKaptan.SelectedValue);
                cmd.Parameters.AddWithValue("@fiyat",TxtFiyat.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sefer Kaydı Başarıyla Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            }
            
            
            catch (Exception ex) { MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                conn.Close();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Sofor(Ad,Soyad,Tc,TelefonNumarasi) values(@ad,@soyad,@tc,@tel)", conn);
                cmd.Parameters.AddWithValue("@ad", TxtSoforAd.Text);
                cmd.Parameters.AddWithValue("@soyad", TxtSoforSoyad.Text);
                cmd.Parameters.AddWithValue("@tc", MskSoforTC.Text);
                cmd.Parameters.AddWithValue("@tel", MskSoforTel.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            catch (Exception ex) { MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                conn.Close();
                SeferCek();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Soforcek();
            SeferCek();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            CmbSefer.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString() + "-" + dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            CmbTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label19.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "9";

        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "10";

        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "11";

        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "12";

        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "13";

        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "14";

        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "15";

        }
        
        void KONTROL()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select KoltukNo, Cinsiyet from Rezervasyon where SeferID=@sefer", conn);
                cmd.Parameters.AddWithValue("@sefer", label19);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int koltukNo = Convert.ToInt32(reader["KoltukNo"]);
                    int cinsiyet = Convert.ToInt32(reader["Cinsiyet"]);

                    // KoltukNo ve Cinsiyet bilgilerine göre ilgili butonun rengini ayarla
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
                    button.BackColor = Color.RoyalBlue;
                    button.Enabled = false;
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

        private void button19_Click(object sender, EventArgs e)
        {
            YonetimMesajlar fr=new YonetimMesajlar();
            fr.Show();
        }
    }
}
