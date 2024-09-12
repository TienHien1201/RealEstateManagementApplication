using Microsoft.Data.SqlClient;
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
    public partial class FromThemQuyen : Form
    {
        private FromQuyen fromQuyen;
        JDBC.DataSql data = new JDBC.DataSql();
        public FromThemQuyen(FromQuyen fromQuyen)
        {
            this.fromQuyen = fromQuyen;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string tenNhanVien = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string tenTaiKhoan = textBox4.Text.Trim();
            string thamQuyen = comboBox1.SelectedItem?.ToString();
            int trangThai = 1;
            int quyen = thamQuyen.Equals("Nhân viên", StringComparison.OrdinalIgnoreCase) ? 1 : 2;
            if (string.IsNullOrEmpty(tenNhanVien) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tenTaiKhoan) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string connectionString = "Data Source=an\\TAN;Initial Catalog=QLNHAHANG3;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Thêm quyền vào bảng quyen
                    string sqlQuyen = "INSERT INTO quyen (mota, email, trangthai) OUTPUT INSERTED.id VALUES (@mota, @email, @trangthai)";
                    int idQuyen;
                    using (SqlCommand commandQuyen = new SqlCommand(sqlQuyen, connection))
                    {
                        commandQuyen.Parameters.AddWithValue("@mota", tenNhanVien);
                        commandQuyen.Parameters.AddWithValue("@email", email);
                        commandQuyen.Parameters.AddWithValue("@trangthai", trangThai);
                        idQuyen = (int)await commandQuyen.ExecuteScalarAsync();
                    }

                    // Thêm tài khoản vào bảng account
                    string sqlAccount = "INSERT INTO account (taikhoan, pass, thamquyen, idquyen) VALUES (@taikhoan, @pass, @thamquyen, @idquyen)";
                    using (SqlCommand commandAccount = new SqlCommand(sqlAccount, connection))
                    {
                        commandAccount.Parameters.AddWithValue("@taikhoan", tenTaiKhoan);
                        commandAccount.Parameters.AddWithValue("@pass", EncryptPassword("123456")); // Bạn có thể thay đổi mật khẩu theo yêu cầu
                        commandAccount.Parameters.AddWithValue("@thamquyen", 1);
                        commandAccount.Parameters.AddWithValue("@idquyen", idQuyen);
                        await commandAccount.ExecuteNonQueryAsync();
                    }
                }

                MessageBox.Show($"Thêm quyền và tài khoản thành công. Tên tài khoản: {tenTaiKhoan} , mật khẩu mặc định:123456" ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
             
                fromQuyen.load(); // Giả sử phương thức Load() cập nhật dữ liệu trên form FromQuyen
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ResetForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox1.SelectedIndex = -1; // Đặt lại comboBox về trạng thái chưa chọn
        }
        private byte[] EncryptPassword(string password)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private void FromThemQuyen_Load(object sender, EventArgs e)
        {

        }
    }
}
