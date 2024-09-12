namespace QuanLyNhaHang
{
    partial class FromSuaXoaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromSuaXoaBan));
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 390);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 37;
            label2.Text = "Trạng thái:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Còn Sử Dụng", "Không Sử Dụng" });
            comboBox1.Location = new Point(146, 423);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(362, 28);
            comboBox1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 34);
            label1.Name = "label1";
            label1.Size = new Size(258, 35);
            label1.TabIndex = 35;
            label1.Text = "CHỈNH SỬA BÀN";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(146, 185);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 182);
            textBox2.TabIndex = 34;
            textBox2.Text = "Mô tả";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(146, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 47);
            textBox1.TabIndex = 33;
            textBox1.Text = "Tên Bàn";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(146, 475);
            button3.Name = "button3";
            button3.Size = new Size(93, 47);
            button3.TabIndex = 39;
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
            button1.Location = new Point(412, 475);
            button1.Name = "button1";
            button1.Size = new Size(96, 47);
            button1.TabIndex = 38;
            button1.Text = "SỬA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FromSuaXoaBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 627);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FromSuaXoaBan";
            Text = "FromSuaXoaBan";
            Load += FromSuaXoaBan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button1;
    }
}