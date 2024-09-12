namespace QuanLyNhaHang
{
    partial class FromThemDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromThemDanhMuc));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(19, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(258, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 47);
            textBox1.TabIndex = 1;
            textBox1.Text = "Tên Danh mục";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(258, 164);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 198);
            textBox2.TabIndex = 2;
            textBox2.Text = "Giá Tiền";
            textBox2.MouseClick += textBox2_MouseClick;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.PreviewKeyDown += textBox2_PreviewKeyDown;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(33, 462);
            button2.Name = "button2";
            button2.Size = new Size(151, 47);
            button2.TabIndex = 22;
            button2.Text = "CHỌN ẢNH";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(511, 462);
            button1.Name = "button1";
            button1.Size = new Size(118, 47);
            button1.TabIndex = 23;
            button1.Text = "THÊM";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 35);
            label1.TabIndex = 24;
            label1.Text = "THÊM DANH MỤC MỚI";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(258, 414);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(362, 28);
            comboBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 382);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 26;
            label2.Text = "Nguyên Loại:";
            // 
            // FromThemDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 533);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "FromThemDanhMuc";
            Text = "FromThemDanhMuc";
            Load += FromThemDanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
    }
}