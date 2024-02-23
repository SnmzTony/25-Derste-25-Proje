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
namespace NotKayıt
{
    public partial class OgretmenDetay : Form
    {
        public OgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");
        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayıtDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
            baglanti.Open();
            SqlCommand gecenkomut = new SqlCommand("Select Count(*) From TBLDERS Where DURUM=1", baglanti);
            SqlCommand kalankomut = new SqlCommand("Select Count(*) From TBLDERS Where DURUM=0", baglanti);
            int gecen = (int)gecenkomut.ExecuteScalar();
            int kalan = (int)kalankomut.ExecuteScalar();
            LblGeçenSayısı.Text = gecen.ToString();
            LblKalanSayısı.Text = kalan.ToString();
            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", MskNumara.Text);
            komut.Parameters.AddWithValue("@P2", TxtAd.Text);
            komut.Parameters.AddWithValue("@P3",TxtSoyad.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sistemi Eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLDERS SET OGRAD=@P2,OGRSOYAD=@P3 WHERE OGRID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtID.Text);
            komut.Parameters.AddWithValue("@P2",TxtAd.Text);
            komut.Parameters.AddWithValue("@P3",TxtSoyad.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
         
           MessageBox.Show("Güncelleme Yapıldı");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(TxtSınav1.Text);
            s2 = Convert.ToDouble(TxtSınav2.Text);
            s3 = Convert.ToDouble(TxtSınav3.Text);
            ortalama=(s1 + s2+ s3)/3;
            LblOrtalama.Text=ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "true";
            }
            else
            {
                durum= "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Update  TBLDERS set OGRS1=@P1, OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4, DURUM=@P5  WHERE OGRID=@P6", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtSınav1.Text);
            komut.Parameters.AddWithValue("@P2", TxtSınav2.Text);
            komut.Parameters.AddWithValue("@P3", TxtSınav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", TxtID.Text);
            
           komut.ExecuteNonQuery();
            SqlCommand gecenkomut = new SqlCommand("Select Count(*) From TBLDERS Where DURUM=1", baglanti);
            SqlCommand kalankomut = new SqlCommand("Select Count(*) From TBLDERS Where DURUM=0", baglanti);
            int gecen = (int)gecenkomut.ExecuteScalar();
            int kalan = (int)kalankomut.ExecuteScalar();
            LblGeçenSayısı.Text = gecen.ToString();
            LblKalanSayısı.Text = kalan.ToString();
            baglanti.Close();
            MessageBox.Show("Notlar Eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}
