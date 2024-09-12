using Microsoft.Data.SqlClient;
using QuanLyNhaHang.ThuVien;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FromDangNhap : Form
    {
        public FromDangNhap()
        {
            InitializeComponent();
        }

        JDBC.DataSql data = new JDBC.DataSql();

        private void FromDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void checkMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMatKhau.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int count = 0;

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên đăng nhập và mật khẩu không được để trống
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số lần đăng nhập sai
            if (count >= 3)
            {
                MessageBox.Show("Bạn đã đăng nhập sai quá số lần quy định, chương trình sẽ tự động thoát!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            string username = txtUser.Text.Trim();
            byte[] password = ThuVien.ThuVien.MD5Hash(txtPassword.Text.Trim()); // Mã hóa mật khẩu bằng MD5

            try
            {
                // Xây dựng câu lệnh SQL với tham số hóa
                string sql = "SELECT * FROM account JOIN quyen ON account.idquyen = quyen.id WHERE account.taikhoan = @username AND account.pass = @password AND quyen.trangthai = 1";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                DataTable dt = data.LayDuLieu(command);

                if (dt.Rows.Count > 0)
                {
                    // Đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string maQuyen = dt.Rows[0]["thamquyen"].ToString();

                    this.Hide(); // Ẩn form đăng nhập
                    if (maQuyen == "2") // Chủ shop
                    {
                        FormNhaHang formNhaHang = new FormNhaHang(username);
                        formNhaHang.ShowDialog();
                        formNhaHang = null;
                        this.Show();

                    }
                    else if (maQuyen == "1") // Nhân viên
                    {
                        FromSinhVien fromSinhVien = new FromSinhVien(username);
                        fromSinhVien.ShowDialog();
                        fromSinhVien = null;
                        this.Show();
                    }
                    this.Close();
                }
                else
                {
                    count++;
                    MessageBox.Show($"Thông tin đăng nhập không đúng hoặc tài khoản đã bị khóa!\nBạn đã đăng nhập sai {count} lần, còn {3 - count} lần!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangnhap.PerformClick();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
