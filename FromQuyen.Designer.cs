namespace QuanLyNhaHang
{
    partial class FromQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromQuyen));
            textBoxfind = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnMoTa = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnTK = new DataGridViewTextBoxColumn();
            ColumnTQ = new DataGridViewTextBoxColumn();
            ColumnTT = new DataGridViewTextBoxColumn();
            ColumnDay = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxfind
            // 
            textBoxfind.BorderStyle = BorderStyle.None;
            textBoxfind.ImeMode = ImeMode.Off;
            textBoxfind.Location = new Point(12, 99);
            textBoxfind.Multiline = true;
            textBoxfind.Name = "textBoxfind";
            textBoxfind.Size = new Size(299, 35);
            textBoxfind.TabIndex = 18;
            textBoxfind.MouseClick += textBoxfind_MouseClick;
            textBoxfind.TextChanged += textBoxfind_TextChanged;
            textBoxfind.Leave += textBoxfind_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 35);
            label1.TabIndex = 17;
            label1.Text = "QUẢN LÝ QUYỀN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1003, 99);
            button1.Name = "button1";
            button1.Size = new Size(189, 47);
            button1.TabIndex = 49;
            button1.Text = "THÊM NHÂN VIÊN";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnMoTa, ColumnEmail, ColumnTK, ColumnTQ, ColumnTT, ColumnDay });
            dataGridView1.Location = new Point(12, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 426);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "id";
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 125;
            // 
            // ColumnMoTa
            // 
            ColumnMoTa.DataPropertyName = "mota";
            ColumnMoTa.HeaderText = "Tên";
            ColumnMoTa.MinimumWidth = 6;
            ColumnMoTa.Name = "ColumnMoTa";
            ColumnMoTa.ReadOnly = true;
            ColumnMoTa.Width = 125;
            // 
            // ColumnEmail
            // 
            ColumnEmail.DataPropertyName = "email";
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            ColumnEmail.Width = 150;
            // 
            // ColumnTK
            // 
            ColumnTK.DataPropertyName = "taikhoan";
            ColumnTK.HeaderText = "Tài Khoản Nhân Viên";
            ColumnTK.MinimumWidth = 6;
            ColumnTK.Name = "ColumnTK";
            ColumnTK.ReadOnly = true;
            ColumnTK.Width = 200;
            // 
            // ColumnTQ
            // 
            ColumnTQ.DataPropertyName = "Quyen";
            ColumnTQ.HeaderText = "Thẩm Quyền";
            ColumnTQ.MinimumWidth = 6;
            ColumnTQ.Name = "ColumnTQ";
            ColumnTQ.ReadOnly = true;
            ColumnTQ.Width = 125;
            // 
            // ColumnTT
            // 
            ColumnTT.DataPropertyName = "TrangThai";
            ColumnTT.HeaderText = "Trạng Thái";
            ColumnTT.MinimumWidth = 6;
            ColumnTT.Name = "ColumnTT";
            ColumnTT.ReadOnly = true;
            ColumnTT.Width = 200;
            // 
            // ColumnDay
            // 
            ColumnDay.DataPropertyName = "ngaythem";
            ColumnDay.HeaderText = "Ngày Thêm";
            ColumnDay.MinimumWidth = 6;
            ColumnDay.Name = "ColumnDay";
            ColumnDay.ReadOnly = true;
            ColumnDay.Width = 200;
            // 
            // FromQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1361, 691);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxfind);
            Controls.Add(label1);
            Name = "FromQuyen";
            Text = "FromQuyen";
            Load += FromQuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxfind;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnMoTa;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnTK;
        private DataGridViewTextBoxColumn ColumnTQ;
        private DataGridViewTextBoxColumn ColumnTT;
        private DataGridViewTextBoxColumn ColumnDay;
    }
}