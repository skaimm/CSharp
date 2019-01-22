using CayBahcelerim.Sınıflar.Tost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayBahcelerim
{
    public partial class SubeIcerik : Form
    {
        SiparisFactory sf;

        public SubeIcerik(SiparisFactory sf)
        {
            InitializeComponent();
            this.sf = sf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            //Fiyatlar yenisiparis = new Fiyatlar();
            //yenisiparis.ShowDialog();
            //yenisiparis = null;
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Siparislerim siparislerim = new Siparislerim(sf);
            siparislerim.ShowDialog();
            siparislerim.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubeIcerik_Load(object sender, EventArgs e)
        {

        }
    }
}
