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
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }

        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            OgretmenDetay fr = new OgretmenDetay();
            fr.Show();
            this.Close();
        }
    }
}
