namespace QuanLyNhaHang
{
    partial class UserBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBan));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            thêmHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            thêmMónĂnToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 61);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 1;
            label1.Text = "Bàn 1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { thêmHóaĐơnToolStripMenuItem, thêmMónĂnToolStripMenuItem, xóaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 76);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // thêmHóaĐơnToolStripMenuItem
            // 
            thêmHóaĐơnToolStripMenuItem.Name = "thêmHóaĐơnToolStripMenuItem";
            thêmHóaĐơnToolStripMenuItem.Size = new Size(171, 24);
            thêmHóaĐơnToolStripMenuItem.Text = "Tạo Hóa Đơn";
            thêmHóaĐơnToolStripMenuItem.Click += thêmHóaĐơnToolStripMenuItem_Click;
            // 
            // thêmMónĂnToolStripMenuItem
            // 
            thêmMónĂnToolStripMenuItem.Name = "thêmMónĂnToolStripMenuItem";
            thêmMónĂnToolStripMenuItem.Size = new Size(171, 24);
            thêmMónĂnToolStripMenuItem.Text = "Thêm Món Ăn";
            thêmMónĂnToolStripMenuItem.Click += thêmMónĂnToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(171, 24);
            xóaToolStripMenuItem.Text = "Xóa Hóa Đơn";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Image = Properties.Resources.Ellipsis_1;
            label2.Location = new Point(105, 10);
            label2.Name = "label2";
            label2.Size = new Size(53, 22);
            label2.TabIndex = 2;
            label2.Click += label2_Click_1;
            label2.MouseClick += label2_MouseClick;
            // 
            // UserBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UserBan";
            Size = new Size(197, 101);
            Load += UserBan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem thêmHóaĐơnToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem thêmMónĂnToolStripMenuItem;
    }
}
