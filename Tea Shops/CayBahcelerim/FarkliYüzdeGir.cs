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
    public partial class FarkliYüzdeGir : Form
    {
        FiyatListesi fy;
        public FarkliYüzdeGir(FiyatListesi fy)
        {
            InitializeComponent();
            this.fy = fy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            int yuzde=0;
            for(int i=1;i<100;i++)
            {
                if (textBox1.Text.Equals(i.ToString())){
                    kontrol = true;
                    yuzde = i;
                    break;
                }
            }
            if(kontrol)
            {
                fy.setFiyatlar(yuzde,"A");
                MessageBox.Show("Fiyatlat %" + yuzde + " zamlandı.");
            }
            else
            {
                MessageBox.Show("Lütfen 0 ile 100 arası sayı giriniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FarkliYüzdeGir_Load(object sender, EventArgs e)
        {

        }
    }
}
