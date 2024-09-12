using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FromSuaXoaNguyenLieu : Form
    {
        private FromNguyenLieu _FromNguyenLieu;
        private int idNguyenLieu;
        private string ten;
        private string moTa;
        private DateTime ngaySanXuat;
        private DateTime hanSuDung;
        private int soLuong;
        private string donVi;
        private string nhaCungCap;
        JDBC.DataSql data = new JDBC.DataSql();

        public FromSuaXoaNguyenLieu(FromNguyenLieu _FromNguyenLieu, int id, string ten, string moTa, DateTime ngaySanXuat, DateTime hanSuDung, int soLuong, string donVi, string nhaCungCap)
        {
            InitializeComponent();
            this._FromNguyenLieu = _FromNguyenLieu;
            this.idNguyenLieu = id;
            this.ten = ten;
            this.moTa = moTa;
            this.ngaySanXuat = ngaySanXuat;
            this.hanSuDung = hanSuDung;
            this.soLuong = soLuong;
            this.donVi = donVi;
            this.nhaCungCap = nhaCungCap;
        }

        private void FromSuaXoaNguyenLieu_Load(object sender, EventArgs e)
        {
            textBox1.Text = ten;
            textBox2.Text = moTa;
            dateTimePicker1.Value = ngaySanXuat;
            dateTimePicker2.Value = hanSuDung;
            textBox3.Text = soLuong.ToString();
            comboBox2.SelectedItem = donVi;
            load();
            comboBox1.SelectedText = nhaCungCap;
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
                comboBox1.SelectedIndex = 0; // Đặt chỉ số mặc định nếu cần
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Câu lệnh SQL để xóa nguyên liệu
                string sql = "DELETE FROM nguyenlieu WHERE id = @IdNguyenLieu";

                try
                {
                    // Tạo đối tượng SqlCommand và thêm tham số
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@IdNguyenLieu", idNguyenLieu);

                    // Xóa nguyên liệu từ cơ sở dữ liệu
                    int result = data.CapNhatDuLieu(command);

                    if (result > 0)
                    {
                        MessageBox.Show("Nguyên liệu đã được xóa thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FromNguyenLieu.load(); // Cập nhật dữ liệu trong form chính
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Xác thực dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                !int.TryParse(textBox3.Text.Trim(), out int soLuong) || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và đảm bảo số lượng là số hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy các giá trị từ các điều khiển
            string ten = textBox1.Text.Trim();
            string moTa = textBox2.Text.Trim();
            DateTime ngaySanXuat = dateTimePicker1.Value;
            DateTime hanSuDung = dateTimePicker2.Value;
            string donVi = comboBox2.SelectedItem?.ToString();
            string nhaCungCap = comboBox1.SelectedValue?.ToString();
            int soluong = int.Parse(textBox3.Text.Trim());

            // Câu lệnh SQL để cập nhật nguyên liệu
            string sql = "UPDATE nguyenlieu SET ten = @Ten, mota = @MoTa, daysanxuat = @NgaySanXuat, hansudung = @HanSuDung, soluong = @SoLuong, donvi = @DonVi, idnhacungcap = @NhaCungCap WHERE id = @IdNguyenLieu";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@Ten", ten);
                command.Parameters.AddWithValue("@MoTa", moTa);
                command.Parameters.AddWithValue("@NgaySanXuat", ngaySanXuat);
                command.Parameters.AddWithValue("@HanSuDung", hanSuDung);
                command.Parameters.AddWithValue("@SoLuong", soluong);
                command.Parameters.AddWithValue("@DonVi", donVi);
                command.Parameters.AddWithValue("@NhaCungCap", nhaCungCap);
                command.Parameters.AddWithValue("@IdNguyenLieu", idNguyenLieu);

                // Cập nhật nguyên liệu trong cơ sở dữ liệu
                int result = data.CapNhatDuLieu(command);

                if (result > 0)
                {
                    MessageBox.Show("Nguyên liệu đã được cập nhật thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FromNguyenLieu.load(); // Cập nhật dữ liệu trong form chính
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
