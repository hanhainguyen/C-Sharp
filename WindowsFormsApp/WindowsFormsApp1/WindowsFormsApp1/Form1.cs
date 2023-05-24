using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string d1 = "", d2 = "", d3 = "", d4 = "", d5 = "";

        private void label4_Click(object sender, EventArgs e)
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
            list1.Items.Clear();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            float tong = 0;
            if(radioButton1.Checked==true)
            {
                a = 500;
                d1 = "Phòng đơn   " + a +"/Ngày";
            }
            if(radioButton2.Checked==true)
            {
                a=1000;
                d2 = "Phòng đôi   " + a +"/Ngày";
            }
            if(check1.Checked==true)
            {
                b = 200;
                d3 = "Internet   " + b;
            }
            if(check2.Checked==true)
            {
                b = 100;
                d4 = "Giặt là   " + b;
            }
            if(check2.Checked ==true && check1.Checked==true)
            {
                b = 300;
            }

            DateTime ngaydi = Convert.ToDateTime(date1.Value.ToString());
            DateTime ngayden = Convert.ToDateTime(date2.Value.ToString());
            TimeSpan Time = ngayden- ngaydi;
            c = Time.Days;
            tong = a*c + b;
            list1.Items.Add("Họ và tên: " + this.txta.Text);
            list1.Items.Add("Địa chỉ: " + this.txtb.Text);
            list1.Items.Add("Ngày đến: " + this.date1.Value.ToString("dd/MM/yyyy"));
            list1.Items.Add("Ngày đi: " + this.date2.Value.ToString("dd/MM/yyyy"));
            list1.Items.Add(" ");
            if(d1 != "")
            {
                list1.Items.Add("Loại phòng:  "+ d1);
            }
            if(d2 != "")
            {
                list1.Items.Add("Loại phòng:  " + d2);
            }
            if(d3 != "")
            {
                list1.Items.Add("Dịch vụ sử dụng:  "+ d3);
            }
            if(d4 != "")
            {
                list1.Items.Add("Dịch vụ sử dụng:  " + d4);
            }

            list1.Items.Add("Tổng:  " + tong.ToString());
            list1.Items.Add("-----------------------------");
            



        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
