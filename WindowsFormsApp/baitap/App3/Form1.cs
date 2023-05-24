using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public int soluongthit;
        public int soluongca;
        public int soluongrau;
        public int soluongnuockhoang;
        public int soluongcoca;
        public int soluongbia;
        public float tongtien = 0;
        public double thue;
        public double khuyenmai;
        public double tongtienthanhtoan = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == false)
            {
                txtthit.Visible = false;
                lblthit.Visible = false;
            }
            else
            {
                txtthit.Visible = true;
                lblthit.Visible = true;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == false)
            {
                txtca.Visible = false;
                lblca.Visible = false;
            }
            else
            {
                txtca.Visible = true;
                lblca.Visible = true;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == false)
            {
                txtrau.Visible = false;
                lblrau.Visible = false;
            }
            else
            {
                txtrau.Visible = true;
                txtrau.Visible = true;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == false)
            {
                txtnuockhoang.Visible = false;
                lblnuockhoang.Visible = false;
            }
            else
            {
                txtnuockhoang.Visible = true;
                lblnuockhoang.Visible = true;
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == false)
            {
                txtcoca.Visible = false;
                lblcoca.Visible = false;
            }
            else
            {
                txtcoca.Visible = true;
                lblcoca.Visible = true;
            }
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6.Checked == false)
            {
                txtbia.Visible = false;
                lblbia.Visible = false;
            }
            else
            {
                txtbia.Visible = true;
                lblbia.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstthanhtoan.Items.Add("Người bán hàng" + " " + ":" + " " + cboname.Text);
            lstthanhtoan.Items.Add("Ngày thanh toán" + " " + ":" + " " +dateTimePicker1.Text);
            if(txtthit.Visible==true)
            {
                lstthanhtoan.Items.Add("Thịt" + " " + txtthit.Text);
                soluongthit = int.Parse(txtthit.Text);
                tongtien = tongtien + (soluongthit * 100);
            }
            if(txtca.Visible==true)
            {
                lstthanhtoan.Items.Add("Cá" + " " + txtca.Text);
                soluongca = int.Parse(txtca.Text);
                tongtien = tongtien + (soluongca * 50);
            }
            if(txtrau.Visible==true)
            {
                lstthanhtoan.Items.Add("Rau" + " " + txtrau.Text);
                soluongrau = int.Parse(txtrau.Text);
                tongtien = tongtien + (soluongrau * 20);
            }
            if(txtnuockhoang.Visible==true)
            {
                lstthanhtoan.Items.Add("Nước khoáng" + " " + txtnuockhoang.Text);
                soluongnuockhoang = int.Parse(txtnuockhoang.Text);
                tongtien = tongtien + (soluongnuockhoang * 10);
            }
            if(txtcoca.Visible==true)
            {
                lstthanhtoan.Items.Add("Coca" + " " + txtcoca.Text);
                soluongcoca = int.Parse(txtcoca.Text);
                tongtien = tongtien + (soluongcoca * 15);
            }
            if(txtbia.Visible==true)
            {
                lstthanhtoan.Items.Add("Bia" + " " + txtbia.Text);
                soluongbia = int.Parse(txtbia.Text);
                tongtien = tongtien + (soluongbia * 15);
            }
            if(rdo1.Checked == true)
            {
                khuyenmai = tongtien * 10.0/100;
                lstthanhtoan.Items.Add("Khuyến mãi :" + " " + khuyenmai.ToString());
                thue = khuyenmai;
                lstthanhtoan.Items.Add("Thuế :" + " " + thue.ToString());
                lstthanhtoan.Items.Add("Tổng tiền :" + tongtien.ToString());
                tongtienthanhtoan = tongtien - khuyenmai + thue;
            }
            if(rdo2.Checked == true)
            {
                thue = tongtien * 10.0 / 100;
                lstthanhtoan.Items.Add("Thuế :" + " " + thue.ToString());
                tongtienthanhtoan = tongtien + thue;
            }
            
            lstthanhtoan.Items.Add("--------------------------------------------");
            if(tongtienthanhtoan!=0)
            {
                lstthanhtoan.Items.Add("Tổng tiền thanh toán:" + tongtienthanhtoan.ToString());
            }
        }
    }
}
