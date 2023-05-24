using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox2.ResetText();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ho ten: " + "\t" + this.textBox1.Text);
            listBox1.Items.Add("Nam sinh: " + "\t" + this.textBox6.Text);
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Gioi tinh: " + "\t" + "Nam");
            }
            if(checkBox3.Checked == true)
            {
                listBox1.Items.Add("Gioi tinh:" + "\t" + "Nu");
            }
            listBox1.Items.Add("Chuc vu: "+"\t"+ this.comboBox2.Text);
            listBox1.Items.Add("MSV: "+"\t"+this.textBox2.Text);
            listBox1.Items.Add("nganh: " + "\t" + this.textBox3.Text);
            listBox1.Items.Add("Diem: " + "\t" + this.textBox4.Text);
            listBox1.Items.Add("xep loai: " + "\t" + this.textBox5.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("lop truong");
            comboBox2.Items.Add("Lop pho");
            comboBox2.Items.Add("bi thu");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
                comboBox2.Visible = true;
        }
    }
}
