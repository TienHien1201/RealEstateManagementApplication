namespace QuanLyNhaHang
{
    partial class FromBan
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
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumntenBan = new DataGridViewTextBoxColumn();
            ColumnMT = new DataGridViewTextBoxColumn();
            ColumnTrangThai = new DataGridViewTextBoxColumn();
            ColumnDayTao = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBoxfind
            // 
            textBoxfind.BorderStyle = BorderStyle.None;
            textBoxfind.ImeMode = ImeMode.Off;
            textBoxfind.Location = new Point(12, 129);
            textBoxfind.Multiline = true;
            textBoxfind.Name = "textBoxfind";
            textBoxfind.Size = new Size(299, 35);
            textBoxfind.TabIndex = 4;
            textBoxfind.TextChanged += textBoxfind_TextChanged;
            textBoxfind.MouseEnter += textBoxfind_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 35);
            label1.TabIndex = 3;
            label1.Text = "DANH SÁCH BÀN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(12, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 442);
            panel1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumntenBan, ColumnMT, ColumnTrangThai, ColumnDayTao });
            dataGridView2.Location = new Point(24, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1053, 374);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellMouseDoubleClick += dataGridView2_CellMouseDoubleClick;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "id";
            ColumnId.HeaderText = "ID";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 200;
            // 
            // ColumntenBan
            // 
            ColumntenBan.DataPropertyName = "tenban";
            ColumntenBan.HeaderText = "Tên Bàn";
            ColumntenBan.MinimumWidth = 6;
            ColumntenBan.Name = "ColumntenBan";
            ColumntenBan.Width = 200;
            // 
            // ColumnMT
            // 
            ColumnMT.DataPropertyName = "mota";
            ColumnMT.HeaderText = "Mô tả";
            ColumnMT.MinimumWidth = 6;
            ColumnMT.Name = "ColumnMT";
            ColumnMT.Width = 200;
            // 
            // ColumnTrangThai
            // 
            ColumnTrangThai.DataPropertyName = "trangthai";
            ColumnTrangThai.HeaderText = "Trạng Thái";
            ColumnTrangThai.MinimumWidth = 6;
            ColumnTrangThai.Name = "ColumnTrangThai";
            ColumnTrangThai.Width = 200;
            // 
            // ColumnDayTao
            // 
            ColumnDayTao.DataPropertyName = "ngaytao";
            ColumnDayTao.HeaderText = "Ngày Tạo";
            ColumnDayTao.MinimumWidth = 6;
            ColumnDayTao.Name = "ColumnDayTao";
            ColumnDayTao.Width = 200;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.Add_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(994, 129);
            button1.Name = "button1";
            button1.Size = new Size(140, 47);
            button1.TabIndex = 6;
            button1.Text = "THÊM BÀN";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FromBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1241, 645);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBoxfind);
            Controls.Add(label1);
            Name = "FromBan";
            Text = "FromBan";
            Load += FromBan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxfind;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumntenBan;
        private DataGridViewTextBoxColumn ColumnMT;
        private DataGridViewTextBoxColumn ColumnTrangThai;
        private DataGridViewTextBoxColumn ColumnDayTao;
    }
}