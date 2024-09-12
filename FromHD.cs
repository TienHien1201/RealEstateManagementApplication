using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyNhaHang
{
    public partial class FromHD : Form
    {
        private JDBC.DataSql data = new JDBC.DataSql();
        private string username;
        public FromHD(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void FromHD_Load(object sender, EventArgs e)
        {
            LoadUserControls();
        }
        private void LoadUserControls()
        {
            // Lấy danh sách tên bàn từ cơ sở dữ liệu
            List<string> danhSachBan = data.GetDanhSachTenBan();

            foreach (var tenBan in danhSachBan)
            {
                UserBan userBan = new UserBan(this.username);
                userBan.Title = tenBan;
                // Thêm UserControl vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(userBan);
            }
        }
    }
}
