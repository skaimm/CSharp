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
    public partial class FiyatGuncelle : Form
    {
        FiyatListesi fy;
        public FiyatGuncelle(FiyatListesi fy)
        {
            InitializeComponent();
            this.fy = fy;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox3.Checked)
                {
                    MessageBox.Show("Hem İndirim hem zam aynı anda Yapılamaz.");
                }
                else
                {
                    fy.setFiyatlar(10,"A");
                    MessageBox.Show("Fiyatlat %10 zamlandı.");
                    Close();
                }
            }else
            {
                if (checkBox3.Checked)
                {
                    fy.setFiyatlar(5, "I");
                    MessageBox.Show("Fiyatlat %5 düşürüldü.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Onaylanacak Bir Değişiklik yok.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FarkliYüzdeGir fyt = new FarkliYüzdeGir(fy);
            fyt.ShowDialog();
            fyt = null;
            Show();
            
        }

        private void FiyatGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
