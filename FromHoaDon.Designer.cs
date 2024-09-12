namespace QuanLyNhaHang
{
    partial class FromHoaDon
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
            textBoxfind = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnBan = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnTongTien = new DataGridViewTextBoxColumn();
            ColumnTT = new DataGridViewTextBoxColumn();
            ColumnDay = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxfind
            // 
            textBoxfind.BorderStyle = BorderStyle.None;
            textBoxfind.ImeMode = ImeMode.Off;
            textBoxfind.Location = new Point(12, 130);
            textBoxfind.Multiline = true;
            textBoxfind.Name = "textBoxfind";
            textBoxfind.Size = new Size(299, 35);
            textBoxfind.TabIndex = 6;
            textBoxfind.TextChanged += textBoxfind_TextChanged;
            textBoxfind.Enter += textBoxfind_Enter_1;
            textBoxfind.Leave += textBoxfind_Leave_1;
            textBoxfind.MouseEnter += textBoxfind_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(343, 35);
            label1.TabIndex = 5;
            label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnBan, Column2, Column1, ColumnTongTien, ColumnTT, ColumnDay, Column3 });
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1379, 426);
            dataGridView1.TabIndex = 8;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "idhd";
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 125;
            // 
            // ColumnBan
            // 
            ColumnBan.DataPropertyName = "tenban";
            ColumnBan.HeaderText = "Bàn";
            ColumnBan.MinimumWidth = 6;
            ColumnBan.Name = "ColumnBan";
            ColumnBan.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "danhMucMonAn";
            Column2.HeaderText = "Món Ăn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "soLuongMonan";
            Column1.HeaderText = "Số Lượng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // ColumnTongTien
            // 
            ColumnTongTien.DataPropertyName = "tongtien";
            ColumnTongTien.HeaderText = "Tổng Tiền";
            ColumnTongTien.MinimumWidth = 6;
            ColumnTongTien.Name = "ColumnTongTien";
            ColumnTongTien.Width = 150;
            // 
            // ColumnTT
            // 
            ColumnTT.DataPropertyName = "trangthai";
            ColumnTT.HeaderText = "Trạng Thái";
            ColumnTT.MinimumWidth = 6;
            ColumnTT.Name = "ColumnTT";
            ColumnTT.Width = 200;
            // 
            // ColumnDay
            // 
            ColumnDay.DataPropertyName = "ngaytao";
            ColumnDay.HeaderText = "Ngày Tạo";
            ColumnDay.MinimumWidth = 6;
            ColumnDay.Name = "ColumnDay";
            ColumnDay.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "tennguoidung";
            Column3.HeaderText = "Tên Người Tạo HD";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // FromHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1393, 640);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxfind);
            Controls.Add(label1);
            Name = "FromHoaDon";
            Text = "FromHoaDon";
            Load += FromHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxfind;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnBan;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnTongTien;
        private DataGridViewTextBoxColumn ColumnTT;
        private DataGridViewTextBoxColumn ColumnDay;
        private DataGridViewTextBoxColumn Column3;
    }
}