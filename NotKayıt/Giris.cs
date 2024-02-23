using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayıt
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            OgretmenGiris fr = new OgretmenGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnOgrGiris_Click(object sender, EventArgs e)
        {
            OgrGiris fr = new OgrGiris();
            fr.Show();
            this.Hide();
        }
    }
}
