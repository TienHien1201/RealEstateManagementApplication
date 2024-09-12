namespace QuanLyNhaHang
{
    partial class FromThemQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromThemQuyen));
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(125, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 48);
            textBox1.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 262);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 55;
            label5.Text = "Tên tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 167);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 53;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 79);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 52;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 343);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 51;
            label2.Text = "Thẩm quyền:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            comboBox1.Location = new Point(128, 375);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(454, 28);
            comboBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 22);
            label1.Name = "label1";
            label1.Size = new Size(473, 35);
            label1.TabIndex = 49;
            label1.Text = "THÊM QUYỀN NHÂN VIÊN MỚI";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(461, 434);
            button1.Name = "button1";
            button1.Size = new Size(118, 47);
            button1.TabIndex = 48;
            button1.Text = "THÊM";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(128, 190);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 48);
            textBox2.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ButtonShadow;
            textBox4.Location = new Point(125, 285);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(454, 39);
            textBox4.TabIndex = 63;
            // 
            // FromThemQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(727, 543);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Name = "FromThemQuyen";
            Text = "FromThemQuyen";
            Load += FromThemQuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox4;
    }
}