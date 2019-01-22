using Otel.AbstractFactoryPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class OdaServisi : Form
    {
        IstanbulOtel istanbulOtel;

        public OdaServisi(IstanbulOtel istanbulOtel)
        {
            InitializeComponent();
            this.istanbulOtel = istanbulOtel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdaServisi_Load(object sender, EventArgs e)
        {
            // listview menu goster
            listView1.Columns.Add("Menu", 70);
            listView1.Columns.Add("Açıklama", 150);
            listView1.Columns.Add("Fiyat", 50);

            Kahvalti kahvalti = new Kahvalti();
            for(int i=0; i < kahvalti.itemleriGoster().Count; i++)
            {
                string[] strings = { kahvalti.itemleriGoster()[i].Isim, kahvalti.itemleriGoster()[i].Aciklama,
                kahvalti.itemleriGoster()[i].Ucret.ToString()};
                ListViewItem item = new ListViewItem(strings);
                listView1.Items.Add(item);
            }

        }
    }
}
