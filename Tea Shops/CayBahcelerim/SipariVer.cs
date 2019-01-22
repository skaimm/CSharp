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
    public partial class SipariVer : Form
    {
        SiparisFactory sf;
        bool bal, lim;

        public SipariVer(SiparisFactory sf)
        {
            InitializeComponent();
            bal = false;
            lim = false;
            this.sf = sf;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EkstraIcerik ekstra = new EkstraIcerik();
            ekstra.ShowDialog();
            if (ekstra.checkBox1.Checked)
            {
                bal = true;
            }
            if(ekstra.checkBox2.Checked)
            {
                lim = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // siparis onayla ve kaydet
            if(!radioButton1.Checked & !radioButton2.Checked & !radioButton3.Checked & !radioButton4.Checked
                & !radioButton5.Checked & !radioButton6.Checked)
            {
                MessageBox.Show("Menuden Ne istediğinizi Seçmediniz.");
            }
            else
            {

                string icecek = null;
                string tost = "";

                if (radioButton1.Checked)
                {
                    tost = "Karisik";
                }
                if (radioButton2.Checked)
                {
                    tost = "Kasarli";
                }
                if (radioButton3.Checked)
                {
                    tost = "Ayvalik";
                }
                if (radioButton4.Checked)
                {
                    icecek = "Cay";
                }
                if (radioButton5.Checked)
                {
                    icecek = "Oralet";
                }
                if (radioButton6.Checked)
                {
                    icecek = "Ihlamur";
                }

                sf.Siparis(tost, icecek, bal, lim);
                Close();

            }

        }
        

        private void SipariVer_Load(object sender, EventArgs e)
        {

        }
    }
}
