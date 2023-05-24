using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkud_giai_pt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

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
            txtkq.Clear();  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Visible = false;
            labelc.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Visible = true;
            labelc.Visible = true;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                float a= float.Parse(txta.Text);
                float b= float.Parse(txtb.Text);
                txtc.Visible=false;
                labelc.Visible=false;
                if (a == 0 && b!=0)
                {
                    txtkq.Text = "Phuong trinh bac nhat vo nghiem";
                }
                else
                {
                    float x = -b / a;
                    txtkq.Text = x.ToString();
                }
            }
            else if (radioButton2.Checked==true)
            {
                float a = float.Parse(txta.Text);
                float b = float.Parse(txtb.Text);
                float c = float.Parse(txtc.Text);
                float d = b * b - 4 * a * c;
                double x1,x2;
                if(a==0)
                {
                    txta.Text = "a phai khac 0";
                }
                else
                {
                    if(d<0)
                    {
                        txtkq.Text = "Phuong trinh vo nghiem";
                    }
                    else if (d>0)
                    {
                        x1 =Math.Round(-b - Math.Sqrt(d) / 2*a,3);
                        x2 =Math.Round(-b + Math.Sqrt(d) / 2*a,3);
                        txtkq.Text = "Phuong trinh co hai nghiem phan biet la X1 = " + x1.ToString() + " va X2 = " + x2.ToString();
                    }
                    else if (d==0)
                    {
                        x1= Math.Round(-b/2*a,3);
                        txtkq.Text= "Phuong trinh co nghiem kep X1 = X2 = " + x1.ToString();
                    }
                }
            }
        }
    }
}
