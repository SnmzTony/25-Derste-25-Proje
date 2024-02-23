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

namespace Petrol_Istasyonu
{
    public partial class Pompa : Form
    {
        public Pompa()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Petrol;Integrated Security=True");

        void PompaBilgisiGetir(int pompaNumarasi)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand($"Select A.Plaka,A.Petroltur,A.Miktar,(B.PompaciAd + ' ' + B.PompaciSoyad) AS 'POMPACI AD', A.Tutar,A.Pompa FROM Hareket A INNER JOIN Pompaci B ON B.PompaciID=A.PompacıID Where Pompa={pompaNumarasi}", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (pompaNumarasi)
                {
                    case 1:
                        LblPlaka1.Text = reader[0].ToString();
                        LblYakıtTuru1.Text = reader[1].ToString();
                        LblMiktar1.Text = reader[2].ToString();
                        LblDurum1.Text = reader[3].ToString();
                        LblTutar1.Text = reader[4].ToString();
                        break;
                    case 2:
                        LblPlaka2.Text = reader[0].ToString();
                        LblYakıtTuru2.Text = reader[1].ToString();
                        LblMiktar2.Text = reader[2].ToString();
                        LblDurum2.Text = reader[3].ToString();
                        LblTutar2.Text = reader[4].ToString();
                        break;
                    case 3:
                        LblPlaka3.Text = reader[0].ToString();
                        LblYakıtTuru3.Text = reader[1].ToString();
                        LblMiktar3.Text = reader[2].ToString();
                        LblDurum3.Text = reader[3].ToString();
                        LblTutar3.Text = reader[4].ToString();
                        break;
                    case 4:
                        LblPlaka4.Text = reader[0].ToString();
                        LblYakıtTuru4.Text = reader[1].ToString();
                        LblMiktar4.Text = reader[2].ToString();
                        LblDurum4.Text = reader[3].ToString();
                        LblTutar4.Text = reader[4].ToString();
                        break;
                    case 5:
                        LblPlaka5.Text = reader[0].ToString();
                        LblYakıtTuru5.Text = reader[1].ToString();
                        LblMiktar5.Text = reader[2].ToString();
                        LblDurum5.Text = reader[3].ToString();
                        LblTutar5.Text = reader[4].ToString();
                        break;
                    case 6:
                        LblPlaka6.Text = reader[0].ToString();
                        LblYakıtTuru6.Text = reader[1].ToString();
                        LblMiktar6.Text = reader[2].ToString();
                        LblDrum6.Text = reader[3].ToString();
                        LblTutar6.Text = reader[4].ToString();
                        break;
                    default:
                        // Hata durumu veya başka bir işlem yapılabilir
                        break;
                }

            }
            conn.Close();


        }

        private void Pompa_Load(object sender, EventArgs e)
        {
            PompaBilgisiGetir(1); 
            PompaBilgisiGetir(2);
            PompaBilgisiGetir(3);
            PompaBilgisiGetir(4);
            PompaBilgisiGetir(5);
            PompaBilgisiGetir(6);
        }
    }
}
