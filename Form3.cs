using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG
{
    public partial class Form3 : Form
    {
        int sayac = 0;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac % 2 == 0)
            {
                label1.BackColor = Color.DarkRed;
                
            }
            else
            {
                label1.BackColor = Color.Black;
               
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            

        } 
    }
}
