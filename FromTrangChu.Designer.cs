namespace QuanLyNhaHang
{
    partial class FromTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromTrangChu));
            panel1 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            panel2 = new Panel();
            lbhoadon = new Label();
            pictureBox2 = new PictureBox();
            lbTonghd = new Label();
            panel3 = new Panel();
            lbtien = new Label();
            pictureBox1 = new PictureBox();
            lbDoanhThu = new Label();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1557, 658);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarMonthBackground = SystemColors.HighlightText;
            dateTimePicker3.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePicker3.CustomFormat = "MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(75, 21);
            dateTimePicker3.MinimumSize = new Size(120, 50);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(220, 50);
            dateTimePicker3.TabIndex = 9;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lbhoadon);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lbTonghd);
            panel2.Location = new Point(948, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 125);
            panel2.TabIndex = 7;
            // 
            // lbhoadon
            // 
            lbhoadon.AutoSize = true;
            lbhoadon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbhoadon.Location = new Point(113, 26);
            lbhoadon.Name = "lbhoadon";
            lbhoadon.Size = new Size(20, 22);
            lbhoadon.TabIndex = 2;
            lbhoadon.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bill_1;
            pictureBox2.Location = new Point(25, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lbTonghd
            // 
            lbTonghd.AutoSize = true;
            lbTonghd.Location = new Point(25, 95);
            lbTonghd.Name = "lbTonghd";
            lbTonghd.Size = new Size(67, 19);
            lbTonghd.TabIndex = 2;
            lbTonghd.Text = "Hóa đơn";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbtien);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lbDoanhThu);
            panel3.Location = new Point(480, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 125);
            panel3.TabIndex = 6;
            // 
            // lbtien
            // 
            lbtien.AutoSize = true;
            lbtien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtien.Location = new Point(90, 25);
            lbtien.Name = "lbtien";
            lbtien.Size = new Size(20, 22);
            lbtien.TabIndex = 1;
            lbtien.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Euro_Money_1;
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Location = new Point(14, 94);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(82, 19);
            lbDoanhThu.TabIndex = 0;
            lbDoanhThu.Text = "Doanh Thu";
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // FromTrangChu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1557, 658);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FromTrangChu";
            Text = "FromTrangChu";
            Load += FromTrangChu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private DateTimePicker dateTimePicker3;
        private Panel panel2;
        private Label lbhoadon;
        private PictureBox pictureBox2;
        private Label lbTonghd;
        private Panel panel3;
        private Label lbtien;
        private PictureBox pictureBox1;
        private Label lbDoanhThu;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
    }
}