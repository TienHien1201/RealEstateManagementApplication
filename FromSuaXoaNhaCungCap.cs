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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaHang
{
    public partial class FromSuaXoaNhaCungCap : Form
    {
        private FromNhaCungCap _FromNhaCungCap;
        JDBC.DataSql data = new JDBC.DataSql();
        private int idncc;
        public FromSuaXoaNhaCungCap(FromNhaCungCap _FromNhaCungCap)
        {
            InitializeComponent();
            this._FromNhaCungCap = _FromNhaCungCap;
        }
        public void SetNhaCungCapInfo(int id, string ten, string email, string phone, string address)
        {
            // Gán dữ liệu cho các điều khiển trên form
            idncc = id; // Giả sử bạn có một TextBox để hiển thị ID
            textBoxTen.Text = ten;
            textBoxEmail.Text = email;
            textBoxPhone.Text = phone;
            textBoxAddress.Text = address;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM nhacungcap WHERE id = @ID";

                try
                {
                    // Tạo đối tượng SqlCommand và thêm tham số
                    using (SqlCommand command = new SqlCommand(sql))
                    {
                        command.Parameters.AddWithValue("@ID", idncc);

                        // Thực thi câu lệnh SQL
                        data.CapNhatDuLieu(command);

                        MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FromNhaCungCap.load();
                        this.Close(); // Đóng form sau khi xóa thành công
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ten = textBoxTen.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAddress.Focus();
                return;
            }
            // Câu lệnh SQL để cập nhật thông tin nhà cung cấp
            string sql = "UPDATE nhacungcap SET ten = @Ten, email = @Email, phone = @Phone, diachi = @Address WHERE id = @ID";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@ID", idncc);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);

                    // Thực thi câu lệnh SQL
                    data.CapNhatDuLieu(command);

                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FromNhaCungCap.load();
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FromSuaXoaNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
