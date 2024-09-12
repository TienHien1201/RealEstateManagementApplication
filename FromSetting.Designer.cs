namespace QuanLyNhaHang
{
    partial class FromSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromSetting));
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            tenmonan = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbTenBan = new Label();
            panel2 = new Panel();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(12, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(545, 612);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tenmonan, soLuong, gia });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(626, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(378, 389);
            dataGridView1.TabIndex = 1;
            // 
            // tenmonan
            // 
            tenmonan.DataPropertyName = "tenmonan";
            tenmonan.HeaderText = "TÊN MÓN ĂN";
            tenmonan.MinimumWidth = 6;
            tenmonan.Name = "tenmonan";
            tenmonan.Width = 125;
            // 
            // soLuong
            // 
            soLuong.DataPropertyName = "soluong";
            soLuong.HeaderText = "SỐ LƯỢNG";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.Width = 125;
            // 
            // gia
            // 
            gia.DataPropertyName = "gia";
            gia.HeaderText = "GIÁ TIỀN";
            gia.MinimumWidth = 6;
            gia.Name = "gia";
            gia.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(626, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 51);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 17);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.Average_Price_2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(626, 642);
            button1.Name = "button1";
            button1.Size = new Size(148, 47);
            button1.TabIndex = 20;
            button1.Text = "THANH TOÁN";
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
            button2.Location = new Point(626, 578);
            button2.Name = "button2";
            button2.Size = new Size(151, 47);
            button2.TabIndex = 21;
            button2.Text = "THÊM MÓN";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbTenBan
            // 
            lbTenBan.AutoSize = true;
            lbTenBan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenBan.ForeColor = Color.IndianRed;
            lbTenBan.Location = new Point(626, 70);
            lbTenBan.Name = "lbTenBan";
            lbTenBan.Size = new Size(95, 41);
            lbTenBan.TabIndex = 22;
            lbTenBan.Text = "Bàn 3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 42);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(1105, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 42);
            label3.TabIndex = 0;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(865, 578);
            button3.Name = "button3";
            button3.Size = new Size(139, 47);
            button3.TabIndex = 24;
            button3.Text = "BỎ MÓN";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FromSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 747);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(lbTenBan);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FromSetting";
            Text = "FromSetting";
            FormClosed += FromSetting_FormClosed;
            Load += FromSetting_Load;
            Shown += FromSetting_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private UserMonAn userMonAn2;
        private UserMonAn userMonAn14;
        private UserMonAn userMonAn1;
        private UserMonAn userMonAn3;
        private UserMonAn userMonAn4;
        private UserMonAn userMonAn5;
        private UserMonAn userMonAn6;
        private UserMonAn userMonAn7;
        private UserMonAn userMonAn8;
        private UserMonAn userMonAn9;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label lbTenBan;
        private Panel panel2;
        private Label label3;
        private Button button3;
        private DataGridViewTextBoxColumn tenmonan;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn gia;
    }
}