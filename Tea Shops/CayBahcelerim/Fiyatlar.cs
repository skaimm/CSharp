using CayBahcelerim.Sınıflar.Decorator_Pattern;
using CayBahcelerim.Sınıflar.Observer_Pattern;
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
    public partial class Fiyatlar : Form
    {
        FiyatListesi fy;

        public Fiyatlar(FiyatListesi fy)
        {
            InitializeComponent();
            this.fy = fy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fiyat guncelleme formuna git
            Hide();
            FiyatGuncelle fiyatlar = new FiyatGuncelle(fy);
            fiyatlar.ShowDialog();
            fiyatlar = null;
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fiyatlar_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Menu", 70);
            listView1.Columns.Add("Fiyatlar", 70);

            string[] kar = { "Karışık Tost", fy.getkarisik().ToString("0.##") + " TL" };
            string[] kas = { "Kaşarlı Tost", fy.getkasarli().ToString("0.##") + " TL" };
            string[] ayv = { "Ayvalık Tost", fy.getayvalık().ToString("0.##") + " TL" };
            string[] ihl = { "Ihlamur", fy.getihlamur().ToString("0.##") + " TL" };
            string[] ora = { "Oralet", fy.getoralet().ToString("0.##") + " TL" };
            string[] cay = { "Çay", fy.getcay().ToString("0.##") + " TL" };
            ListViewItem item1 = new ListViewItem(kar);
            ListViewItem item2 = new ListViewItem(kas);
            ListViewItem item3 = new ListViewItem(ayv);
            ListViewItem item4 = new ListViewItem(cay);
            ListViewItem item5 = new ListViewItem(ora);
            ListViewItem item6 = new ListViewItem(ihl);

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            listView1.Items.Add(item4);
            listView1.Items.Add(item5);
            listView1.Items.Add(item6);
        }
    }
}
