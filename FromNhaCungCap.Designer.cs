namespace QuanLyNhaHang
{
    partial class FromNhaCungCap
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
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnNgayThem = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxfind = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnTen, ColumnEmail, ColumnPhone, ColumnAddress, ColumnNgayThem });
            dataGridView1.Location = new Point(23, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1254, 426);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "id";
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 200;
            // 
            // ColumnTen
            // 
            ColumnTen.DataPropertyName = "ten";
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 6;
            ColumnTen.Name = "ColumnTen";
            ColumnTen.Width = 200;
            // 
            // ColumnEmail
            // 
            ColumnEmail.DataPropertyName = "email";
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.Width = 200;
            // 
            // ColumnPhone
            // 
            ColumnPhone.DataPropertyName = "phone";
            ColumnPhone.HeaderText = "Phone";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.Width = 200;
            // 
            // ColumnAddress
            // 
            ColumnAddress.DataPropertyName = "diachi";
            ColumnAddress.HeaderText = "Địa Chỉ";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.Width = 200;
            // 
            // ColumnNgayThem
            // 
            ColumnNgayThem.DataPropertyName = "ngaythem";
            ColumnNgayThem.HeaderText = "Ngày Thêm";
            ColumnNgayThem.MinimumWidth = 6;
            ColumnNgayThem.Name = "ColumnNgayThem";
            ColumnNgayThem.Width = 200;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.Add_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1060, 93);
            button1.Name = "button1";
            button1.Size = new Size(217, 47);
            button1.TabIndex = 15;
            button1.Text = "THÊM NHÀ CUNG CẤP";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxfind
            // 
            textBoxfind.BorderStyle = BorderStyle.None;
            textBoxfind.ImeMode = ImeMode.Off;
            textBoxfind.Location = new Point(23, 106);
            textBoxfind.Multiline = true;
            textBoxfind.Name = "textBoxfind";
            textBoxfind.Size = new Size(299, 35);
            textBoxfind.TabIndex = 14;
            textBoxfind.MouseClick += textBoxfind_MouseClick;
            textBoxfind.TextChanged += textBoxfind_TextChanged;
            textBoxfind.Leave += textBoxfind_Leave_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 9);
            label1.Name = "label1";
            label1.Size = new Size(437, 35);
            label1.TabIndex = 13;
            label1.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // FromNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1489, 589);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxfind);
            Controls.Add(label1);
            Name = "FromNhaCungCap";
            Text = "FromNhaCungCap";
            Load += FromNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBoxfind;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnNgayThem;
    }
}