using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_top_17_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string v1 = "", v2 = "", v3 = "", v4 = "", v5 = "", v6 = "";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt6.Clear();
            txt5.Clear();
            txt4.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nguyen");
            comboBox1.Items.Add("Hiep");
            comboBox1.Items.Add("Tu");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txt1.Visible = true;    
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked ==true)
            {
                txt2.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txt3.Visible = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                txt6.Visible = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                txt5.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                txt4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = 0, b = 0, c = 0, d = 0, g = 0, f = 0, a11 = 0, b11 = 0, c11 = 0, d11 = 0, g11 = 0, f11 = 0;
            float a1 = 0, b1 = 0, c1 = 0;
            int d1=0, g1=0, f1=0;
            float tong = 0, tong1 = 0, vat = 0, vip = 0, vip1 = 0;
            if(checkBox1.Checked == true)
            {
                a1= float.Parse(txt1.Text);
                a = 10 * a1;
                a11 = 10;
                v1 = "rau = " + a11 + "/kg";
            }
            if(checkBox2.Checked == true)
            {
                b1= float.Parse(txt2.Text);
                b = 20 * b1;
                b11= 20;
                v2 = "thit = " + b11 + "/kg";
            }
            if(checkBox3.Checked == true)
            {
                c1= float.Parse(txt3.Text);
                c= 30 * c1;
                c11= 30;
                v3 = "ca = " + c11 + "/kg";
            }
            if(checkBox4.Checked == true)
            {
                d1 = int.Parse(txt4.Text);
                d = 5 * d1;
                d11 = 5;
                v4 = "nuoc khoang = " + d11 + "/chai";
            }
            if(checkBox5.Checked == true)
            {
                g1= int.Parse(txt5.Text);
                g= 10 * g1;
                g11= 10;
                v5 = "coca = " + g11 + "/lon";
            }
            if(checkBox6.Checked == true)
            {
                f1= int.Parse(txt6.Text); 
                f = 15 * f1;
                f11= 15;
                v6 = "bia = " + f11 + "/lon";
            }
            tong = a + b + c + d + g + f;
            vat = (tong / 100) * 10;
            vip = ((tong + vat) / 100) * 10;

            if (radioButton1.Checked == true)
            {
                tong1 = tong + vat;
                vip1 = 0;
            }
            if(radioButton2.Checked == true)
            {
                tong1 = tong + vat - vip;
                vip1 = vip;
            }
            list1.Items.Add("Nguoi ban : " + this.comboBox1.Text);
            list1.Items.Add("Ngay ban : " + this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            list1.Items.Add("");
            if(v1 != "")
            {
                list1.Items.Add(v1);
            }
            if(v2 !="")
            {
                list1.Items.Add(v2);
            }
            if (v3 != "")
            {
                list1.Items.Add(v3);
            }
            if (v4 != "")
            {
                list1.Items.Add(v4);
            }
            if (v5 != "")
            {
                list1.Items.Add(v5);
            }
            if (v6 != "")
            {
                list1.Items.Add(v6);
            }
            list1.Items.Add("Tong = " + tong.ToString());
            list1.Items.Add("VAT 10% = "+ vat.ToString());
            list1.Items.Add("Khach hang than thiet giam 10% = " + vip1.ToString());
            list1.Items.Add("Tong thanh toan = " + tong1.ToString());
            list1.Items.Add("-----------------------------------");
            list1.Items.Add("Cam on quy khach ");



        }
    }
}
