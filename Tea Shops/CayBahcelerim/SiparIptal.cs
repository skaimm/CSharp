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
    public partial class SiparIptal : Form
    {
        SiparisFactory sf;

        public SiparIptal(SiparisFactory sf)
        {
            InitializeComponent();
            this.sf = sf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //onayla
            
            if (comboBox1.Text != null)
            {
                sf.SiparisIptal(Int32.Parse(comboBox1.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Siparişi secçmedini");
            }

        }

        private void SiparIptal_Load(object sender, EventArgs e)
        {
            if (sf.SiparileriGoster() != null)
            {
                for (int i = 0; i < sf.SiparileriGoster().Count; i++)
                {
                    comboBox1.Items.Add(i.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sf.SiparileriGoster()[Int32.Parse(comboBox1.Text)][0] != null)
                textBox1.Text = sf.SiparileriGoster()[Int32.Parse(comboBox1.Text)][0].ToString();
            if (sf.SiparileriGoster()[Int32.Parse(comboBox1.Text)][1] != null)
                textBox2.Text = sf.SiparileriGoster()[Int32.Parse(comboBox1.Text)][1].ToString();
                
        }
    }
}
