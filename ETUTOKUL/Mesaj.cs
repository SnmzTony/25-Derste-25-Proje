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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ETUTOKUL
{
    public partial class Mesaj : Form
    {
        public Mesaj()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True");
        public string kisiiyim;
        void kisilistesi()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("exec kisigetir;", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbKisi.ValueMember = "ID";
            CmbKisi.DisplayMember = "ADSOYAD";
            CmbKisi.DataSource = dt;
            
          
        }
        void allmesaj()
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Mesaj FROM TBLMESAJLAR where  ALICIID=@P1 ", conn);
            cmd2.Parameters.AddWithValue("@P1", kisiiyim);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mesajlarım.DisplayMember = "Mesaj";
            Mesajlarım.ValueMember = "Mesaj";
            Mesajlarım.DataSource = table;
            conn.Close();
        }
        void mesajcek()
        {
            string kisiid;
            kisiid = CmbKisi.SelectedValue.ToString();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Mesaj FROM TBLMESAJLAR where GONDERENID=@P1 and ALICIID=@P2 ", conn);
            cmd2.Parameters.AddWithValue("@P2", kisiiyim);
            cmd2.Parameters.AddWithValue("@P1", kisiid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mesajlarım.DisplayMember = "Mesaj";
            Mesajlarım.ValueMember = "Mesaj";
            Mesajlarım.DataSource = table;
            conn.Close();
        }
        void okunmamismesaj()
        {
            string kisiid;
            kisiid = CmbKisi.SelectedValue.ToString();
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(DURUM) FROM TBLMESAJLAR where ALICIID=@P1", conn);
            cmd5.Parameters.AddWithValue("@P1", kisiiyim);
            SqlDataReader reader = cmd5.ExecuteReader();
            while (reader.Read())
            {
                 
               LblOkunmamisMesaj.Text= reader[0].ToString();
            }
            conn.Close();
        }

        private void Mesaj_Load(object sender, EventArgs e)
        {
            kisilistesi();
            allmesaj();
            okunmamismesaj();

        }

        private void CmbKisi_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.Open();
            string kisiid;
            kisiid = CmbKisi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("SELECT DURUM, CASE WHEN DURUM=1 THEN 'Çevrim İçi' ELSE 'Çevrim Dışı' END AS'AKTİFLİK DURUMU' FROM TBLKISI WHERE KISIID=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", kisiid);
            SqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                string durumText = reader2[1].ToString();
                LblDurum.Text = durumText;

                // durumText değerine bağlı olarak rengi ayarla
                if (durumText == "Çevrim İçi")
                {
                    LblDurum.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    LblDurum.ForeColor = System.Drawing.Color.Red;
                }
            }
            conn.Close();
            okunmamismesaj();
            mesajcek();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string kisiid;
                kisiid = CmbKisi.SelectedValue.ToString();
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TBLMESAJLAR (MESAJ, GONDERENID, ALICIID, DURUM) VALUES (@mesaj, @gondericiid, @aliciid, @durum)", conn);
                cmd.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@gondericiid", kisiiyim);
                cmd.Parameters.AddWithValue("@aliciid", kisiid);
                cmd.Parameters.AddWithValue("@durum", 0);
                cmd.ExecuteNonQuery();
             MessageBox.Show("Mesaj Gönderme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            catch (Exception ex)
            { MessageBox.Show("Hata Oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                conn.Close(); // Final ile Bağlantıyı kapattım
            }
            mesajcek();
        }

        private void Mesajlarım_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Mesajlarım_MouseClick(object sender, MouseEventArgs e)
        {
            conn.Open();
            SqlCommand cmd7 = new SqlCommand("Update TBLMESAJLAR SET DURUM=1 WHERE ALICIID=@P1", conn);
            cmd7.Parameters.AddWithValue("@P1", kisiiyim);
            cmd7.ExecuteNonQuery();
            conn.Close();
            okunmamismesaj();

        }


        
    }
}
