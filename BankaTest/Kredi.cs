using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankaTest
{
    public partial class Kredi : Form
    {
        public Kredi()
        {
            InitializeComponent();
        }

       
        private void Kredi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal krediTutari = Convert.ToDecimal(CmbKrediTutar.Text);
            int vade = Convert.ToInt32(CmbVade.Text);
            decimal faizOrani = 0.057m;
            decimal taksitTutari = krediTutari * (faizOrani * (decimal)Math.Pow(1 + (double)faizOrani, vade)) / ((decimal)Math.Pow(1 + (double)faizOrani, vade) - 1);

            // Taksit tutarını para birimi formatında görüntülüuoruz
            decimal toplamGeriOdeme = taksitTutari * vade;
            LblGeriOdeme.Text = toplamGeriOdeme.ToString("C2");

            // Faiz oranını yüzde formatında görüntülüyoruz
            LblFaizOran.Text = (faizOrani * 100).ToString("0.##") + "%";

            // Vadeyi görüntüle
            LblTaksitTutar.Text = taksitTutari.ToString("C2");

        }
    }
}
