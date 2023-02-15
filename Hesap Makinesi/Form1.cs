using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double ilkSayi;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void TuslarinDegeri(int deger)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = deger.ToString();
            }
            else
            {
                textBox.Text = textBox.Text + deger.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TuslarinDegeri(0);
        }

        private void buttonNokta_Click(object sender, EventArgs e)
        {
            string deger = ",";

            if (textBox.Text != "," && textBox.Text != null)
            {
                textBox.Text = textBox.Text + deger;
            }
            else
            {
                textBox.Text = textBox.Text;
            }



            //textBox.Text = textBox.Text + ",";
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            islem = "+";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox.TextLength == 7)
            {
                textBox.Font = new Font("Microsoft Sans Serif", 30);
            }
            else if (textBox.TextLength == 10)
            {
                textBox.Font = new Font("Microsoft Sans Serif", 25);
            }
            else if (textBox.TextLength == 1)
            {
                textBox.Font = new Font("Microsoft Sans Serif", 48);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt32(textBox.Text);
            textBox.Text = "0";
            islem = "-";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt32(textBox.Text);
            textBox.Text = "0";
            islem = "*";
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt32(textBox.Text);
            textBox.Text = "0";
            islem = "/";
        }

        private void buttonKok_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt32(textBox.Text);
            islem = "√";
            textBox.Text = "√ ";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {

            double ikinciSayi;
            double sonuc;

            if (islem == "+")
            {
                ikinciSayi = Convert.ToDouble(textBox.Text);
                sonuc = ilkSayi + ikinciSayi;
                textBox.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }
            else if (islem == "-")
            {
                ikinciSayi = Convert.ToDouble(textBox.Text);
                sonuc = ilkSayi - ikinciSayi;
                textBox.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }
            else if (islem == "*")
            {
                ikinciSayi = Convert.ToDouble(textBox.Text);
                sonuc = ilkSayi * ikinciSayi;
                textBox.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }
            else if (islem == "/")
            {
                ikinciSayi = Convert.ToDouble(textBox.Text);
                if (ikinciSayi == 0)
                {
                    textBox.Text = "Hata!";

                }
                else
                {
                    sonuc = ilkSayi / ikinciSayi;
                    textBox.Text = Convert.ToString(sonuc);
                    ilkSayi = sonuc;
                }

            }

            if (islem == "√")
            {
                string sayi = textBox.Text;
                string[] parcali = sayi.Split(' ');
                ilkSayi = Convert.ToInt32(parcali[1]);
                sonuc = Math.Sqrt(ilkSayi);
                textBox.Text = Convert.ToString(sonuc);
            }
        }
    }
}
