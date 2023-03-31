using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BIG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string eıd;
        public string epw;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            t6.Text = eıd;
            t7.Text = epw;



        }
        private void t6_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        private void c2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        void kod()
        {
            Random rasgele = new Random();
            int sayı = rasgele.Next(10000, 100000);
            textBox2.Text = sayı.ToString();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            kod();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (t6.Text == eıd && t7.Text == epw && textBox1.Text == textBox2.Text && textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("Giriş Başarılı");
                t6.Clear();
                t7.Clear();
                textBox1.Clear();

                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol edin");
            }

            
        } 

        private void t7_TextChanged(object sender, EventArgs e)
        {

        }

        private void c2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (c2.CheckState == CheckState.Checked)
            {
                t7.UseSystemPasswordChar = true;
            }
            else if (c2.CheckState == CheckState.Unchecked)
            {
                t7.UseSystemPasswordChar = false;
            }
        }
    }
    }


