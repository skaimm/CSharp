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
    public partial class SiparisDuzelt : Form
    {
        SiparisFactory sf;
        public SiparisDuzelt(SiparisFactory sf)
        {
            this.sf=sf;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int spno = Int32.Parse(comboBox3.Text);
            string tost = "";
            string icecek = "";

            bool b = false, l = false;
            if (checkBox1.Checked)
            {
                b = true;
            }
            if (checkBox1.Checked)
            {
                l = true;
            }
            

            if (radioButton1.Checked)
            {
                icecek = "Cay";
            }
            if (radioButton2.Checked)
            {
                icecek = "Oralet";
            }
            if (radioButton5.Checked)
            {
                icecek = "Ihlamur";
            }

            if (radioButton3.Checked || radioButton4.Checked)
            {
                if(radioButton3.Text.Equals("Karışık Tost"))
                {
                    tost = "Karisik";
                }
                if (radioButton3.Text.Equals("Kaşarlı Tost"))
                {
                    tost = "Kasarli";
                }
                if (radioButton3.Text.Equals("Ayvalık Tost"))
                {
                    tost = "Ayvalik";
                }
            }
            if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked ||
                radioButton5.Checked )
            {
                sf.SiparisDuzelt(spno, tost, icecek, b, l);
                Close();
            }
            else
            {
                MessageBox.Show("Değişiklik Yapmadınız.");
            }
        }

        private void SiparisDuzelt_Load(object sender, EventArgs e)
        {
            if (sf.SiparileriGoster() != null)
            {
                for (int i = 0; i < sf.SiparileriGoster().Count; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sf.SiparileriGoster()[Int32.Parse(comboBox3.Text)][0]!=null)
                textBox1.Text = sf.SiparileriGoster()[Int32.Parse(comboBox3.Text)][0].ToString();
            if (sf.SiparileriGoster()[Int32.Parse(comboBox3.Text)][1] != null)
            {
                textBox2.Text = sf.SiparileriGoster()[Int32.Parse(comboBox3.Text)][1].ToString();

                if(textBox2.Text.StartsWith("Limonlu Çay"))
                {
                    checkBox2.Checked = true;
                }
                if (textBox2.Text.StartsWith("Limonlu Ballı"))
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                }
                if (textBox2.Text.StartsWith("Ballı"))
                {
                    checkBox1.Checked = true;
                }
            }         
            if(textBox1.Text.StartsWith("Kar"))
            {
                radioButton4.Text = "Kaşarlı Tost";
                radioButton3.Text = "Ayvalık Tost";
            }
            if (textBox1.Text.StartsWith("Kaş"))
            {
                radioButton4.Text = "Karışık Tost";
                radioButton3.Text = "Ayvalık Tost";
            }
            if (textBox1.Text.StartsWith("Ayva"))
            {
                radioButton4.Text = "Karışık Tost";
                radioButton3.Text = "Kaşarlı Tost";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
