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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True");
        public string kimlik;
        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        }
        void kullanıcıadı()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM KullanıcıCek  where  KISIID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", kimlik);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LblKullanıcıAdı.Text = reader[1] + " " + reader[2];
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
        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            durum();
            kullanıcıadı();
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select (AD +' '+ SOYAD) AS ADSOYAD , OGRTID From Tblogretmen where Bransıd=" + CmbDers.SelectedValue, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "ADSOYAD";
            CmbOgretmen.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etüt  Oluşturma İşlemini Gerçekleştirmek İstiyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@Dersid,@Ogretmenid,@tarih,@saat)", conn);
                    cmd.Parameters.AddWithValue("@Dersid", CmbDers.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ogretmenid", CmbOgretmen.SelectedValue);
                    cmd.Parameters.AddWithValue("@tarih", MskTarıh.Text);
                    cmd.Parameters.AddWithValue("@saat", MskSaat.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etüt  Oluşturma İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    etutlistesi();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show("Etüt oluşturm işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void button5_Click(object sender, EventArgs e)
        {
            Duyuru fr = new Duyuru();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Öğrenci Kayıt İşlemini Gerçekleştirmek İstiyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values(@ad,@soyad,@fotograf,@sınıf,@telefon,@mail)", conn);
                    cmd.Parameters.AddWithValue("@ad", TxtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
                    cmd.Parameters.AddWithValue("@fotograf", pictureBox2.ImageLocation);
                    cmd.Parameters.AddWithValue("@sınıf", TxtSınıf.Text);
                    cmd.Parameters.AddWithValue("telefon", MskTelefon.Text);
                    cmd.Parameters.AddWithValue("mail", TxtMail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Kayıt  İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show("Etüt oluşturm işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    };
    }


