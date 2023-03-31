using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BIG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        string sname;
        string ıd;
        string pw;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            name = t1.Text; 
            sname = t2.Text;
            ıd= t3.Text;
            pw = t4.Text;

            MessageBox.Show("Kayıt başarılı");

           Form2 frm = new Form2();
           frm.eıd = t3.Text;
           frm.epw = t4.Text;
           frm.Show();
           this.Hide();

            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (c1.CheckState == CheckState.Checked)
            {
                t4.UseSystemPasswordChar = true;
            }
            else if (c1.CheckState == CheckState.Unchecked)
            {
                t4.UseSystemPasswordChar = false;
            }
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac % 2 == 0)
            {
                label3.ForeColor = Color.Red;
            }
            else 
            { 
                label3.ForeColor = Color.WhiteSmoke; 
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
