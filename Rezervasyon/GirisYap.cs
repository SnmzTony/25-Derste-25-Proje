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

namespace Rezervasyon
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Rezervasyon;Integrated Security=True");
        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeOl fr = new UyeOl();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  Kullanici WHERE (TC = @Kimlik AND Sifre = @Sifre) ", conn);
                cmd.Parameters.AddWithValue("@Kimlik", MskKimlikNo.Text);
                cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Yolcu fr = new Yolcu();
                    fr.kimlik = MskKimlikNo.Text;
                    fr.Show();

                }
                else
                {
                    // Hata durumunda bir mesaj göster
                    MessageBox.Show("Giriş bilgileri geçersiz. Lütfen kontrol edip tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // SqlConnection nesnesini kapatmak için finally bloğunda kullanıyorum
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {

        }
    }
}
