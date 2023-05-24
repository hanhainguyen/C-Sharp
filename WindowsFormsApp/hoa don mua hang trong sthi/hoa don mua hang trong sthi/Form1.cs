using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoa_don_mua_hang_trong_sthi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string v1 = "", v2 = "", v3 = "", v4 = "", v5 = "", v6 = "", v7 = "";
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (check2.Checked == true)
            {
                txt2.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            combo1.Items.Add("aaaaaaaaaaaaaa");
            
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = 0, b = 0, c = 0, d = 0, x = 0, f = 0, a11 = 0, b11 = 0, c11 = 0, d11 = 0, x11 = 0, f11 = 0;
            float a1 = 0, b1 = 0, c1 = 0;
            int d1 = 0,x1=0,f1 = 0;
            double tong = 0, m = 0, tong1 = 0, tong2 = 0;
            if(check1.Checked == true)
            {
                a1= float.Parse(txt1.Text);
                a = 200 * a1;
                a11 = 200;
                v1 = "Thịt " + a11 + "/kg";
            }
            if(check2.Checked == true)
            {
                b1= float.Parse(txt2.Text);
                b = 100 * b1;
                b11 = 100;
                v2 = "Cá " + b11 + "/kg";
            }
            if(check3.Checked == true)
            {
                c1= float.Parse(txt3.Text);
                c = 50 * c1;
                c11 = 50;
                v3 = "Rau xanh " + c11 + "/kg";
            }
            if(check4.Checked == true)
            {
                d1= int.Parse(txt4.Text);
                d = 10 * d1;
                d11 = 10;   
                v4 = "Nước khoáng " + d11 +"/chai";
            }
            if(check5.Checked == true)
            {
                x1= int.Parse(txt5.Text);
                x = 20 * f1;
                x11 = 20;
                v5 = "Coca " + x11 + "/chai";
            }
            if(check6.Checked == true)
            {
                f1 = int.Parse(txt6.Text);
                f = 30 * f1;
                f11 = 30;
                v6 = "Bia " + f11 + "/lon";
            }
            tong = (a + b + c + d + x + f);
            tong1= (a + b + c + d + x + f)+ ((a + b + c + d + x + f) / 100) * 10;
            m = ((a + b + c + d + x + f) / 100) * 10;
            if (radioButton1.Checked==true)
            {
                tong2 = tong1 - ((tong1 / 100) * 20);
                v7 = "" + tong / 100 * 20;
                
            }
            else
            {
                tong2 = tong1;
                v7 = "" + 0;
            }
            list1.Items.Add("Người bán hàng: " + this.combo1.Text);
            list1.Items.Add("Ngày: " + this.date1.Value.ToString("dd/MM/yyyy"));
            list1.Items.Add("");
            if(v1 !="")
            {
                list1.Items.Add(v1);
            }
            if (v2 != "")
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
            list1.Items.Add("VAT 10% = " + m.ToString());
            list1.Items.Add("Khách hàng thân thiết giảm 20% = " + v7);
            list1.Items.Add("Tong Thanh toan = "+ tong2.ToString());
            list1.Items.Add("-------------------------");
            list1.Items.Add("Cam on quy khach");


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();
            combo1.Items.Clear();
            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
            check4.Checked = false;
            check5.Checked = false;
            check6.Checked = false;
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            radioButton1.Checked = false;
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if(check1.Checked == true)
            {
                txt1.Visible=true;
            }
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if (check3.Checked == true)
            {
                txt3.Visible = true;
            }
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked == true)
            {
                txt4.Visible = true;
            }
        }

        private void check5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5.Checked == true)
            {
                txt5.Visible = true;
            }
        }

        private void check6_CheckedChanged(object sender, EventArgs e)
        {
            if (check6.Checked == true)
            {
                txt6.Visible = true;
            }
        }
    }
}
