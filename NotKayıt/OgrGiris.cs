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
    public partial class OgrGiris : Form
    {
        public OgrGiris()
        {
            InitializeComponent();
        }
        
        private void BtnOgrGiris_Click(object sender, EventArgs e)
        {
            OgrencıDetay fr = new OgrencıDetay();
            fr.ogrnum = MskOgrNumara.Text;
            fr.Show();
            this.Hide();

        }
    }
}
