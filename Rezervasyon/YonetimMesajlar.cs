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

namespace Rezervasyon
{
    public partial class YonetimMesajlar : Form
    {
        public YonetimMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Rezervasyon;Integrated Security=True");

        void istekcek()
        {
            string bos;
            bos = "NULL";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM MesajlarView;", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Müşteri.DisplayMember = "AD SOYAD";
            Müşteri.ValueMember = "GONDERENID";
            Müşteri.DataSource = table;
            conn.Close();
        }
        private void YonetimMesajlar_Load(object sender, EventArgs e)
        {
            istekcek();
            mesajcek();
        }

        void mesajcek()
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Mesaj FROM Mesajlar WHERE DURUM = 0", conn);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mesaj.DisplayMember = "Mesaj";
            Mesaj.ValueMember = "Mesaj";
            Mesaj.DataSource = table;
            conn.Close();
        }
    }
}

