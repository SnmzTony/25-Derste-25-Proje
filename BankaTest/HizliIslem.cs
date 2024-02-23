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

namespace BankaTest
{
    public partial class HizliIslem : Form
    {
        public HizliIslem()
        {
            InitializeComponent();
        }
        public string hesaphızlı;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");


        private void HizliIslem_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select (B.AD+' '+B.SOYAD) GONDERILEN, A.MIKTAR FROM TBLHIZLIISLEMLER A INNER JOIN Kullanicilar B ON B.HESAPNO=A.ALICI where A.GONDEREN=@P1",conn);
            
            Lblhesap.Text = hesaphızlı;
            cmd.Parameters.AddWithValue("@P1", Lblhesap.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
