using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char islem;
        bool cikti_Clears;
        float ilksayi;
        public Form1()
        {

            InitializeComponent(); 
        }

        private void Label_Clear_Click(object sender, EventArgs e)
        {
            cikti.Text = "0";
            onceki_islem.Text = "";
        }

        private void rakam_8_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "8";
            
        }

        private void carpi_Click(object sender, EventArgs e)
        {
            islem = 'x';
            cikti_Clears = true;
            ilksayi = Convert.ToUInt32(cikti.Text);
            onceki_islem.Text = cikti.Text + " x ";
        }

        private void rakam_1_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "1";
        }

        private void rakam_2_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "2";
        }

        private void rakam_3_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "3";
        }

        private void rakam_4_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "4";
        }

        private void rakam_5_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "5";
        }

        private void rakam_6_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "6";
        }

        private void rakam_7_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "7";
        }

        private void rakam_9_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "9";
        }

        private void rakam_0_Click(object sender, EventArgs e)
        {
            if (cikti_Clears)
            {
                cikti.Text = "";
                cikti_Clears = false;
            }
            if (cikti.Text == "0") cikti.Text = "";
            cikti.Text += "0";
        }

        private void arti_Click(object sender, EventArgs e)
        {
            islem = '+';
            cikti_Clears = true;
            ilksayi = Convert.ToUInt32(cikti.Text);
            onceki_islem.Text = cikti.Text+" + ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float ikinciSayi = Convert.ToInt32(cikti.Text);
            float Sonuc;
            switch (islem)
            {
                case '+':
                    Sonuc = ilksayi + ikinciSayi;
                    break;
                case '-':
                    Sonuc = ilksayi - ikinciSayi;
                    break;
                case 'x':
                    Sonuc = ilksayi * ikinciSayi;
                    break;
                case '÷':
                    Sonuc = ilksayi / ikinciSayi;
                    break;
                case '%':
                    Sonuc = ilksayi % ikinciSayi;
                    break;
                default:
                    Sonuc = 0;
                    break;
            }
           cikti.Text = Convert.ToString(Sonuc);
            if(islem == '+')
            {
                onceki_islem.Text = ilksayi + " + " + ikinciSayi + " = ";
            }
            if (islem == '-')
            {
                onceki_islem.Text = ilksayi + " - " + ikinciSayi + " = ";
            }
            if (islem == 'x')
            {
                onceki_islem.Text = ilksayi + " x " + ikinciSayi + " = ";
            }
            if (islem == '÷')
            {
                onceki_islem.Text = ilksayi + " ÷ " + ikinciSayi + " = ";
            }
            if (islem == '%')
            {
                onceki_islem.Text = ilksayi + " % " + ikinciSayi + " = ";
            }

        }

        private void eksi_Click(object sender, EventArgs e)
        {
            islem = '-';
            cikti_Clears = true;
            ilksayi = Convert.ToUInt32(cikti.Text);
            onceki_islem.Text = cikti.Text + " - ";
        }

        private void bolum_Click(object sender, EventArgs e)
        {
            islem = '÷';
            cikti_Clears = true;
            ilksayi = Convert.ToUInt32(cikti.Text);
            onceki_islem.Text = cikti.Text + " ÷ ";
        }

        private void modal_Click(object sender, EventArgs e)
        {
            islem = '%';
            cikti_Clears = true;
            ilksayi = Convert.ToUInt32(cikti.Text);
            onceki_islem.Text = cikti.Text + " % ";

        }
    }
}
