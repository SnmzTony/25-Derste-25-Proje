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


namespace Rezervasyon
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Rezervasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string cinsiyet = CmbCinsiyet.SelectedItem.ToString();
            int cinsiyetDurumu = (cinsiyet == "ERKEK") ? 1 : 0;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Kullanici (Ad,Soyad,TC,Sifre,Cinsiyet,Mail,TelefonNumarasi) values(@ad,@soyad,@tc,@sifre,@cinsiyet,@mail,@tel)", conn);
                cmd.Parameters.AddWithValue("@ad", TxtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
                cmd.Parameters.AddWithValue("@tc", MskTC.Text);
                cmd.Parameters.AddWithValue("@sifre", TxtSifre.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyetDurumu);
                cmd.Parameters.AddWithValue("@mail", TxtMail.Text);
                cmd.Parameters.AddWithValue("@tel", MskTel.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
