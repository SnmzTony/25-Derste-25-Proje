using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTest
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Kullanıcı bilgilerini ekleyen SQL komutu
                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar (KimlikNo, Sifre, Ad, Soyad, Telefon) VALUES (@KimlikNo, @Sifre, @Ad, @Soyad, @Telefon)", conn);
                cmd.Parameters.AddWithValue("@KimlikNo", MskTC.Text);
                cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                cmd.Parameters.AddWithValue("@Ad", TxtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
                cmd.Parameters.AddWithValue("@Telefon", MskTel.Text);
                cmd.ExecuteNonQuery();

                // Eklenen kaydın HesapNo değerini getirmek içim SQL sorgusu
                SqlCommand cmd2 = new SqlCommand("SELECT HesapNo FROM Kullanicilar WHERE KimlikNo = @KimlikNo", conn);
                cmd2.Parameters.AddWithValue("@KimlikNo", MskTC.Text);

                // HesapNo değerini almak için SqlDataReader kullanıyorum
                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    // HesapNo değerini MessageBox ile gösteriyorum
                    string hesapNo = reader["HesapNo"].ToString();
                    MessageBox.Show("Kayıt İşlemi Başarılı\nHesap No: " + hesapNo, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close(); // SqlDataReader kapattım
                conn.Close(); // SqlConnection kapatıtıp
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
