namespace QuanLyNhaHang
{
    partial class FromTheomNha_CungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromTheomNha_CungCap));
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 35);
            label1.TabIndex = 32;
            label1.Text = "THÊM NHÀ CUNG CẤP MỚI";
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ButtonShadow;
            textBox3.Location = new Point(121, 386);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(454, 48);
            textBox3.TabIndex = 61;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(118, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 48);
            textBox1.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 351);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 57;
            label7.Text = "Địa chỉ:";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 159);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 52;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 71);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 51;
            label3.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 253);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 50;
            label2.Text = "Số điện thoại:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(457, 452);
            button1.Name = "button1";
            button1.Size = new Size(118, 47);
            button1.TabIndex = 48;
            button1.Text = "THÊM";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(121, 182);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 48);
            textBox2.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ButtonShadow;
            textBox4.Location = new Point(121, 276);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(454, 37);
            textBox4.TabIndex = 62;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // FromTheomNha_CungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(698, 596);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Name = "FromTheomNha_CungCap";
            Text = "FromTheomNha_CungCap";
            Load += FromTheomNha_CungCap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox4;
    }
}