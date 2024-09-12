namespace QuanLyNhaHang
{
    partial class FromDangNhap
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btDangnhap = new Button();
            lbTittle = new Label();
            checkMatKhau = new CheckBox();
            lbUser = new Label();
            lbPass = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(909, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 42);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.snapedit_1719545945638;
            pictureBox1.Location = new Point(0, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 422);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Cursor = Cursors.IBeam;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(576, 147);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(312, 45);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(576, 225);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(312, 45);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // btDangnhap
            // 
            btDangnhap.BackColor = Color.Green;
            btDangnhap.Cursor = Cursors.Hand;
            btDangnhap.ForeColor = SystemColors.Control;
            btDangnhap.Image = Properties.Resources.Login;
            btDangnhap.ImageAlign = ContentAlignment.MiddleLeft;
            btDangnhap.Location = new Point(576, 328);
            btDangnhap.Name = "btDangnhap";
            btDangnhap.Size = new Size(312, 50);
            btDangnhap.TabIndex = 4;
            btDangnhap.Text = "ĐĂNG NHẬP";
            btDangnhap.UseVisualStyleBackColor = false;
            btDangnhap.Click += btDangnhap_Click;
            // 
            // lbTittle
            // 
            lbTittle.AutoSize = true;
            lbTittle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTittle.Location = new Point(625, 71);
            lbTittle.Name = "lbTittle";
            lbTittle.Size = new Size(188, 38);
            lbTittle.TabIndex = 5;
            lbTittle.Text = "ĐĂNG NHẬP";
            // 
            // checkMatKhau
            // 
            checkMatKhau.AutoSize = true;
            checkMatKhau.Cursor = Cursors.Hand;
            checkMatKhau.Location = new Point(576, 288);
            checkMatKhau.Name = "checkMatKhau";
            checkMatKhau.Size = new Size(148, 24);
            checkMatKhau.TabIndex = 6;
            checkMatKhau.Text = "Hiển thị mật khẩu";
            checkMatKhau.UseVisualStyleBackColor = true;
            checkMatKhau.CheckedChanged += checkMatKhau_CheckedChanged;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(479, 157);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(53, 20);
            lbUser.TabIndex = 8;
            lbUser.Text = "Admin";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(479, 250);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(72, 20);
            lbPass.TabIndex = 9;
            lbPass.Text = "PassWord";
            // 
            // FromDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 464);
            Controls.Add(lbPass);
            Controls.Add(lbUser);
            Controls.Add(checkMatKhau);
            Controls.Add(lbTittle);
            Controls.Add(btDangnhap);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FromDangNhap";
            Text = "FromDangNhap";
            Load += FromDangNhap_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btDangnhap;
        private Label lbTittle;
        private CheckBox checkMatKhau;
        private Label label1;
        private Label lbUser;
        private Label lbPass;
    }
}