using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sochanleinratinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int tong = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            a= int.Parse(txta.Text);
            txtb.Text += txta.Text + " ";
            if (a%2==0)
            {
                txtc.Text += txta.Text + " ";
                tong = tong + a;
            }
            txta.Text = " ";
           
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtt.Text=tong.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear(); 
            txtc.Clear();
            txtt.Clear();
        }
    }
}
