using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BankaTest
{
    public partial class Doviz : Form
    {
        public Doviz()
        {
            InitializeComponent();
        }

        private void Doviz_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarAlıs.Text = dolaralis + " " + "TL";
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarSatıs.Text = dolarsatis + " " + "TL";
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroAlıs.Text = euroalis + " " + "TL";
            LblEuroSatıs.Text = eurosatis + " " + "TL";
            string sterlinalıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            string sterlinsatıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            LblSterlinAlıs.Text = sterlinalıs + " " + "TL";
            LblSterlinSatıs.Text = sterlinsatıs + " " + "TL";
            string yenalıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteBuying").InnerXml;
            string yensatıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteSelling").InnerXml;
            LblYenAlıs.Text = yenalıs +" "+ "TL";
            LblYenSatıs.Text = yensatıs + " " + "TL";
        }
    }
}
