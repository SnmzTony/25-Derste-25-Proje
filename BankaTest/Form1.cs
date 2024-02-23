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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeOl fr=new UyeOl();
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE (KimlikNo = @Kimlik AND Sifre = @Sifre) OR (HesapNo = @HesapNo AND Sifre = @Sifre)", conn);
                cmd.Parameters.AddWithValue("@Kimlik", MskKimlikNo.Text);
                cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                cmd.Parameters.AddWithValue("@HesapNo", MskKimlikNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    Detay fr = new Detay();
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

        private void BtnDovız_Click(object sender, EventArgs e)
        {
            Doviz fr = new Doviz();
            fr.Show();
                    }

        private void BtnKredi_Click(object sender, EventArgs e)
        {
            Kredi fr = new Kredi();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
