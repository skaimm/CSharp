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
    public partial class Siparislerim : Form
    {
        SiparisFactory sf;

        public Siparislerim(SiparisFactory sf)
        {
            InitializeComponent();
            listView1.Update();
            this.sf = sf;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SiparisDuzelt sipraris = new SiparisDuzelt(sf);
            sipraris.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SiparIptal sipraris = new SiparIptal(sf);
            sipraris.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SipariVer siprarisver = new SipariVer(sf);
            siprarisver.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Siparislerim_Load(object sender, EventArgs e)
        {
            list();
        }

        private void list()
        {
            listView1.Columns.Add("No", 30);
            listView1.Columns.Add("Siparişler", 110);
            if (sf.SiparileriGoster() != null)
            {
                for (int i = 0; i < sf.SiparileriGoster().Count; i++)
                {
                    string siparisler = "";
                    for (int j = 0; j < sf.SiparileriGoster()[i].Count; j++)
                    {
                        siparisler += sf.SiparileriGoster()[i][j].ToString();
                        if (j != sf.SiparileriGoster()[i].Count - 1)
                        {
                            siparisler += " + ";
                        }

                    }
                    string[] strings = { i.ToString(), siparisler };
                    ListViewItem item = new ListViewItem(strings);
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
