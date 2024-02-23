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

namespace ETUTOKUL
{
    public partial class Duyuru : Form
    {
        public Duyuru()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True");
        void mesajcek()
        {

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT MESAJ FROM TBLDUYURULAR ", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mesajlarım.DisplayMember = "Mesaj";
            Mesajlarım.ValueMember = "Mesaj";
            Mesajlarım.DataSource = table;
            conn.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO TBLDUYURULAR (MESAJ) VALUES (@mesaj)", conn);
                    cmd.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mesaj Gönderme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (Exception ex)
                { MessageBox.Show("Hata Oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally
                {
                    conn.Close(); // Final ile Bağlantıyı kapattım
                }
            }
        }

        private void Duyuru_Load(object sender, EventArgs e)
        {
            mesajcek();
        }
    }
}
