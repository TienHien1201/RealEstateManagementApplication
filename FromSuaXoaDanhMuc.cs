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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyNhaHang
{
    public partial class FromSuaXoaDanhMuc : Form
    {
        private FromDanhMuc _fromDanhMuc;
        private int _idDanhMuc;
        private byte[] _hinhAnhCu; // Lưu trữ hình ảnh cũ
        private string _nguyenLieu;
        public FromSuaXoaDanhMuc(FromDanhMuc fromDanhMuc, int idDanhMuc, string tenDanhMuc, string moTa, string nguyenlieu, byte[] hinhAnh, DateTime ngayTao)
        {
            InitializeComponent();
            this._fromDanhMuc = fromDanhMuc;
            this._idDanhMuc = idDanhMuc;
            this._nguyenLieu = nguyenlieu;
            comboBox1.SelectedText = nguyenlieu;
            // Đưa dữ liệu lên các điều khiển
            textBox1.Text = tenDanhMuc;
            textBox2.Text = moTa;
            this._hinhAnhCu = hinhAnh; // Gán hình ảnh cũ
            if (hinhAnh != null)
            {
                using (var ms = new MemoryStream(hinhAnh))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
        JDBC.DataSql data = new JDBC.DataSql();

        byte[] imgagefile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {

                MessageBox.Show($"Tệp không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult ok = ofd.ShowDialog();

            if (ok == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                this.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = textBox1.Text.Trim();
            string moTa = textBox2.Text.Trim();
            byte[] hinhAnh = null; // Lấy ảnh từ PictureBox
            int idDanhMuc = _idDanhMuc;
            DateTime ngayTao = DateTime.Now;
            string ngl = comboBox1.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(this.Text) && File.Exists(this.Text))
            {
                hinhAnh = imgagefile(this.Text); // Lấy ảnh từ PictureBox
            }
            else
            {
                hinhAnh = _hinhAnhCu; // Sử dụng ảnh cũ nếu người dùng không chọn ảnh mới
            }

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(tenDanhMuc) || tenDanhMuc == "Tên Danh mục" ||
                string.IsNullOrEmpty(moTa) || moTa == "Giá Tiền")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Câu lệnh SQL với tham số
            string sql = "UPDATE danhmuc SET hinhAnh = @HinhAnh, tenmonan = @TenDanhMuc, gia = @MoTa, ngaytao = @NgayTao, idnguyenlieu = @NguyenLieu WHERE id = @IdDanhMuc";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@HinhAnh", (object)hinhAnh ?? DBNull.Value);
                command.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                command.Parameters.AddWithValue("@MoTa", moTa);
                command.Parameters.AddWithValue("@NgayTao", ngayTao);
                command.Parameters.AddWithValue("@NguyenLieu", ngl);
                command.Parameters.AddWithValue("@IdDanhMuc", idDanhMuc);

                // Cập nhật cơ sở dữ liệu
                int result = data.CapNhatDuLieu(command);

                if (result > 0)
                {
                    MessageBox.Show("Danh mục đã được cập nhật thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _fromDanhMuc.RefreshData();

                    load();
                    pictureBox1.Image = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            void load()
            {
                textBox1.Text = "Tên Danh mục";
                textBox2.Text = "Giá Tiền";
            }


        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox2.Text == "Giá Tiền")
            {
                textBox2.Text = "";

            }

        }

        private void FromSuaXoaDanhMuc_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id, ten FROM nguyenlieu";

            try
            {
                DataTable dt = data.LayDuLieu(sql);

                // Thêm một hàng trống hoặc một mục mặc định vào DataTable
                DataRow row = dt.NewRow();
                row["id"] = DBNull.Value;
                row["ten"] = "Chọn nguyên liệu"; // Bạn có thể thay đổi thành chuỗi rỗng nếu muốn
                dt.Rows.InsertAt(row, 0);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ten";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = 0; // Đặt giá trị mặc định là mục đầu tiên

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["ten"].ToString() == _nguyenLieu)
                    {
                        comboBox1.SelectedValue = dr["id"];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Tên Danh mục")
            {
                textBox1.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Câu lệnh SQL để xóa danh mục
                string sql = "DELETE FROM danhmuc WHERE id = @IdDanhMuc";

                try
                {
                    // Tạo đối tượng SqlCommand và thêm tham số
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@IdDanhMuc", _idDanhMuc);

                    // Xóa danh mục từ cơ sở dữ liệu
                    int result = data.CapNhatDuLieu(command);

                    if (result > 0)
                    {
                        MessageBox.Show("Danh mục đã được xóa thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _fromDanhMuc.RefreshData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
