namespace QuanLyNhaHang
{
    partial class FromThemBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromThemBan));
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 24);
            label1.Name = "label1";
            label1.Size = new Size(250, 35);
            label1.TabIndex = 27;
            label1.Text = "THÊM BÀN MỚI";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(101, 175);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 182);
            textBox2.TabIndex = 26;
            textBox2.Text = "Mô tả";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(101, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 47);
            textBox1.TabIndex = 25;
            textBox1.Text = "Tên Bàn";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Còn Sử Dụng", "Không Sử Dụng" });
            comboBox1.Location = new Point(101, 413);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(362, 28);
            comboBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 380);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 29;
            label2.Text = "Trạng thái:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(355, 462);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 32;
            button1.Text = "THÊM";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FromThemBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(578, 564);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FromThemBan";
            Text = "FromThemBan";
            Load += FromThemBan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
    }
}