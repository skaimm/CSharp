using Otel.AbstractFactoryPattern;
using Otel.IteratorPattern;
using System;
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
    public partial class IstanbulOtell : Form
    {
        IstanbulOtel istanbulOtel;
        Dvd film;
        int ilkderece;
        public IstanbulOtell()
        {
            InitializeComponent();
            istanbulOtel = IstanbulOtel.getInstance();
            film = new Dvd("Film Seçilmedi");
            ilkderece = 0;

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            OdaServisi odaser = new OdaServisi(istanbulOtel);
            odaser.ShowDialog();
        }
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Kayıt için Boş Yerleri Lütfen Doldurunuz.");
            }
            else
            {
                if (textBox3.Text.All(char.IsDigit) &&
                    !textBox1.Text.All(char.IsDigit) &&
                    !textBox2.Text.All(char.IsDigit))
                {
                    istanbulOtel.Musterikayit().MusteriRezervasyonu(textBox1.Text, textBox2.Text, long.Parse(textBox3.Text));
                }
                else
                {
                    MessageBox.Show("Yanlış Birime Girdi Yapılmış. (Örnek; Tel numarası içinde yazı girilmiş olabilir)");
                }

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox6.Text.Equals("Film Koyulmadı."))
            {
                MessageBox.Show("Başlatılacak Film Seçmediniz.");
            }
            else if (textBox6.Text.Equals("Film Başlatılmaya Hazır."))
            {
                istanbulOtel.SinemaOrtamHazirla(new OrtamIsigi(), film, new DvdPlayer()).Filmİzle();
                textBox6.Text = "Film Başlatıldı.";
            }
            else if (textBox6.Text.Equals("Film Başlatıldı.") || textBox6.Text.Equals("Film Devam Ediyor."))
            {
                istanbulOtel.SinemaOrtamHazirla(new OrtamIsigi(), film, new DvdPlayer()).Durdur();
                textBox6.Text = "Film Durduruldu.";
            }
            else if (textBox6.Text.Equals("Film Durduruldu."))
            {
                istanbulOtel.SinemaOrtamHazirla(new OrtamIsigi(), film, new DvdPlayer()).DevamEt();
                textBox6.Text = "Film Devam Ediyor.";
            }
            else
            {
                MessageBox.Show("Film Seçilmedi");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void IstanbulOtell_Load(object sender, EventArgs e)
        {

            Kahvalti kahvalti = new Kahvalti();
            AksamYemegi aksamYemegi = new AksamYemegi();

            for(int i = 1; i < 3; i++)
            {
                if (i == 1)
                    treeView1.Nodes.Add("Kahvati");
                else
                    treeView1.Nodes.Add("Akşam Yemeği");
                for(int k = 0; k < 2; k++)
                {
                    if (i == 1)
                        treeView1.Nodes[i-1].Nodes.Add(kahvalti.itemleriGoster()[k].Isim + "  " + kahvalti.itemleriGoster()[k].Ucret + " TL");
                    else
                        treeView1.Nodes[i-1].Nodes.Add(aksamYemegi.itemleriGoster()[k].Isim +"  " + aksamYemegi.itemleriGoster()[k].Ucret + " TL");
                }
                  
            }
            //------------------------------------------

            listView1.Columns.Add("İsim", 70);
            listView1.Columns.Add("Soyİsim", 70);
            listView1.Columns.Add("Telefon", 70);

            ///-----------------------------------
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 30;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 1;

            textBox5.Text = ilkderece.ToString();
            //---------------------------------------------------
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox7.Text = istanbulOtel.ToString() + " asdfasf ";

            //---------------------------------------------------

            textBox6.Text = "Film Koyulmadı.";
            textBox4.Text = "Film Seçilmedi.";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

            int derece = trackBar1.Value;
            if (derece == 0)
            {
                istanbulOtel.KlimaAcKapa("K");
                textBox5.Text = trackBar1.Value.ToString();
            }
            else
            {
                istanbulOtel.KlimaAcKapa("A");
                
                if(ilkderece> derece)
                {
                    int fark = ilkderece - derece;
                    for(int i = 0; i < fark; i++)
                    {
                        istanbulOtel.KlimaDereceDegistir("K");
                    }

                    textBox5.Text = trackBar1.Value.ToString(); 
                    ilkderece = derece;
                }
                else
                {
                    int fark = derece - ilkderece;
                    for (int i = 0; i < fark; i++)
                    {
                        istanbulOtel.KlimaDereceDegistir("A");
                    }
                    textBox5.Text = trackBar1.Value.ToString();
                    ilkderece = derece;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox6.Text.Equals("Film Başlatıldı.") || textBox6.Text.Equals("Film Devam Ediyor."))
            {
                MessageBox.Show("Devam Film Varken Film Değiştiremezsiniz.");
            }
            else
            {
                if (!comboBox1.Text.Equals(""))
                {
                    textBox4.Text = comboBox1.Text;
                    film.Film = comboBox1.Text;
                    textBox6.Text = "Film Başlatılmaya Hazır.";

                }
                else
                {
                    MessageBox.Show("Film Seçmelisiniz.");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                listView1.Clear();
                listView1.Columns.Add("İsim", 70);
                listView1.Columns.Add("Soyİsim", 70);
                listView1.Columns.Add("Telefon", 70);
                if (istanbulOtel.Musterikayit().YeniSezonRezervasyonlariniGör() != null)
                {
                    for (int i = 0; i < istanbulOtel.Musterikayit().YeniSezonRezervasyonlariniGör().Count; i++)
                    {
                        string[] strings = { istanbulOtel.Musterikayit().YeniSezonRezervasyonlariniGör()[i].isim,
                            istanbulOtel.Musterikayit().YeniSezonRezervasyonlariniGör()[i].soyisim,
                            istanbulOtel.Musterikayit().YeniSezonRezervasyonlariniGör()[i].tel.ToString()};
                        ListViewItem item = new ListViewItem(strings);
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listView1.Clear();
                listView1.Columns.Add("İsim", 70);
                listView1.Columns.Add("Soyİsim", 70);
                listView1.Columns.Add("Telefon", 70);
                if (istanbulOtel.Musterikayit().TumMusterileriGor() != null)
                {
                    for (int i = 0; i < istanbulOtel.Musterikayit().TumMusterileriGor().Count; i++)
                    {
                        string[] strings = { istanbulOtel.Musterikayit().TumMusterileriGor()[i].isim,
                            istanbulOtel.Musterikayit().TumMusterileriGor()[i].soyisim,
                            istanbulOtel.Musterikayit().TumMusterileriGor()[i].tel.ToString()};
                        ListViewItem item = new ListViewItem(strings);
                        listView1.Items.Add(item);
                    }
                }
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            tabPage1.BackColor = colorDialog1.Color;
            tabPage2.BackColor = colorDialog1.Color;
            tabPage3.BackColor = colorDialog1.Color;
            tabPage4.BackColor = colorDialog1.Color;
            tabPage5.BackColor = colorDialog1.Color;
        }
    }
}
