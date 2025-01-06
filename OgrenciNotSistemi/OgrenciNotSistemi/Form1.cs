using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(textBox2.Text);
            s2 = Convert.ToInt16(textBox3.Text);
            s3 = Convert.ToInt16(textBox4.Text);
            ort = (s1 + s2 + s3) / 3;
            textBox5.Text = ort.ToString();

            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            textBox6.Text = durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox6.Text!="" && textBox5.Text != "")
            {
                string adSoyad, ders, numara;
                adSoyad = textBox1.Text;
                ders = comboBox1.Text;
                numara = maskedTextBox1.Text;
                listBox1.Items.Add(adSoyad + " Ders:" + ders + " Numara:" + numara + " Ortalama:" + textBox5.Text + " Durum:" + textBox6.Text);
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durum hesabını yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Clear();
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
