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

namespace PastaneMaliyet
{
    public partial class Hareket : Form
    {
        public Hareket()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Pastane;Integrated Security=True");

        void HareketGetir()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HareketGorunum;", conn);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
            conn.Close();
        }
        private void Hareket_Load(object sender, EventArgs e)
        {
            HareketGetir();
        }
    }
}
