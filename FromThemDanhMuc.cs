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
    public partial class FromThemDanhMuc : Form
    {
        private FromDanhMuc _fromDanhMuc;
        public FromThemDanhMuc(FromDanhMuc fromDanhMuc)
        {
            InitializeComponent();
            this._fromDanhMuc = fromDanhMuc;
        }
        JDBC.DataSql data = new JDBC.DataSql();

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


        private void FromThemDanhMuc_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id, ten FROM nguyenlieu";

            try
            {   
                DataTable dt = data.LayDuLieu(sql);


                DataRow row = dt.NewRow();
                row["id"] = DBNull.Value;
                row["ten"] = "Chọn nguyên liệu"; // Bạn có thể thay đổi thành chuỗi rỗng nếu muốn
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


        private void button1_Click(object sender, EventArgs e)
        {

            // Các giá trị khác từ các điều khiển
            string tenDanhMuc = textBox1.Text.Trim();
            string moTa = textBox2.Text.Trim();
            byte[] hinhAnh = imgagefile(this.Text); // Hàm để lấy dữ liệu hình ảnh
            DateTime ngayTao = DateTime.Now;

            if (string.IsNullOrEmpty(tenDanhMuc) || tenDanhMuc == "Tên Danh mục" ||
               string.IsNullOrEmpty(moTa) || moTa == "Giá Tiền")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Lấy giá trị từ ComboBox
            int idNguyenLieu;
            if (!int.TryParse(comboBox1.SelectedValue?.ToString(), out idNguyenLieu))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu từ danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sử dụng câu lệnh SQL với tham số
            string sql = "INSERT INTO danhmuc (hinhAnh, tenmonan, gia, ngaytao, idnguyenlieu) VALUES (@HinhAnh, @TenDanhMuc, @MoTa, @NgayTao, @IdNguyenLieu)";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@HinhAnh", (object)hinhAnh ?? DBNull.Value);
                command.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                command.Parameters.AddWithValue("@MoTa", moTa);
                command.Parameters.AddWithValue("@NgayTao", ngayTao);
                command.Parameters.AddWithValue("@IdNguyenLieu", idNguyenLieu);

                // Cập nhật cơ sở dữ liệu
                int result = data.CapNhatDuLieu(command);

                if (result > 0)
                {
                    MessageBox.Show(
                        "Danh mục đã được thêm thành công!",
                        "Thành Công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _fromDanhMuc.RefreshData();
                    load();
                    textBox2.Text = "Giá Tiền";
                    textBox1.Text = "Tên Danh mục";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Không thể thêm danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message);
            }

        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox2.Text == "Giá Tiền")
            {
                textBox2.Text = "";

            }
        }
        byte[] imgagefile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {

                MessageBox.Show("Vui lòng chọn ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {


            if (textBox1.Text == "Tên Danh mục")
            {
                textBox1.Text = "";

            }




        }
        void load()
        {
            textBox1.Text = "Tên Danh mục";
            textBox2.Text = "Giá Tiền";
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
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
