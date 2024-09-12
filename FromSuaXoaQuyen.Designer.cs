namespace QuanLyNhaHang
{
    partial class FromSuaXoaQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromSuaXoaQuyen));
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.ForeColor = SystemColors.ButtonShadow;
            textBox4.Location = new Point(162, 128);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(454, 39);
            textBox4.TabIndex = 72;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(162, 298);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 48);
            textBox1.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 105);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 70;
            label5.Text = "Tên tài khoản:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 180);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 69;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 275);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 68;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 526);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 67;
            label2.Text = "Thẩm quyền:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            comboBox1.Location = new Point(162, 558);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(454, 28);
            comboBox1.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 35);
            label1.Name = "label1";
            label1.Size = new Size(481, 35);
            label1.TabIndex = 65;
            label1.Text = "CHỈNH SỬA QUYỀN NHÂN VIÊN";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(165, 203);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 48);
            textBox2.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 440);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 74;
            label6.Text = "Trạng Thái";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Hoạt động", "Ngưng hoạt động" });
            comboBox2.Location = new Point(162, 472);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(454, 28);
            comboBox2.TabIndex = 73;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ButtonShadow;
            textBox3.Location = new Point(162, 385);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(454, 39);
            textBox3.TabIndex = 76;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 362);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 75;
            label7.Text = "Mật Khẩu";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(162, 610);
            button3.Name = "button3";
            button3.Size = new Size(93, 47);
            button3.TabIndex = 79;
            button3.Text = "XÓA";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(520, 610);
            button1.Name = "button1";
            button1.Size = new Size(96, 47);
            button1.TabIndex = 78;
            button1.Text = "SỬA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FromSuaXoaQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 691);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "FromSuaXoaQuyen";
            Text = "FromSuaXoaQuyen";
            Load += FromSuaXoaQuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Label label7;
        private Button button3;
        private Button button1;
    }
}