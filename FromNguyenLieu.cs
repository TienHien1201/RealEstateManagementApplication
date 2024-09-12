using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    public partial class FromNguyenLieu : Form
    {
        public FromNguyenLieu()
        {
            InitializeComponent();
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void FromNguyenLieu_Load(object sender, EventArgs e)
        {

            textBoxfind.Text = "Nhập ID hoặc tên nguyên liệu";
            textBoxfind.ForeColor = SystemColors.GrayText;

            load();

        }

        public void load()
        {

            DataTable dt = data.LayDuLieu("select nguyenlieu.id,nguyenlieu.ten,mota,daysanxuat,hansudung,soluong,nguyenlieu.ngaythem,donvi, nhacungcap.ten AS TenNhaCungCap from nguyenlieu join nhacungcap on nguyenlieu.idnhacungcap = nhacungcap.id");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromThemNguyenLieu fromThemNguyenLieu = new FromThemNguyenLieu(this);
            fromThemNguyenLieu.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu nhấp vào hàng hợp lệ
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int idNguyenLieu = (int)selectedRow.Cells["ColumnID"].Value;
                string ten = selectedRow.Cells["ColumnTen"].Value.ToString();
                string moTa = selectedRow.Cells["ColumnMT"].Value.ToString();
                DateTime ngaySanXuat = (DateTime)selectedRow.Cells["ColumnDaySX"].Value;
                DateTime hanSuDung = (DateTime)selectedRow.Cells["ColumnDaySD"].Value;
                int soLuong = (int)selectedRow.Cells["ColumnSL"].Value;
                string donVi = selectedRow.Cells["ColumnDonVi"].Value.ToString();
                string nhaCungCap = selectedRow.Cells["ColumnNCC"].Value.ToString();

                FromSuaXoaNguyenLieu fromSuaXoaNguyenLieu = new FromSuaXoaNguyenLieu(this, idNguyenLieu, ten, moTa, ngaySanXuat, hanSuDung, soLuong, donVi, nhaCungCap);
                fromSuaXoaNguyenLieu.ShowDialog();
            }

        }

        private void textBoxfind_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxfind.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword == "Nhập ID hoặc tên nguyên liệu")
            {
                // Nếu từ khóa trống hoặc là văn bản mặc định, tải lại tất cả nguyên liệu
                load();
                return;
            }

            // Câu lệnh SQL tìm kiếm theo ID hoặc tên nguyên liệu
            string sql = "SELECT nguyenlieu.id, nguyenlieu.ten, mota, daysanxuat, hansudung, soluong, nguyenlieu.ngaythem, donvi, nhacungcap.ten as nhaCungCap " +
                         "FROM nguyenlieu " +
                         "JOIN nhacungcap ON nguyenlieu.idnhacungcap = nhacungcap.id " +
                         "WHERE CAST(nguyenlieu.id AS NVARCHAR) LIKE @Keyword OR nguyenlieu.ten LIKE @Keyword";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                // Thực thi câu lệnh SQL và lấy dữ liệu
                DataTable dt = data.LayDuLieu(command);

                // Hiển thị dữ liệu lên DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxfind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxfind.Text))
            {
                textBoxfind.Text = "Nhập ID hoặc tên nguyên liệu";
                textBoxfind.ForeColor = SystemColors.GrayText; // Màu văn bản mặc định
            }
        }

        private void textBoxfind_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxfind.Text == "Nhập ID hoặc tên nguyên liệu")
            {
                textBoxfind.Text = "";
            }
        }
    }
}
