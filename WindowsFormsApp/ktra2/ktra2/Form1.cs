namespace ktra2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Đại học chính quy ");
            comboBox1.Items.Add("Vừa học vừa làm ");
            comboBox1.Items.Add("Liên thông" );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            comboBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = 0, b = 0, dkt = 0;
            int msv = int.Parse(txt2.Text);
            a = float.Parse(txt3.Text);
            b= float.Parse(txt4.Text);
            dkt = (a / 100 * 30) + (b / 100 * 70);
            if(msv < 0)
            {
                MessageBox.Show("Canh bao nhap sai ma sinh vien", "Thong bao");
            }
            if (a< 0)
            {
                MessageBox.Show("Canh bao nhap sai diem thanh phan", "Thong bao");
            }
            if (b < 0)
            {
                MessageBox.Show("Canh bao nhap sai diem thi", "Thong bao");
            }

            list1.Items.Add("Hệ đào tạo: " + this.comboBox1.Text);
            list1.Items.Add("Họ tên sinh viên: "+ txt1.Text);
            list1.Items.Add("Mã sinh viên: "+ txt2.Text);
            list1.Items.Add("Điểm thành phần: "+ txt3.Text);
            list1.Items.Add("Điểm thi: " + txt4.Text);
            list1.Items.Add("Điểm kết thúc: "+ dkt.ToString());
            

        }
    }
}