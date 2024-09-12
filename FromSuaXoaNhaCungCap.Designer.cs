namespace QuanLyNhaHang
{
    partial class FromSuaXoaNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromSuaXoaNhaCungCap));
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxTen = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxPhone
            // 
            textBoxPhone.ForeColor = SystemColors.ButtonShadow;
            textBoxPhone.Location = new Point(167, 280);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(454, 37);
            textBoxPhone.TabIndex = 71;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // textBoxAddress
            // 
            textBoxAddress.ForeColor = SystemColors.ButtonShadow;
            textBoxAddress.Location = new Point(167, 390);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(454, 48);
            textBoxAddress.TabIndex = 70;
            // 
            // textBoxTen
            // 
            textBoxTen.ForeColor = SystemColors.ButtonShadow;
            textBoxTen.Location = new Point(164, 98);
            textBoxTen.Multiline = true;
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(454, 48);
            textBoxTen.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(164, 355);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 68;
            label7.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 163);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 67;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 75);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 66;
            label3.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 257);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 65;
            label2.Text = "Số điện thoại:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.ForeColor = SystemColors.ButtonShadow;
            textBoxEmail.Location = new Point(167, 186);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(454, 48);
            textBoxEmail.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 13);
            label1.Name = "label1";
            label1.Size = new Size(427, 35);
            label1.TabIndex = 63;
            label1.Text = "CHỈNH SỬA NHÀ CUNG CẤP";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(194, 464);
            button3.Name = "button3";
            button3.Size = new Size(93, 47);
            button3.TabIndex = 73;
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
            button1.Location = new Point(460, 464);
            button1.Name = "button1";
            button1.Size = new Size(96, 47);
            button1.TabIndex = 72;
            button1.Text = "SỬA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FromSuaXoaNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 626);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxTen);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Name = "FromSuaXoaNhaCungCap";
            Text = "FromSuaXoaNhaCungCap";
            Load += FromSuaXoaNhaCungCap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxTen;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label1;
        private Button button3;
        private Button button1;
    }
}