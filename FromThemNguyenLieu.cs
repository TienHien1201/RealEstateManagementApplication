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
    public partial class FromThemNguyenLieu : Form
    {
        private FromNguyenLieu _FromNguyenLieu;
        public FromThemNguyenLieu(FromNguyenLieu _FromNguyenLieu)
        {
            InitializeComponent();
            this._FromNguyenLieu = _FromNguyenLieu;
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void button1_Click(object sender, EventArgs e)
        {
            string tenNguyenLieu = textBox1.Text.Trim();
            string moTa = textBox2.Text.Trim();
            DateTime ngaySanXuat = dateTimePicker1.Value;
            DateTime hanSuDung = dateTimePicker2.Value;
            int soLuong;
            string donVi = comboBox2.SelectedItem?.ToString();
            int? idNhaCungCap = comboBox1.SelectedValue as int?;

            // Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrEmpty(tenNguyenLieu) || donVi == null || textBox3.Text == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBox3.Text.Trim(), out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO nguyenlieu (ten, mota, daysanxuat, hansudung, soluong, donvi, idnhacungcap) " +
                         "VALUES (@ten, @mota, @daysanxuat, @hansudung, @soluong, @donvi, @idnhacungcap)";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@ten", tenNguyenLieu);
                    command.Parameters.AddWithValue("@mota", (object)moTa ?? DBNull.Value);
                    command.Parameters.AddWithValue("@daysanxuat", ngaySanXuat);
                    command.Parameters.AddWithValue("@hansudung", hanSuDung);
                    command.Parameters.AddWithValue("@soluong", soLuong);
                    command.Parameters.AddWithValue("@donvi", donVi);
                    command.Parameters.AddWithValue("@idnhacungcap", (object)idNhaCungCap ?? DBNull.Value);

                    // Thực hiện lệnh SQL
                    int success = data.CapNhatDuLieu(command);

                    if (success > 0)
                    {
                        MessageBox.Show("Thêm nguyên liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FromNguyenLieu.load(); // Cập nhật dữ liệu trong form danh sách nguyên liệu nếu cần
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = -1; // Hoặc giá trị mặc định khác nếu cần
        }
        private void FromThemNguyenLieu_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            string sql = "SELECT id, ten FROM nhacungcap";

            try
            {
                DataTable dt = data.LayDuLieu(sql);


                DataRow row = dt.NewRow();
                row["id"] = DBNull.Value;
                row["ten"] = "Chọn nhà cung cấp "; // Bạn có thể thay đổi thành chuỗi rỗng nếu muốn
                dt.Rows.InsertAt(row, 0);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ten";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
