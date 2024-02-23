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

namespace BankaTest
{
    public partial class Gecmis : Form
    {
        public Gecmis()
        {
            InitializeComponent();
        }
        public string hesap;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");

        private void Gecmis_Load(object sender, EventArgs e)
        {
            lblGecmısHesap.Text = hesap;
            SqlCommand cmd = new SqlCommand("SELECT (B.AD+' '+B.SOYAD) AS KİSİ, A.TUTAR,CASE WHEN A.GONDEREN=@P1 THEN 'PARA ÇIKIŞ' ELSE 'PARA GİRİŞ' END Tipi  FROM TBLHAREKET A INNER JOIN Kullanicilar B on B.HesapNo=A.ALICI where  ", conn);
            cmd.Parameters.AddWithValue("@P1", lblGecmısHesap.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);  

        }
    }
}
