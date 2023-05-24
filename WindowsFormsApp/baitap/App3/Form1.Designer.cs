namespace App3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.txtthit = new System.Windows.Forms.TextBox();
            this.txtca = new System.Windows.Forms.TextBox();
            this.txtrau = new System.Windows.Forms.TextBox();
            this.txtnuockhoang = new System.Windows.Forms.TextBox();
            this.txtcoca = new System.Windows.Forms.TextBox();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.lstthanhtoan = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.txtbia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.lblthit = new System.Windows.Forms.Label();
            this.lblca = new System.Windows.Forms.Label();
            this.lblrau = new System.Windows.Forms.Label();
            this.lblnuockhoang = new System.Windows.Forms.Label();
            this.lblcoca = new System.Windows.Forms.Label();
            this.lblbia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người bán hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán/Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(331, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.Location = new System.Drawing.Point(31, 207);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(71, 29);
            this.chk1.TabIndex = 3;
            this.chk1.Text = "Thịt";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2.Location = new System.Drawing.Point(31, 252);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(64, 29);
            this.chk2.TabIndex = 4;
            this.chk2.Text = "Cá";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk3.Location = new System.Drawing.Point(31, 302);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(73, 29);
            this.chk3.TabIndex = 5;
            this.chk3.Text = "Rau";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk4.Location = new System.Drawing.Point(31, 355);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(154, 29);
            this.chk4.TabIndex = 6;
            this.chk4.Text = "Nước khoáng";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk5.Location = new System.Drawing.Point(32, 403);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(85, 29);
            this.chk5.TabIndex = 7;
            this.chk5.Text = "Coca";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // txtthit
            // 
            this.txtthit.Location = new System.Drawing.Point(210, 205);
            this.txtthit.Name = "txtthit";
            this.txtthit.Size = new System.Drawing.Size(38, 26);
            this.txtthit.TabIndex = 8;
            // 
            // txtca
            // 
            this.txtca.Location = new System.Drawing.Point(210, 252);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(38, 26);
            this.txtca.TabIndex = 9;
            // 
            // txtrau
            // 
            this.txtrau.Location = new System.Drawing.Point(209, 304);
            this.txtrau.Name = "txtrau";
            this.txtrau.Size = new System.Drawing.Size(38, 26);
            this.txtrau.TabIndex = 10;
            // 
            // txtnuockhoang
            // 
            this.txtnuockhoang.Location = new System.Drawing.Point(209, 357);
            this.txtnuockhoang.Name = "txtnuockhoang";
            this.txtnuockhoang.Size = new System.Drawing.Size(38, 26);
            this.txtnuockhoang.TabIndex = 11;
            // 
            // txtcoca
            // 
            this.txtcoca.Location = new System.Drawing.Point(209, 406);
            this.txtcoca.Name = "txtcoca";
            this.txtcoca.Size = new System.Drawing.Size(38, 26);
            this.txtcoca.TabIndex = 12;
            // 
            // cboname
            // 
            this.cboname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboname.FormattingEnabled = true;
            this.cboname.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Văn B",
            "Vũ Thị C",
            "Vũ Thị D"});
            this.cboname.Location = new System.Drawing.Point(183, 56);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(331, 33);
            this.cboname.TabIndex = 13;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstthanhtoan
            // 
            this.lstthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstthanhtoan.FormattingEnabled = true;
            this.lstthanhtoan.ItemHeight = 25;
            this.lstthanhtoan.Location = new System.Drawing.Point(643, 79);
            this.lstthanhtoan.Name = "lstthanhtoan";
            this.lstthanhtoan.Size = new System.Drawing.Size(460, 429);
            this.lstthanhtoan.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(794, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hóa đơn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk6.Location = new System.Drawing.Point(31, 454);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(66, 29);
            this.chk6.TabIndex = 16;
            this.chk6.Text = "Bia";
            this.chk6.UseVisualStyleBackColor = true;
            this.chk6.CheckedChanged += new System.EventHandler(this.chk6_CheckedChanged);
            // 
            // txtbia
            // 
            this.txtbia.Location = new System.Drawing.Point(209, 457);
            this.txtbia.Name = "txtbia";
            this.txtbia.Size = new System.Drawing.Size(38, 26);
            this.txtbia.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Khách hàng";
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1.Location = new System.Drawing.Point(199, 536);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(124, 29);
            this.rdo1.TabIndex = 19;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Thân thiết";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2.Location = new System.Drawing.Point(366, 536);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(69, 29);
            this.rdo2.TabIndex = 20;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Mới";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // lblthit
            // 
            this.lblthit.AutoSize = true;
            this.lblthit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthit.Location = new System.Drawing.Point(340, 211);
            this.lblthit.Name = "lblthit";
            this.lblthit.Size = new System.Drawing.Size(72, 25);
            this.lblthit.TabIndex = 21;
            this.lblthit.Text = "100/kg";
            // 
            // lblca
            // 
            this.lblca.AutoSize = true;
            this.lblca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblca.Location = new System.Drawing.Point(340, 261);
            this.lblca.Name = "lblca";
            this.lblca.Size = new System.Drawing.Size(61, 25);
            this.lblca.TabIndex = 22;
            this.lblca.Text = "50/kg";
            // 
            // lblrau
            // 
            this.lblrau.AutoSize = true;
            this.lblrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrau.Location = new System.Drawing.Point(340, 311);
            this.lblrau.Name = "lblrau";
            this.lblrau.Size = new System.Drawing.Size(61, 25);
            this.lblrau.TabIndex = 23;
            this.lblrau.Text = "20/kg";
            // 
            // lblnuockhoang
            // 
            this.lblnuockhoang.AutoSize = true;
            this.lblnuockhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuockhoang.Location = new System.Drawing.Point(340, 364);
            this.lblnuockhoang.Name = "lblnuockhoang";
            this.lblnuockhoang.Size = new System.Drawing.Size(76, 25);
            this.lblnuockhoang.TabIndex = 24;
            this.lblnuockhoang.Text = "10/chai";
            // 
            // lblcoca
            // 
            this.lblcoca.AutoSize = true;
            this.lblcoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoca.Location = new System.Drawing.Point(340, 412);
            this.lblcoca.Name = "lblcoca";
            this.lblcoca.Size = new System.Drawing.Size(66, 25);
            this.lblcoca.TabIndex = 25;
            this.lblcoca.Text = "15/lon";
            // 
            // lblbia
            // 
            this.lblbia.AutoSize = true;
            this.lblbia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbia.Location = new System.Drawing.Point(340, 460);
            this.lblbia.Name = "lblbia";
            this.lblbia.Size = new System.Drawing.Size(66, 25);
            this.lblbia.TabIndex = 26;
            this.lblbia.Text = "15/lon";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 67);
            this.button1.TabIndex = 27;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbia);
            this.Controls.Add(this.lblcoca);
            this.Controls.Add(this.lblnuockhoang);
            this.Controls.Add(this.lblrau);
            this.Controls.Add(this.lblca);
            this.Controls.Add(this.lblthit);
            this.Controls.Add(this.rdo2);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbia);
            this.Controls.Add(this.chk6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstthanhtoan);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.txtcoca);
            this.Controls.Add(this.txtnuockhoang);
            this.Controls.Add(this.txtrau);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.txtthit);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.TextBox txtthit;
        private System.Windows.Forms.TextBox txtca;
        private System.Windows.Forms.TextBox txtrau;
        private System.Windows.Forms.TextBox txtnuockhoang;
        private System.Windows.Forms.TextBox txtcoca;
        private System.Windows.Forms.ComboBox cboname;
        private System.Windows.Forms.ListBox lstthanhtoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.TextBox txtbia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.Label lblthit;
        private System.Windows.Forms.Label lblca;
        private System.Windows.Forms.Label lblrau;
        private System.Windows.Forms.Label lblnuockhoang;
        private System.Windows.Forms.Label lblcoca;
        private System.Windows.Forms.Label lblbia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

