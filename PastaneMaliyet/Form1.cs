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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Pastane;Integrated Security=True");

        void MalzemeListe()
        {
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from MALZEME", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        void UrunListesi()
        {
            conn.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From URUN", conn);
            DataTable dt4 = new DataTable();
            da3.Fill(dt4);
            dataGridView1.DataSource = dt4;
            conn.Close();
        }
        void Urunler()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From URUN", conn);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            CmbUrunOlustur.ValueMember = "URUNID";
            CmbUrunOlustur.DisplayMember = "AD";
            CmbUrunOlustur.DataSource = dt2;
            conn.Close();

        }
        void KasGetir()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From KASA", conn);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
            conn.Close();
        }
        string urunid;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            Urunler();
          
        }

        private void BtnEkleMalzeme_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Malzeme Eklemek İstediğinizden Emin Misiniz?", "Ön Onay", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert INTO MALZEME (AD,STOK,FIYAT,NOTLAR) values(@ad,@stok,@fiyat,@notlar)", conn);
                    cmd.Parameters.AddWithValue("@ad", TxtMalzemeAd.Text);
                    cmd.Parameters.AddWithValue("@stok", TxtMalzemeStok.Text);
                    cmd.Parameters.AddWithValue("@fiyat", TxtMalzemeFiyat.Text);
                    cmd.Parameters.AddWithValue("@notlar", TxtMalzemeNot.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Malzeme Ekleme Başarılı", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                    MalzemeListe();
                }

            }
            else
            {
                // Hayır'a tıklandıysa burada işlemi iptal edin veya başka bir şey yapın
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void BtnGuncelleMalzeme_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Malzeme Güncelleme İstediğinizden Emin Misiniz?", "Ön Onay", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update MALZEME SET STOK=@stok,FIYAT=@fiyat,NOTLAR=@notlar where AD=@ad", conn);
                    cmd.Parameters.AddWithValue("@ad", TxtMalzemeAd.Text);
                    cmd.Parameters.AddWithValue("@stok", TxtMalzemeStok.Text);
                    cmd.Parameters.AddWithValue("@fiyat", TxtMalzemeFiyat.Text);
                    cmd.Parameters.AddWithValue("@notlar", TxtMalzemeNot.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Malzeme Güncelleme Başarılı", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                    MalzemeListe();
                }

            }
            else
            {
                // Hayır'a tıklandıysa burada işlemi iptal edin veya başka bir şey yapın
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtUrunMaliyet.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtUrunSatis.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtUrunStok.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MalzemeID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MalzemeListe();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Üretim Yapmak İstediğinizden Emin Misiniz?", "Ön Onay", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-31FN50Q\\SQLEXPRESS;Initial Catalog=Pastane;Integrated Security=True"))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Üretim bilgilerini Uretim tablosuna ekliyorum
                        SqlCommand cmdUretim = new SqlCommand("INSERT INTO Uretim(URUNID,MIKTAR,MALIYET) values(@urun,@miktar,@maliyet)", conn, transaction);
                        cmdUretim.Parameters.AddWithValue("@urun", CmbUrunOlustur.SelectedValue);
                        cmdUretim.Parameters.AddWithValue("@miktar", TxtUrunOlusturMiktar.Text);
                        decimal maliyet = decimal.Parse(TxtUrunOlusturMaliyet.Text);
                        cmdUretim.Parameters.AddWithValue("@maliyet", maliyet);
                        cmdUretim.ExecuteNonQuery();

                        // Malzemelerin stoklarını düşürüyorum
                        SqlCommand cmdDusStok = new SqlCommand("UPDATE MALZEME SET Stok = Stok - (UM.Adet * @UretimMiktar) FROM UrunMalzemeTablosu UM INNER JOIN MALZEME MST ON UM.MalzemeID = MST.MalzemeID WHERE UM.UrunID = @UrunID", conn, transaction);
                        cmdDusStok.Parameters.AddWithValue("@UretimMiktar", TxtUrunOlusturMiktar.Text);
                        cmdDusStok.Parameters.AddWithValue("@UrunID", CmbUrunOlustur.SelectedValue);
                        cmdDusStok.ExecuteNonQuery();

                        // Ürün stoğunu güncelleliyoz
                        SqlCommand cmdGuncelleStok = new SqlCommand("UPDATE URUN SET STOK = STOK + @UretimMiktar WHERE URUNID = @UrunID", conn, transaction);
                        cmdGuncelleStok.Parameters.AddWithValue("@UretimMiktar", TxtUrunOlusturMiktar.Text);
                        cmdGuncelleStok.Parameters.AddWithValue("@UrunID", CmbUrunOlustur.SelectedValue);
                        cmdGuncelleStok.ExecuteNonQuery();

                        // İşlemi başarıyla tamamlaladı çıktısını veriyorum
                        transaction.Commit();

                        MessageBox.Show("Üretim Başarılı", "Üretildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda işlemi geri al
                        transaction.Rollback();
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TxtUrunOlusturMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double adetMaliyet;

                if (TxtUrunOlusturMiktar.Text == "")
                {
                    TxtUrunOlusturMiktar.Text = "0";
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MALIYET FROM URUN WHERE URUNID=@P1", conn);
                cmd.Parameters.AddWithValue("@P1", CmbUrunOlustur.SelectedValue);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TxtUrunOlusturMaliyet.Text = dr["MALIYET"].ToString();
                }

                conn.Close();

                adetMaliyet = Convert.ToDouble(TxtUrunOlusturMaliyet.Text) * Convert.ToDouble(TxtUrunOlusturMiktar.Text);
                TxtUrunOlusturMaliyet.Text = adetMaliyet.ToString(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuncelleUrun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ürün Güncellemek İstediğinizden Emin Misiniz?", "Ön Onay", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update URUN set SATIS=@satis Where URUNID=@urunid", conn);
                    cmd.Parameters.AddWithValue("@urunid", MalzemeID.Text);
                    cmd.Parameters.AddWithValue("@satis", TxtUrunSatis.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ürün Güncelleme Başarılı", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                    MalzemeListe();
                }

            }
            else
            {
                
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            
            KasGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hareket fr= new Hareket();
            fr.Show();
        }
    }
}
