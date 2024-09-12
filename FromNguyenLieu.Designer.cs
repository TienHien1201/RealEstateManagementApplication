namespace QuanLyNhaHang
{
    partial class FromNguyenLieu
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
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnMT = new DataGridViewTextBoxColumn();
            ColumnDaySX = new DataGridViewTextBoxColumn();
            ColumnDaySD = new DataGridViewTextBoxColumn();
            ColumnSL = new DataGridViewTextBoxColumn();
            ColumnDayThem = new DataGridViewTextBoxColumn();
            ColumnDonVi = new DataGridViewTextBoxColumn();
            ColumnNCC = new DataGridViewTextBoxColumn();
            textBoxfind = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnTen, ColumnMT, ColumnDaySX, ColumnDaySD, ColumnSL, ColumnDayThem, ColumnDonVi, ColumnNCC });
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1442, 426);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "id";
            ColumnID.FillWeight = 110.151192F;
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 170;
            // 
            // ColumnTen
            // 
            ColumnTen.DataPropertyName = "ten";
            ColumnTen.FillWeight = 96.111824F;
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 6;
            ColumnTen.Name = "ColumnTen";
            ColumnTen.ReadOnly = true;
            ColumnTen.Width = 148;
            // 
            // ColumnMT
            // 
            ColumnMT.DataPropertyName = "mota";
            ColumnMT.FillWeight = 128.730057F;
            ColumnMT.HeaderText = "Mô Tả";
            ColumnMT.MinimumWidth = 6;
            ColumnMT.Name = "ColumnMT";
            ColumnMT.ReadOnly = true;
            ColumnMT.Width = 199;
            // 
            // ColumnDaySX
            // 
            ColumnDaySX.DataPropertyName = "daysanxuat";
            ColumnDaySX.FillWeight = 93.4608F;
            ColumnDaySX.HeaderText = "Ngày Sản Xuất";
            ColumnDaySX.MinimumWidth = 6;
            ColumnDaySX.Name = "ColumnDaySX";
            ColumnDaySX.ReadOnly = true;
            ColumnDaySX.Width = 144;
            // 
            // ColumnDaySD
            // 
            ColumnDaySD.DataPropertyName = "hansudung";
            ColumnDaySD.FillWeight = 94.18281F;
            ColumnDaySD.HeaderText = "Hạn Sử Dụng";
            ColumnDaySD.MinimumWidth = 6;
            ColumnDaySD.Name = "ColumnDaySD";
            ColumnDaySD.ReadOnly = true;
            ColumnDaySD.Width = 146;
            // 
            // ColumnSL
            // 
            ColumnSL.DataPropertyName = "soluong";
            ColumnSL.FillWeight = 79.0223846F;
            ColumnSL.HeaderText = "Số Lượng";
            ColumnSL.MinimumWidth = 6;
            ColumnSL.Name = "ColumnSL";
            ColumnSL.ReadOnly = true;
            ColumnSL.Width = 122;
            // 
            // ColumnDayThem
            // 
            ColumnDayThem.DataPropertyName = "ngaythem";
            ColumnDayThem.FillWeight = 80.9234161F;
            ColumnDayThem.HeaderText = "Ngày Thêm";
            ColumnDayThem.MinimumWidth = 6;
            ColumnDayThem.Name = "ColumnDayThem";
            ColumnDayThem.ReadOnly = true;
            ColumnDayThem.Width = 124;
            // 
            // ColumnDonVi
            // 
            ColumnDonVi.DataPropertyName = "donvi";
            ColumnDonVi.FillWeight = 82.6533661F;
            ColumnDonVi.HeaderText = "Đơn Vị";
            ColumnDonVi.MinimumWidth = 6;
            ColumnDonVi.Name = "ColumnDonVi";
            ColumnDonVi.ReadOnly = true;
            ColumnDonVi.Width = 128;
            // 
            // ColumnNCC
            // 
            ColumnNCC.DataPropertyName = "TenNhaCungCap";
            ColumnNCC.FillWeight = 134.764191F;
            ColumnNCC.HeaderText = "Nhà Cung Cấp";
            ColumnNCC.MinimumWidth = 6;
            ColumnNCC.Name = "ColumnNCC";
            ColumnNCC.ReadOnly = true;
            ColumnNCC.Width = 208;
            // 
            // textBoxfind
            // 
            textBoxfind.BorderStyle = BorderStyle.None;
            textBoxfind.ImeMode = ImeMode.Off;
            textBoxfind.Location = new Point(12, 111);
            textBoxfind.Multiline = true;
            textBoxfind.Name = "textBoxfind";
            textBoxfind.Size = new Size(299, 35);
            textBoxfind.TabIndex = 10;
            textBoxfind.MouseClick += textBoxfind_MouseClick;
            textBoxfind.TextChanged += textBoxfind_TextChanged;
            textBoxfind.Leave += textBoxfind_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(521, 9);
            label1.Name = "label1";
            label1.Size = new Size(416, 35);
            label1.TabIndex = 9;
            label1.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.Add_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1253, 99);
            button1.Name = "button1";
            button1.Size = new Size(201, 47);
            button1.TabIndex = 11;
            button1.Text = "THÊM NGUYÊN LIỆU";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FromNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1481, 601);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxfind);
            Controls.Add(label1);
            Name = "FromNguyenLieu";
            Text = "FromNguyenLieu";
            Load += FromNguyenLieu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxfind;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnMT;
        private DataGridViewTextBoxColumn ColumnDaySX;
        private DataGridViewTextBoxColumn ColumnDaySD;
        private DataGridViewTextBoxColumn ColumnSL;
        private DataGridViewTextBoxColumn ColumnDayThem;
        private DataGridViewTextBoxColumn ColumnDonVi;
        private DataGridViewTextBoxColumn ColumnNCC;
    }
}