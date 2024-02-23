using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastaneMaliyet
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        public string kimlik;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Pastane;Integrated Security=True");
        void kisigeti()
        {
            conn.Open();
            string cinsiyet;
            SqlCommand cmd = new SqlCommand("Select * From Kasiyer where KASIYERID=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", kimlik);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                LblAdSoyad.Text = rdr[1] + " " + rdr[2];
                LblCep.Text = rdr[4].ToString();
                cinsiyet = rdr[5].ToString();
                if (cinsiyet == "True")
                {
                    LblCinsiyet.Text = "ERKEK";
                }
                else
                {
                    LblCinsiyet.Text = "KADIN";
                }
            }
            conn.Close();
        }
        void urunGetir()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT URUNID, AD, STOK FROM URUN", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            listBox1.ValueMember = "URUNID";
            listBox1.DisplayMember = "UrunAdStok";


            dt.Columns.Add("UrunAdStok", typeof(string), "AD + ' - Stok: ' + STOK");

            listBox1.DataSource = dt;

            conn.Close();
        }
        private void Satis_Load(object sender, EventArgs e)
        {
            kisigeti();
            urunGetir();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen öğenin ValueMember değerini Label5'e yazdır
            if (listBox1.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
                label5.Text = selectedRow.Row[listBox1.ValueMember].ToString();
                label2.Text= selectedRow.Row[listBox1.DisplayMember].ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double adetMaliyet;

                if (numericUpDown1.Value == 0)
                {
                    LblTutar.Text = "0";
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT SATIS FROM URUN WHERE URUNID = @P1", conn);
                    cmd.Parameters.AddWithValue("@P1", Convert.ToInt32(label5.Text));

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        LblTutar.Text = dr["SATIS"].ToString();
                    }

                    conn.Close();

                    adetMaliyet = Convert.ToDouble(LblTutar.Text) * Convert.ToDouble(numericUpDown1.Value);
                    LblTutar.Text = adetMaliyet.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // URUN tablosunu güncelle
                SqlCommand cmdUpdateUrun = new SqlCommand("UPDATE URUN SET STOK = STOK - @P1 WHERE URUNID = @urunid", conn);
                cmdUpdateUrun.Parameters.AddWithValue("@P1", numericUpDown1.Value);
                cmdUpdateUrun.Parameters.AddWithValue("@urunid", label5.Text);
                cmdUpdateUrun.ExecuteNonQuery();

                // KASA tablosunu güncelle
                SqlCommand cmdUpdateKasa = new SqlCommand("UPDATE KASA SET KASA = KASA + @P1", conn);
                cmdUpdateKasa.Parameters.AddWithValue("@P1", decimal.Parse(LblTutar.Text)); // Burada uygun bir dönüşüm yapılmalı
                cmdUpdateKasa.ExecuteNonQuery();

                // Hareket tablosuna yeni kayıt ekle
                SqlCommand cmdInsertHareket = new SqlCommand("INSERT INTO Hareket (URUNID, KASIYERID, FIYAT, ADET) VALUES (@urunid, @kasiyerid, @fiyat,@adet)", conn);
                cmdInsertHareket.Parameters.AddWithValue("@urunid", label5.Text);
                cmdInsertHareket.Parameters.AddWithValue("@kasiyerid", kimlik);
                cmdInsertHareket.Parameters.AddWithValue("@adet", numericUpDown1.Value);
                cmdInsertHareket.Parameters.AddWithValue("@fiyat", decimal.Parse(LblTutar.Text)); // Burada uygun bir dönüşüm yapılmalı
                cmdInsertHareket.ExecuteNonQuery();

                MessageBox.Show("Sipariş Tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            listBox2.Items.Add(LblTutar.Text);
            urunGetir();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert INTO ISTEKURUN (ISTENILEN,ACIKLAMA) values(@istenilen,@acıklama)", conn);
            cmd.Parameters.AddWithValue("@istenilen", label5.Text);
            cmd.Parameters.AddWithValue("@acıklama", label2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İstek İletildi");
        }
    }
}

