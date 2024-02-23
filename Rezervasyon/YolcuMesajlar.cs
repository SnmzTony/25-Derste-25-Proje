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
    public partial class YolcuMesajlar : Form
    {
        public YolcuMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Rezervasyon;Integrated Security=True");
        public string id;

        void mesajcek()
        {
            
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Mesaj FROM Mesajlar where GONDERENID=@P1 or ALICIID=@P2 ", conn);
            cmd2.Parameters.AddWithValue("@P2", id);
            cmd2.Parameters.AddWithValue("@P1", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mesaj.DisplayMember = "Mesaj";
            Mesaj.ValueMember = "Mesaj";
            Mesaj.DataSource = table;
            conn.Close();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Mesajlar (GonderenId,Mesaj) values(@gonderen,@mesaj)", conn);
                cmd.Parameters.AddWithValue("@gonderen", id);
                cmd.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                richTextBox1.Text = "";
            }
            catch (Exception ex )
            {

                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           finally { conn.Close(); }

        }

        private void YolcuMesajlar_Load(object sender, EventArgs e)
        {
            mesajcek();
        }
    }
}
