using Microsoft.Data.SqlClient;
using QuanLyNhaHang.JDBC;
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
    public partial class FromSuaXoaQuyen : Form
    {
        private int idQuyen;
        private string moTa;
        private string email;
        private string trangThai;
        private string quyen;
        private string tentk;
        FromQuyen fromquen;


        JDBC.DataSql data = new JDBC.DataSql();
        public FromSuaXoaQuyen(FromQuyen fromquen, int idQuyen, string moTa, string email, string trangThai, string quyen, string tentk)
        {
            this.fromquen = fromquen;
            InitializeComponent();
            this.idQuyen = idQuyen;
            this.moTa = moTa;
            this.email = email;
            this.trangThai = trangThai;
            this.quyen = quyen;
            this.tentk = tentk;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string tenNhanVien = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string matKhau = textBox3.Text.Trim(); // Mật khẩu mới
            string tenTaiKhoan = textBox4.Text.Trim();
            string trangThai = comboBox2.SelectedItem?.ToString() ?? "";
            string quyen = comboBox1.SelectedItem?.ToString() ?? "";

            int trangThaiId = trangThai == "Hoạt động" ? 1 : 0;
            int quyenId = quyen.Equals("Nhân viên", StringComparison.OrdinalIgnoreCase) ? 1 : 2;

            if (string.IsNullOrEmpty(tenNhanVien) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(trangThai) || string.IsNullOrEmpty(quyen) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Cập nhật thông tin quyền
                string sqlUpdateQuyen = "UPDATE quyen SET mota = @mota, email = @email, trangthai = @trangthai WHERE id = @id";
                using (var commandUpdateQuyen = new SqlCommand(sqlUpdateQuyen))
                {
                    commandUpdateQuyen.Parameters.AddWithValue("@mota", tenNhanVien);
                    commandUpdateQuyen.Parameters.AddWithValue("@email", email);
                    commandUpdateQuyen.Parameters.AddWithValue("@trangthai", trangThaiId);
                    commandUpdateQuyen.Parameters.AddWithValue("@id", idQuyen);
                    int rowsAffected = await data.CapNhatDuLieuAsync(commandUpdateQuyen);


                }

                // Cập nhật mật khẩu tài khoản
                if (!string.IsNullOrEmpty(matKhau))
                {
                    string sqlUpdateAccount = "UPDATE account SET pass = @pass, thamquyen = @thamquyen WHERE taikhoan = @taikhoan";
                    using (var commandUpdateAccount = new SqlCommand(sqlUpdateAccount))
                    {
                        commandUpdateAccount.Parameters.AddWithValue("@pass", EncryptPassword(matKhau));
                        commandUpdateAccount.Parameters.AddWithValue("@thamquyen", quyenId);
                        commandUpdateAccount.Parameters.AddWithValue("@taikhoan", tenTaiKhoan);
                        int rowsAffected = await data.CapNhatDuLieuAsync(commandUpdateAccount);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("acount ko tìm thấy quyền để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                this.Close();
                fromquen.load(); // Giả sử phương thức Load() cập nhật dữ liệu trên form FromQuyen
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                data.NgatKetNoi(); // Ngắt kết nối trong khối finally để đảm bảo luôn được thực hiện
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM quyen WHERE id = @Id"))
                    {
                        command.Parameters.AddWithValue("@Id", idQuyen);
                        int rowsAffected = data.CapNhatDuLieu(command);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Quyền đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fromquen.load();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy quyền để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void FromSuaXoaQuyen_Load(object sender, EventArgs e)
        {
            textBox1.Text = moTa;
            textBox2.Text = email;
            textBox3.Text = "";
            textBox4.Text = tentk;
            comboBox2.SelectedItem = trangThai == "Hoạt động" ? "Hoạt động" : "Ngưng hoạt động";
            comboBox1.SelectedItem = quyen == "Admin" ? "Admin" : "Nhân viên";

        }
        private byte[] EncryptPassword(string password)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
