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
    public partial class OgrencıDetay : Form
    {

        
        //Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True        
        public OgrencıDetay()
        {
            InitializeComponent();
        }
        public string ogrnum;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");

        private void OgrencıDetay_Load(object sender, EventArgs e)
        {
            string durum;
            LblNumara.Text = ogrnum;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS WHERE OGRNUMARA=@P1", baglanti);
            komut.Parameters.AddWithValue("@p1", ogrnum);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblSınav1.Text = dr[4].ToString();
                LblSınav2.Text = dr[5].ToString();
                LblSınav3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                durum = dr[8].ToString();

                
                if (durum == "0")
                {
                    LblDurum.Text = "Kaldı";
                }
                else
                {
                    LblDurum.Text = "Geçti";
                }
            }
            baglanti.Close();
        }
    }
}
