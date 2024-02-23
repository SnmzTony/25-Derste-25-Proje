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

namespace Petrol_Istasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Petrol;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Pompa fr=new Pompa();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Benzin95
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Yakıt Where ID=1", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Lbl95Oktan.Text = rdr[3].ToString();
                progressBar95.Value = Convert.ToInt32(rdr[4]);
                Lbl95OktanMiktar.Text = rdr[4].ToString();
            }
            conn.Close();

            // Benzin102
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select * From Yakıt Where ID=2", conn);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                Lbl102Oktan.Text = rdr2[3].ToString();
                progressBar102.Value = Convert.ToInt32(rdr2[4]);
                Lbl102OktanMiktar.Text = rdr2[4].ToString();
            }
            conn.Close();

            // EuroDizel
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select * From Yakıt Where ID=3", conn);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                LblEuroDizel.Text = rdr3[3].ToString();
                progressBarEuro.Value = Convert.ToInt32(rdr3[4]);
                LblEuroDizelMiktar.Text = rdr3[4].ToString();
            }
            conn.Close();
           
            // Power Dizel
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("Select * From Yakıt Where ID=4", conn);
            SqlDataReader rdr4 = cmd4.ExecuteReader();
            while (rdr4.Read())
            {
                LblPowerDizel.Text = rdr4[3].ToString();
                progressBarPower.Value = Convert.ToInt32(rdr4[4]);
                LblPowerDizelMiktar.Text = rdr4[4].ToString();
            }
            conn.Close();

            // LPG
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("Select * From Yakıt Where ID=5", conn);
            SqlDataReader rdr5 = cmd5.ExecuteReader();
            while (rdr5.Read())
            {
                LblGaz.Text = rdr5[3].ToString();
                progressBarGaz.Value = Convert.ToInt32(rdr5[4]);
                LblGazMiktar.Text= rdr5[4].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("Select * From Kasa", conn);
            SqlDataReader rdr6 = cmd6.ExecuteReader();
            while (rdr6.Read())
            {
                LblKasa.Text = rdr6[0].ToString();
            }
        }

        

        private void BtnDepo_Click(object sender, EventArgs e)
        {
            Depolar fr = new Depolar; 
            fr.Show
        }
    }
}
