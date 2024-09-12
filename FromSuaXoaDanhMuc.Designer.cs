namespace QuanLyNhaHang
{
    partial class FromSuaXoaDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromSuaXoaDanhMuc));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 27);
            label1.Name = "label1";
            label1.Size = new Size(361, 35);
            label1.TabIndex = 30;
            label1.Text = "CHỈNH SỬA DANH MỤC";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(556, 480);
            button1.Name = "button1";
            button1.Size = new Size(96, 47);
            button1.TabIndex = 29;
            button1.Text = "SỬA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(65, 480);
            button2.Name = "button2";
            button2.Size = new Size(151, 47);
            button2.TabIndex = 28;
            button2.Text = "CHỌN ẢNH";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(290, 182);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 192);
            textBox2.TabIndex = 27;
            textBox2.Text = "Giá Tiền";
            textBox2.MouseClick += textBox2_MouseClick;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(290, 103);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 47);
            textBox1.TabIndex = 26;
            textBox1.Text = "Tên Danh mục";
            textBox1.MouseClick += textBox1_MouseClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(51, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(290, 480);
            button3.Name = "button3";
            button3.Size = new Size(93, 47);
            button3.TabIndex = 31;
            button3.Text = "XÓA";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 400);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 33;
            label2.Text = "Nguyên Loại:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(290, 432);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(362, 28);
            comboBox1.TabIndex = 32;
            // 
            // FromSuaXoaDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 558);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            Name = "FromSuaXoaDanhMuc";
            Text = "FromSuaXoaDanhMuc";
            Load += FromSuaXoaDanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label2;
        private ComboBox comboBox1;
    }
}