using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaiPhuongTrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                float a = float.Parse(textBoxa.Text);
                float b = float.Parse(textBoxb.Text);
                textBoxc.Visible = false;
                labelc.Visible = false;
                if (a == 0 && b != 0)
                {
                    textBoxkq.Text = "Phuong trinh bac nhat vo nghiem";
                }
                else
                {
                    float x = -b / a;
                    textBoxkq.Text = x.ToString();
                }
            }
            else if (radioButton2.Checked == true)
            {
                float a = float.Parse(textBoxa.Text);
                float b = float.Parse(textBoxb.Text);
                float c = float.Parse(textBoxc.Text);
                float d = b * b - 4 * a * c;
                double x1, x2;
                if (a == 0)
                {
                    textBoxa.Text = " a phai khac 0";
                }
                else
                {
                    if (d < 0)
                    {
                        textBoxkq.Text = "Phuong trinh vo nghiem";
                    }
                    else if (d > 0)
                    {
                        x1 = Math.Round((-b - Math.Sqrt(d)) / 2 * a,3);
                        x2 = Math.Round((-b + Math.Sqrt(d)) / 2 * a,3);
                        textBoxkq.Text = "Phuong trinh co hai nghiem phan biet: " + "x1 = " + x1.ToString() + " va " + "x2 =" + x2.ToString();
                    }
                    else if (d == 0)
                    {
                        x1 = Math.Round(-b / 2 * a, 3);
                        textBoxkq.Text = "Phuong trinh co nghiem kep: " + "x1 = x2 = " + x1.ToString();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxa.Clear();
            textBoxb.Clear();
            textBoxc.Clear();
            textBoxkq.Clear();
            textBoxc.Visible = true;
            labelc.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxc.Visible = false;
            labelc.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxc.Visible = true;
            labelc.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
