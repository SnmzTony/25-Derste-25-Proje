using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETUTOKUL
{
    public partial class HangiGiris : Form
    {
        public HangiGiris()
        {
            InitializeComponent();
        }

       

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Giris fr1 = new Giris();
            fr1.Show();  
            
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            OgrenciGiris fr = new OgrenciGiris();
            fr.Show();
            
        }
    }
}
