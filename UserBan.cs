using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class UserBan : UserControl
    {
        private JDBC.DataSql data = new JDBC.DataSql();
        private bool isFromSettingOpen = false;
        private string username;
        public UserBan(string name)
        {
            InitializeComponent();
            this.username = name;
            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                if (item != thêmHóaĐơnToolStripMenuItem)
                {
                    item.Enabled = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void label2_MouseClick(object sender, MouseEventArgs e)
        {


            contextMenuStrip1.Show(Cursor.Position);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);

        }

        private void thêmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (isFromSettingOpen)
            {
                return;
            }
            this.BackColor = SystemColors.ControlDark;

            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                item.Enabled = true;

            }
            isFromSettingOpen = true;
            thêmHóaĐơnToolStripMenuItem.Enabled = false;

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                if (item != thêmHóaĐơnToolStripMenuItem)
                {
                    item.Enabled = false;
                }
            }
            int id = data.GetIdBanByName(this.Title);
            int idhd = data.GetIdHdByBan(id);
            bool success = data.XoaHoaDon(idhd);
            if (success)
            {
                MessageBox.Show("Xóa hóa đơn thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = SystemColors.Control;
                thêmHóaĐơnToolStripMenuItem.Enabled = true;
            }
            else
            {
               
                MessageBox.Show("Lỗi xóa hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xóaToolStripMenuItem.Enabled = true;
                thêmMónĂnToolStripMenuItem.Enabled = true;
            }
               
        }




        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void thêmMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromSetting fromSetting = new FromSetting(this.username);
            fromSetting.BanName = this.Title; // Truyền tên bàn qua form FromSetting
            fromSetting.ThanhToanThanhCong += FromSetting_ThanhToanThanhCong;
            fromSetting.ShowDialog();

        }
        private void FromSetting_ThanhToanThanhCong(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Thay đổi màu nền
        }
        public void LoadData()
        {
            int idBan = data.GetIdBanByName(this.Title);
            DataTable dt = data.GetDanhMucListIDBan();

            bool exists = false;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["idban"]) == idBan)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                this.BackColor = SystemColors.ControlDark;

                foreach (ToolStripItem item in contextMenuStrip1.Items)
                {
                    item.Enabled = true;
                    thêmHóaĐơnToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void UserBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public string Title { get => label1.Text; set => label1.Text = value; }
        public Image icon { get => pictureBox1.Image; set => pictureBox1.Image = value; }

    }
}
