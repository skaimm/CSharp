using CayBahcelerim.Sınıflar;
using CayBahcelerim.Sınıflar.Factory_Method_Pattern;
using CayBahcelerim.Sınıflar.Observer_Pattern;
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
    public partial class Anasayfa : Form
    {
        SiparisFactory k,t;
        FiyatListesi fy;

        public Anasayfa()
        {
            InitializeComponent();
            k = new KadikoyCayBahcesi();
            t = new KadikoyCayBahcesi();
            fy = new FiyatListesi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SubeIcerik taksim = new SubeIcerik(t);
            taksim.ShowDialog();
            taksim = null;
            Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            SubeIcerik kadikoy = new SubeIcerik(k);
            kadikoy.ShowDialog();
            kadikoy = null;
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Fiyatlar fyt = new Fiyatlar(fy);
            fyt.ShowDialog();
            fyt = null;
            Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
           
        }
    }
}
