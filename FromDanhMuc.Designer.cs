namespace QuanLyNhaHang
{
    partial class FromDanhMuc
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
            label1 = new Label();
            textBoxfind = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ColumnId = new DataGridViewTextBoxColumn();
            cloumnHinhAnh = new DataGridViewImageColumn();
            ColumnTenDanhMuc = new DataGridViewTextBoxColumn();
            ColumnMoTa = new DataGridViewTextBoxColumn();
            ColumnDayTao = new DataGridViewTextBoxColumn();
            nguyenlieu = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 36);
            label1.Name = "label1";
            label1.Size = new Size(315, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC MÓN ĂN";
            // 
            // textBoxfind
            // 
            textBoxfind.BorderStyle = BorderStyle.None;
            textBoxfind.ImeMode = ImeMode.Off;
            textBoxfind.Location = new Point(27, 144);
            textBoxfind.Multiline = true;
            textBoxfind.Name = "textBoxfind";
            textBoxfind.Size = new Size(299, 35);
            textBoxfind.TabIndex = 1;
            textBoxfind.MouseClick += textBoxfind_MouseClick;
            textBoxfind.TextChanged += textBoxfind_TextChanged;
            textBoxfind.Enter += textBoxfind_Enter;
            textBoxfind.Leave += textBoxfind_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(27, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 468);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, cloumnHinhAnh, ColumnTenDanhMuc, ColumnMoTa, ColumnDayTao, nguyenlieu });
            dataGridView1.Location = new Point(17, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(1185, 434);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.Add_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1032, 131);
            button1.Name = "button1";
            button1.Size = new Size(197, 47);
            button1.TabIndex = 3;
            button1.Text = "THÊM DANH MỤC";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "id";
            ColumnId.FillWeight = 28.9352531F;
            ColumnId.HeaderText = "ID";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // cloumnHinhAnh
            // 
            cloumnHinhAnh.DataPropertyName = "hinhAnh";
            cloumnHinhAnh.FillWeight = 127.234657F;
            cloumnHinhAnh.HeaderText = "Hình Ảnh";
            cloumnHinhAnh.ImageLayout = DataGridViewImageCellLayout.Stretch;
            cloumnHinhAnh.MinimumWidth = 6;
            cloumnHinhAnh.Name = "cloumnHinhAnh";
            cloumnHinhAnh.ReadOnly = true;
            // 
            // ColumnTenDanhMuc
            // 
            ColumnTenDanhMuc.DataPropertyName = "tenmonan";
            ColumnTenDanhMuc.FillWeight = 20.4397144F;
            ColumnTenDanhMuc.HeaderText = "Tên Danh  Mục";
            ColumnTenDanhMuc.MinimumWidth = 6;
            ColumnTenDanhMuc.Name = "ColumnTenDanhMuc";
            ColumnTenDanhMuc.ReadOnly = true;
            // 
            // ColumnMoTa
            // 
            ColumnMoTa.DataPropertyName = "gia";
            ColumnMoTa.FillWeight = 20.4397144F;
            ColumnMoTa.HeaderText = "Giá Tiền";
            ColumnMoTa.MinimumWidth = 6;
            ColumnMoTa.Name = "ColumnMoTa";
            ColumnMoTa.ReadOnly = true;
            // 
            // ColumnDayTao
            // 
            ColumnDayTao.DataPropertyName = "ngaytao";
            ColumnDayTao.FillWeight = 20.4397144F;
            ColumnDayTao.HeaderText = "Ngày Tạo";
            ColumnDayTao.MinimumWidth = 6;
            ColumnDayTao.Name = "ColumnDayTao";
            ColumnDayTao.ReadOnly = true;
            // 
            // nguyenlieu
            // 
            nguyenlieu.DataPropertyName = "ten";
            nguyenlieu.FillWeight = 20.4397144F;
            nguyenlieu.HeaderText = "Nguyên Liệu";
            nguyenlieu.MinimumWidth = 6;
            nguyenlieu.Name = "nguyenlieu";
            nguyenlieu.ReadOnly = true;
            // 
            // FromDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1495, 715);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBoxfind);
            Controls.Add(label1);
            Name = "FromDanhMuc";
            Text = "FromDanhMuc";
            Load += FromDanhMuc_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxfind;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewImageColumn cloumnHinhAnh;
        private DataGridViewTextBoxColumn ColumnTenDanhMuc;
        private DataGridViewTextBoxColumn ColumnMoTa;
        private DataGridViewTextBoxColumn ColumnDayTao;
        private DataGridViewTextBoxColumn nguyenlieu;
    }
}