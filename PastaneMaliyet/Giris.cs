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

namespace PastaneMaliyet
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Pastane;Integrated Security=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try { conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Kasiyer Where (KASIYERID=@ID AND SIFRE =@Sifre)", conn);
                cmd.Parameters.AddWithValue("@ID", MskKimlikNo.Text);
                cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                
                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.Read())
                {
                    Satis fr = new Satis();
                    fr.kimlik = MskKimlikNo.Text;
                    fr.Show();
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
    }
}
