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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ETUTOKUL
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True");


        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGirisYap_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  TBLKISI WHERE (KISIID = @Kimlik AND SIFRE = @Sifre) ", conn);
                cmd.Parameters.AddWithValue("@Kimlik", TxtKisiId.Text);
                cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    OgrGiris fr = new OgrGiris();
                    fr.kimlik = TxtKisiId.Text;
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
    }
}
