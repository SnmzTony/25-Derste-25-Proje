using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Istasyonu
{
    public partial class PompacıEkran : Form
    {
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-31FN50Q\SQLEXPRESS;Initial Catalog=Petrol;Integrated Security=True");

        public string kimlik;
        public string ad;

        public PompacıEkran()
        {
            InitializeComponent();
        }

        private void PompacıEkran_Load(object sender, EventArgs e)
        {
            HizmetCek();
            YakitBilgileriniGetir();
            LblPompacı.Text = ad;
        }

        private void HizmetCek()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(TUTAR) AS 'HIZMET' FROM Hareket WHERE PompacıID = @P1", conn);
                cmd2.Parameters.AddWithValue("@P1", kimlik);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    HizmetBilgim.Text = table.Rows[0]["HIZMET"].ToString() + " TL";
                }
                else
                {
                    HizmetBilgim.Text = "0 TL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void YakitBilgileriniGetir()
        {
            string[] yakitTurleri = { "Benzin95", "Benzin102", "EuroDizel", "PowerDizel", "LPG" };

            for (int i = 0; i < yakitTurleri.Length; i++)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Yakıt WHERE ID = {i + 1}", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    switch (i)
                    {
                        case 0:
                            Lbl95Oktan.Text = rdr[3].ToString();
                            break;
                        case 1:
                            Lbl102Oktan.Text = rdr[3].ToString();
                            break;
                        case 2:
                            LblEuroDizel.Text = rdr[3].ToString();
                            break;
                        case 3:
                            LblPowerDizel.Text = rdr[3].ToString();
                            break;
                        case 4:
                            LblGaz.Text = rdr[3].ToString();
                            break;
                    }
                }
                conn.Close();
            }
        }
        private void BtnYakitVer_Click(object sender, EventArgs e)
        {
            //numeric95
            if (numericUpDown95.Value != 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into Hareket(Plaka, Petroltur, Miktar, PompacıID, Tutar,Pompa) values (@plaka, @petrol, @miktar, @pompacı, @tutar,@pompa)", conn);
                    cmd.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
                    cmd.Parameters.AddWithValue("@petrol", lblyakittipi.Text);
                    cmd.Parameters.AddWithValue("@miktar", numericUpDown95.Value);
                    cmd.Parameters.AddWithValue("@pompacı", kimlik);
                    cmd.Parameters.AddWithValue("@tutar", Decimal.Parse(TxtMiktar95.Text));
                    cmd.Parameters.AddWithValue("@pompa", label4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yakıt Dolum İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }


                }

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Kasa set Kasa=Kasa+@P1", conn);
                cmd2.Parameters.AddWithValue("@P1", Decimal.Parse(TxtMiktar95.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("Update Yakıt set stok=stok-@P1 where ID=1", conn);
                cmd3.Parameters.AddWithValue("@P1", numericUpDown95.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
            }

            //numericUpDown102
            if (numericUpDown102.Value != 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into Hareket(Plaka, Petroltur, Miktar, PompacıID, Tutar,Pompa) values (@plaka, @petrol, @miktar, @pompacı, @tutar,@pompa)", conn);
                    cmd.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
                    cmd.Parameters.AddWithValue("@petrol", lblyakittipi.Text);
                    cmd.Parameters.AddWithValue("@miktar", numericUpDown102.Value);
                    cmd.Parameters.AddWithValue("@pompacı", kimlik);
                    cmd.Parameters.AddWithValue("@tutar", Decimal.Parse(TxtMiktar102.Text));
                    cmd.Parameters.AddWithValue("@pompa", label4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yakıt Dolum İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Kasa set Kasa=Kasa+@P1", conn);
                cmd2.Parameters.AddWithValue("@P1", Decimal.Parse(TxtMiktar102.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("Update Yakıt set stok=stok-@p1 where ID=2", conn);
                cmd3.Parameters.AddWithValue("@P1", numericUpDown102.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();

            }

            //numericUpDownEuro
            if (numericUpDownEuro.Value != 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into Hareket(Plaka, Petroltur, Miktar, PompacıID, Tutar,Pompa) values (@plaka, @petrol, @miktar, @pompacı, @tutar,@pompa)", conn);
                    cmd.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
                    cmd.Parameters.AddWithValue("@petrol", lblyakittipi.Text);
                    cmd.Parameters.AddWithValue("@miktar", numericUpDownEuro.Value);
                    cmd.Parameters.AddWithValue("@pompacı", kimlik);
                    cmd.Parameters.AddWithValue("@tutar", Decimal.Parse(TxtMiktarEuro.Text));
                    cmd.Parameters.AddWithValue("@pompa", label4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yakıt Dolum İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Kasa set Kasa=Kasa+@P1", conn);
                cmd2.Parameters.AddWithValue("@P1", Decimal.Parse(TxtMiktarEuro.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("Update Yakıt set stok=stok-@p1 where ID=3", conn);
                cmd3.Parameters.AddWithValue("@P1", numericUpDownEuro.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
            }
            //numericUpDownPower
            if (numericUpDownPower.Value != 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into Hareket(Plaka, Petroltur, Miktar, PompacıID, Tutar,Pompa) values (@plaka, @petrol, @miktar, @pompacı, @tutar,@pompa)", conn);
                    cmd.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
                    cmd.Parameters.AddWithValue("@petrol", lblyakittipi.Text);
                    cmd.Parameters.AddWithValue("@miktar", numericUpDownPower.Value);
                    cmd.Parameters.AddWithValue("@pompacı", kimlik);
                    cmd.Parameters.AddWithValue("@tutar", Decimal.Parse(TxtMiktarPower.Text));
                    cmd.Parameters.AddWithValue("@pompa", label4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yakıt Dolum İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Kasa set Kasa=Kasa+@P1", conn);
                cmd2.Parameters.AddWithValue("@P1", Decimal.Parse(TxtMiktarPower.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("Update Yakıt set stok=stok-@p1 where ID=4", conn);
                cmd3.Parameters.AddWithValue("@P1", numericUpDownPower.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();

            }


            if (numericUpDownLpg.Value != 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into Hareket(Plaka, Petroltur, Miktar, PompacıID, Tutar,Pompa) values (@plaka, @petrol, @miktar, @pompacı, @tutar,@pompa)", conn);
                    cmd.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
                    cmd.Parameters.AddWithValue("@petrol", lblyakittipi.Text);
                    cmd.Parameters.AddWithValue("@miktar", numericUpDownLpg.Value);
                    cmd.Parameters.AddWithValue("@pompacı", kimlik);
                    cmd.Parameters.AddWithValue("@tutar", Decimal.Parse(TxtMiktarLpg.Text));
                    cmd.Parameters.AddWithValue("@pompa", label4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yakıt Dolum İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Kasa set Kasa=Kasa+@P1", conn);
                cmd2.Parameters.AddWithValue("@P1", Decimal.Parse(TxtMiktarLpg.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("Update Yakıt set stok=stok-@p1 where ID=5", conn);
                cmd3.Parameters.AddWithValue("@P1", numericUpDownLpg.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();

            }
        }
    }

}


