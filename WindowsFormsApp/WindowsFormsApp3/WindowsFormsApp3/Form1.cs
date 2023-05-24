using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string v1 = "", v2 = "", v3 = "", v4 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nguyen");
            comboBox1.Items.Add("Tri");
            comboBox1.Items.Add("Dung");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            checkBox1.Checked = false;
            checkBox2.Checked = false;  
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            txt1.Clear();
            txt2.Clear(); 
            list1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                txt1.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                txt2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = 0, b = 0, c = 0, d = 0, a11 = 0, b11 = 0, c11 = 0, d11 = 0, f = 1000, m = 0;
            int c1 = 0, d1 = 0,  h= 0;
            double tong = 0;
            if(checkBox1.Checked==true)
            {
                a = 200;
                v1 = "Giặt là " + a;
            }
            if(checkBox2.Checked==true)
            {
                b = 100;
                v2 = "Internet " + b;
            }
            if(checkBox3.Checked==true)
            {
                c1 = int.Parse(txt1.Text);
                c = 10 * c1;
                c11 = 10;
                v3 = "Nước khoáng " + c11 + "/chai";
            }
            if (checkBox4.Checked==true)
            {
                d1= int.Parse(txt2.Text);
                d = 30 * d1;
                d11 = 30;
                v4 = "Coca " + d11 + "/lon";
            }
            DateTime ngayden = Convert.ToDateTime(dateTimePicker1.Value.ToString());
            DateTime ngaydi = Convert.ToDateTime(dateTimePicker2.Value.ToString());
            TimeSpan Time= ngaydi - ngayden;
            h = Time.Days;
            m = h * f;
            tong = a + b + c + d + m;
            list1.Items.Add("Nhân viên lễ tân: " + this.comboBox1.Text);
            list1.Items.Add("Ngày đến: " + this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            list1.Items.Add("Ngày đi: " + this.dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            list1.Items.Add("");
            if(v1!="")
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
            list1.Items.Add("Tong = " + tong.ToString());
            list1.Items.Add("-------------------------");
            list1.Items.Add("Cam on quy khach");
            if(c1<0)
            {
                MessageBox.Show("Nhap sai du lieu ");
            }
            if(d1<0)
            {
                MessageBox.Show("Nhap sai du lieu ");
            }
        }
    }
}
