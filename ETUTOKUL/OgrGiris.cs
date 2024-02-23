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
namespace ETUTOKUL
{
    public partial class OgrGiris : Form
    {
        public OgrGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True");
        public string kimlik;
        string ad;
        string soyad;
        void kullanıcıadı()
        {
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM KullanıcıCek  where  KISIID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", kimlik);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LblKullanıcıAdı.Text = reader[1] + " " + reader[2];
                ad = reader[1].ToString();
                soyad = reader[2].ToString();
            }
            conn.Close();
        }
        void etutlistesi()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXEC sp_GetEtutListesi;", conn);
            DataTable dt3 = new DataTable(); dataAdapter.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void durum()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update TBLKISI SET Durum=1 WHERE KISIID=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", kimlik); ;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        void bilgigetir()
        {
            try
            {
                conn.Open();
                LblOgrenciAd.Text = LblKullanıcıAdı.Text;
                SqlCommand cmd = new SqlCommand("Select * From TBLOGRENCI where OGRID=@ogrıd", conn);
                cmd.Parameters.AddWithValue("@ogrıd", kimlik);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LblOgrenciAd.Text =ad;
                    LblSoyad.Text =soyad;
                    LblSınıf.Text = reader[4].ToString();
                    LblTelefon.Text = reader[5].ToString();
                    LblMail.Text= reader[6].ToString();
                    pictureBox2.ImageLocation = reader[3].ToString();
                    
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
        private void OgrGiris_Load(object sender, EventArgs e)
        {
           
            etutlistesi();
            durum();
            kullanıcıadı();
            bilgigetir();
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mesaj fr = new Mesaj();
            fr.kisiiyim = kimlik;
            fr.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Durumu 0 yapacak güncelleme sorgusu
            SqlCommand cmd = new SqlCommand("UPDATE TBLKISI SET Durum = 0 WHERE KISIID = @P1", conn);
            cmd.Parameters.AddWithValue("@P1", kimlik);


            cmd.ExecuteNonQuery();
            conn.Close();
            Application.Exit();
        }
         String ID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtOgretmenAdı.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtDersAdı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskTarıh.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskSaat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            ID= dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TBLETUT SET OGRENCIID=@P1, DURUM=1 WHERE ID=@P2", conn);
                cmd.Parameters.AddWithValue("@P1", kimlik);
                cmd.Parameters.AddWithValue("@P2", ID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Etüt Alma İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Duyuru fr=new Duyuru();
            fr.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Mesaj fr = new Mesaj();
            fr.kisiiyim = kimlik;
            fr.Show();
        }
    }
}

