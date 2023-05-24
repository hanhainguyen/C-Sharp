using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace trasua
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public string v1 = "", v2 = "", v3 = "", v4 = "", v5 = "", v6 = "", v7 = "", v8 = "", v9 = "", v10 = "", v11 = "", v12 = "", v13 = "", v14 = "";

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nguyen");
            comboBox1.Items.Add("Giang");
            comboBox1.Items.Add("Quan");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            comboBox1.ResetText();  
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();   
            textBox6.Clear(); 
            textBox7.Clear(); 
            textBox8.Clear();   
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked=false;
            checkBox3.Checked=false;
            checkBox4.Checked=false;
            checkBox5.Checked=false;
            checkBox6.Checked=false;
            checkBox7.Checked=false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked== true)
                textBox2.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tra sau PVL");
            listBox1.Items.Add("\t--------Hoa don Ban 2--------- ");
            float a = 0, a1 = 0, b = 0, b1 = 0, c = 0, c1 = 0, d = 0, d1 = 0, f = 0, f1 = 0, g = 0, g1 = 0, h = 0, h1 = 0;
            int a11 = 0, b11 = 0, c11 = 0, d11 = 0, f11 = 0, g11 = 0, h11 = 0;
            double tong = 0, tong1 = 0, tong2 = 0, tong3 = 0;
            if (checkBox1.Checked == true)
            {
                a11 = int.Parse(textBox2.Text);
                a = 50;
                a1 = 50 * a11;
                v1 = "Cafe sua da " + "\t" + a11 + "\t" + a + "\t " + a1;
            }
            if (checkBox2.Checked == true)
            {
                b11 = int.Parse(textBox3.Text);
                b = 70;
                b1 = 70 * b11;
                v2 = "Cafe den " + "\t" + b11 + "\t" + b + "\t " + b1;
            }
            if (checkBox3.Checked == true)
            {
                c11 = int.Parse(textBox4.Text);
                c = 80;
                c1 = 80 * c11;
                v3 = "Nuoc ep dua " + "\t" + c11 + "\t" + c + "\t " + c1;
            }
            if (checkBox4.Checked == true)
            {
                d11 = int.Parse(textBox7.Text);
                d = 90;
                d1 = 90 * d11;
                v4 = "Nuoc ep oi " + "\t" + d11 + "\t" + d + "\t " + d1;
            }
            if (checkBox5.Checked == true)
            {
                f11 = int.Parse(textBox6.Text);
                f = 100;
                f1 = 100 * f11;
                v5 = "Hoa qua dam " + "\t" + f11 + "\t" + f + "\t " + f1;
            }
            if (checkBox6.Checked == true)
            {
                g11 = int.Parse(textBox5.Text);
                g = 40;
                g1 = 40 * g11;
                v6 = "Sua chua danh da " + "\t" + g11 + "\t" + g + "\t " + g1;
            }
            if (checkBox7.Checked == true)
            {
                h11 = int.Parse(textBox8.Text);
                h = 20;
                h1 = 20 * h11;
                v7 = "Tra chanh " + "\t" + h11 + "\t" + h + "\t " + h1;
            }
            tong = a1 + b1 + c1 + d1 + f1 + g1 + h1;
            if (radioButton1.Checked == true)
            {
                tong1 = tong / 100 * 20;
            }
            if (radioButton2.Checked == true)
            {
                tong2 = tong / 100 * 10;
            }
            tong3 = tong - tong1 - tong2;
            listBox1.Items.Add("Nhan vien ban hang: " + "\t" + this.comboBox1.Text);
            listBox1.Items.Add("Ngay ban hang : " + "\t\t" + this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            listBox1.Items.Add("Ho ten khach hang: " + "\t" + this.textBox1.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Ten Mon \t SL \t DG \t TT");
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            if (v1 != "")
            {
                listBox1.Items.Add(v1);
            }
            if (v2 != "")
            {
                listBox1.Items.Add(v2);
            }
            if (v3 != "")
            {
                listBox1.Items.Add(v3);
            }
            if (v4 != "")
            {
                listBox1.Items.Add(v4);
            }
            if (v5 != "")
            {
                listBox1.Items.Add(v5);
            }
            if (v6 != "")
            {
                listBox1.Items.Add(v6);
            }
            if (v7 != "")
            {
                listBox1.Items.Add(v7);
            }
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            listBox1.Items.Add("Tong Tien   " + "\t\t\t" + tong.ToString());
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Sinh vien giam 20%   " + "\t\t" + tong1.ToString());
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("VIP giam 10%   " + "\t\t\t" + tong2.ToString());
            }
            listBox1.Items.Add("Tong tien phai thanh toan   " + "\t\t" + tong3.ToString());
            listBox1.Items.Add("");
            listBox1.Items.Add("\t-------------Cam on quy khach---------");
            listBox1.Items.Add("");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tra sau PVL");
            listBox1.Items.Add("\t--------Hoa don Ban 3--------- ");
            float a = 0, a1 = 0, b = 0, b1 = 0, c = 0, c1 = 0, d = 0, d1 = 0, f = 0, f1 = 0, g = 0, g1 = 0, h = 0, h1 = 0;
            int a11 = 0, b11 = 0, c11 = 0, d11 = 0, f11 = 0, g11 = 0, h11 = 0;
            double tong = 0, tong1 = 0, tong2 = 0, tong3 = 0;
            if (checkBox1.Checked == true)
            {
                a11 = int.Parse(textBox2.Text);
                a = 50;
                a1 = 50 * a11;
                v1 = "Cafe sua da " + "\t" + a11 + "\t" + a + "\t " + a1;
            }
            if (checkBox2.Checked == true)
            {
                b11 = int.Parse(textBox3.Text);
                b = 70;
                b1 = 70 * b11;
                v2 = "Cafe den " + "\t" + b11 + "\t" + b + "\t " + b1;
            }
            if (checkBox3.Checked == true)
            {
                c11 = int.Parse(textBox4.Text);
                c = 80;
                c1 = 80 * c11;
                v3 = "Nuoc ep dua " + "\t" + c11 + "\t" + c + "\t " + c1;
            }
            if (checkBox4.Checked == true)
            {
                d11 = int.Parse(textBox7.Text);
                d = 90;
                d1 = 90 * d11;
                v4 = "Nuoc ep oi " + "\t" + d11 + "\t" + d + "\t " + d1;
            }
            if (checkBox5.Checked == true)
            {
                f11 = int.Parse(textBox6.Text);
                f = 100;
                f1 = 100 * f11;
                v5 = "Hoa qua dam " + "\t" + f11 + "\t" + f + "\t " + f1;
            }
            if (checkBox6.Checked == true)
            {
                g11 = int.Parse(textBox5.Text);
                g = 40;
                g1 = 40 * g11;
                v6 = "Sua chua danh da " + "\t" + g11 + "\t" + g + "\t " + g1;
            }
            if (checkBox7.Checked == true)
            {
                h11 = int.Parse(textBox8.Text);
                h = 20;
                h1 = 20 * h11;
                v7 = "Tra chanh " + "\t" + h11 + "\t" + h + "\t " + h1;
            }
            tong = a1 + b1 + c1 + d1 + f1 + g1 + h1;
            if (radioButton1.Checked == true)
            {
                tong1 = tong / 100 * 20;
            }
            if (radioButton2.Checked == true)
            {
                tong2 = tong / 100 * 10;
            }
            tong3 = tong - tong1 - tong2;
            listBox1.Items.Add("Nhan vien ban hang: " + "\t" + this.comboBox1.Text);
            listBox1.Items.Add("Ngay ban hang : " + "\t\t" + this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            listBox1.Items.Add("Ho ten khach hang: " + "\t" + this.textBox1.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Ten Mon \t SL \t DG \t TT");
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            if (v1 != "")
            {
                listBox1.Items.Add(v1);
            }
            if (v2 != "")
            {
                listBox1.Items.Add(v2);
            }
            if (v3 != "")
            {
                listBox1.Items.Add(v3);
            }
            if (v4 != "")
            {
                listBox1.Items.Add(v4);
            }
            if (v5 != "")
            {
                listBox1.Items.Add(v5);
            }
            if (v6 != "")
            {
                listBox1.Items.Add(v6);
            }
            if (v7 != "")
            {
                listBox1.Items.Add(v7);
            }
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            listBox1.Items.Add("Tong Tien   " + "\t\t\t" + tong.ToString());
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Sinh vien giam 20%   " + "\t\t" + tong1.ToString());
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("VIP giam 10%   " + "\t\t\t" + tong2.ToString());
            }
            listBox1.Items.Add("Tong tien phai thanh toan   " + "\t\t" + tong3.ToString());
            listBox1.Items.Add("");
            listBox1.Items.Add("\t-------------Cam on quy khach---------");
            listBox1.Items.Add("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tra sau PVL");
            listBox1.Items.Add("\t--------Hoa don Ban 4--------- ");
            float a = 0, a1 = 0, b = 0, b1 = 0, c = 0, c1 = 0, d = 0, d1 = 0, f = 0, f1 = 0, g = 0, g1 = 0, h = 0, h1 = 0;
            int a11 = 0, b11 = 0, c11 = 0, d11 = 0, f11 = 0, g11 = 0, h11 = 0;
            double tong = 0, tong1 = 0, tong2 = 0, tong3 = 0;
            if (checkBox1.Checked == true)
            {
                a11 = int.Parse(textBox2.Text);
                a = 50;
                a1 = 50 * a11;
                v1 = "Cafe sua da " + "\t" + a11 + "\t" + a + "\t " + a1;
            }
            if (checkBox2.Checked == true)
            {
                b11 = int.Parse(textBox3.Text);
                b = 70;
                b1 = 70 * b11;
                v2 = "Cafe den " + "\t" + b11 + "\t" + b + "\t " + b1;
            }
            if (checkBox3.Checked == true)
            {
                c11 = int.Parse(textBox4.Text);
                c = 80;
                c1 = 80 * c11;
                v3 = "Nuoc ep dua " + "\t" + c11 + "\t" + c + "\t " + c1;
            }
            if (checkBox4.Checked == true)
            {
                d11 = int.Parse(textBox7.Text);
                d = 90;
                d1 = 90 * d11;
                v4 = "Nuoc ep oi " + "\t" + d11 + "\t" + d + "\t " + d1;
            }
            if (checkBox5.Checked == true)
            {
                f11 = int.Parse(textBox6.Text);
                f = 100;
                f1 = 100 * f11;
                v5 = "Hoa qua dam " + "\t" + f11 + "\t" + f + "\t " + f1;
            }
            if (checkBox6.Checked == true)
            {
                g11 = int.Parse(textBox5.Text);
                g = 40;
                g1 = 40 * g11;
                v6 = "Sua chua danh da " + "\t" + g11 + "\t" + g + "\t " + g1;
            }
            if (checkBox7.Checked == true)
            {
                h11 = int.Parse(textBox8.Text);
                h = 20;
                h1 = 20 * h11;
                v7 = "Tra chanh " + "\t" + h11 + "\t" + h + "\t " + h1;
            }
            tong = a1 + b1 + c1 + d1 + f1 + g1 + h1;
            if (radioButton1.Checked == true)
            {
                tong1 = tong / 100 * 20;
            }
            if (radioButton2.Checked == true)
            {
                tong2 = tong / 100 * 10;
            }
            tong3 = tong - tong1 - tong2;
            listBox1.Items.Add("Nhan vien ban hang: " + "\t" + this.comboBox1.Text);
            listBox1.Items.Add("Ngay ban hang : " + "\t\t" + this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            listBox1.Items.Add("Ho ten khach hang: " + "\t" + this.textBox1.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Ten Mon \t SL \t DG \t TT");
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            if (v1 != "")
            {
                listBox1.Items.Add(v1);
            }
            if (v2 != "")
            {
                listBox1.Items.Add(v2);
            }
            if (v3 != "")
            {
                listBox1.Items.Add(v3);
            }
            if (v4 != "")
            {
                listBox1.Items.Add(v4);
            }
            if (v5 != "")
            {
                listBox1.Items.Add(v5);
            }
            if (v6 != "")
            {
                listBox1.Items.Add(v6);
            }
            if (v7 != "")
            {
                listBox1.Items.Add(v7);
            }
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            listBox1.Items.Add("Tong Tien   " + "\t\t\t" + tong.ToString());
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Sinh vien giam 20%   " + "\t\t" + tong1.ToString());
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("VIP giam 10%   " + "\t\t\t" + tong2.ToString());
            }
            listBox1.Items.Add("Tong tien phai thanh toan   " + "\t\t" + tong3.ToString());
            listBox1.Items.Add("");
            listBox1.Items.Add("\t-------------Cam on quy khach---------");
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                textBox4.Visible = true;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                textBox5.Visible = true;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                textBox6.Visible = true;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                textBox7.Visible = true;

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                textBox8.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tra sau PVL");
            listBox1.Items.Add("\t--------Hoa don Ban 1--------- ");
            float a = 0, a1 = 0, b = 0, b1 = 0, c = 0, c1 = 0, d = 0, d1 = 0, f = 0, f1 = 0, g = 0, g1 = 0, h = 0, h1 = 0;
            int a11 = 0, b11 = 0, c11 = 0, d11 = 0, f11 = 0, g11 = 0, h11 = 0, k = 0;
            double tong = 0, tong1 = 0, tong2 = 0, tong3 = 0;
            if (checkBox1.Checked == true)
            {
                a11 = int.Parse(textBox2.Text);
                a = 50;
                a1 = 50 * a11;
                v1 = "Cafe sua da " + "\t" + a11 + "\t" + a + "\t " + a1;
            }
            if (checkBox2.Checked == true)
            {
                b11 = int.Parse(textBox3.Text);
                b = 70;
                b1 = 70 * b11;
                v2 = "Cafe den " + "\t" + b11 + "\t" + b + "\t " + b1;
            }
            if (checkBox3.Checked == true)
            {
                c11 = int.Parse(textBox4.Text);
                c = 80;
                c1 = 80 * c11;
                v3 = "Nuoc ep dua " + "\t" + c11 + "\t" + c + "\t " + c1;
            }
            if (checkBox4.Checked == true)
            {
                d11 = int.Parse(textBox7.Text);
                d = 90;
                d1 = 90 * d11;
                v4 = "Nuoc ep oi " + "\t" + d11 + "\t" + d + "\t " + d1;
            }
            if (checkBox5.Checked == true)
            {
                f11 = int.Parse(textBox6.Text);
                f = 100;
                f1 = 100 * f11;
                v5 = "Hoa qua dam " + "\t" + f11 + "\t" + f + "\t " + f1;
            }
            if (checkBox6.Checked == true)
            {
                g11 = int.Parse(textBox5.Text);
                g = 40;
                g1 = 40 * g11;
                v6 = "Sua chua danh da " + "\t" + g11 + "\t" + g + "\t " + g1;
            }
            if (checkBox7.Checked == true)
            {
                h11 = int.Parse(textBox8.Text);
                h = 20;
                h1 = 20 * h11;
                v7 = "Tra chanh " + "\t" + h11 + "\t" + h + "\t " + h1;
            }
            tong = a1 + b1 + c1 + d1 + f1 + g1 + h1;
            if (radioButton1.Checked == true)
            {
                tong1 = tong / 100 * 20;
            }
            if (radioButton2.Checked == true)
            {
                tong2 = tong / 100 * 10;
            }
            tong3 = tong - tong1 - tong2;
            listBox1.Items.Add("Nhan vien ban hang: "+"\t"+this.comboBox1.Text);
            listBox1.Items.Add("Ngay ban hang : "+"\t\t"+this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            listBox1.Items.Add("Ho ten khach hang: "+"\t"+this.textBox1.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Ten Mon \t SL \t DG \t TT");
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            if (v1 != "")
            {
                listBox1.Items.Add(v1);
            }
            if (v2 != "")
            {
                listBox1.Items.Add(v2);
            }
            if (v3 != "")
            {
                listBox1.Items.Add(v3);
            }
            if (v4 != "")
            {
                listBox1.Items.Add(v4);
            }
            if (v5 != "")
            {
                listBox1.Items.Add(v5);
            }
            if (v6 != "")
            {
                listBox1.Items.Add(v6);
            }
            if (v7 != "")
            {
                listBox1.Items.Add(v7);
            }
            listBox1.Items.Add("--------------------------------------------------------------------------------");
            listBox1.Items.Add("Tong Tien   " + "\t\t\t" + tong.ToString());
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Sinh vien giam 20%   " + "\t\t" + tong1.ToString());
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("VIP giam 10%   " + "\t\t\t" + tong2.ToString());
            }
            listBox1.Items.Add("Tong tien phai thanh toan   " + "\t\t" + tong3.ToString());
            listBox1.Items.Add("");
            listBox1.Items.Add("\t-------------Cam on quy khach---------");
            listBox1.Items.Add("");
            StreamWriter writer = new StreamWriter("Banso1");
            writer.WriteLine(listBox1.ToString());
            writer.Close(); 
            
        }
    }
}
