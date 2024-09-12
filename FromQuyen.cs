using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    public partial class FromQuyen : Form
    {
        public FromQuyen()
        {
            InitializeComponent();
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void FromQuyen_Load(object sender, EventArgs e)
        {
            load();
            textBoxfind.Text = "Nhập ID hoặc tên nhân viên";
            textBoxfind.ForeColor = SystemColors.GrayText;
        }
        public void load()
        {

            string sql = @"
          SELECT 
            quyen.id,
            quyen.mota,
            quyen.email,
            account.taikhoan,
            CASE WHEN account.thamquyen = 2 THEN 'Admin' ELSE N'Nhân viên' END AS Quyen,
            CASE WHEN quyen.trangthai = 1 THEN N'Hoạt động' ELSE N'Ngưng hoạt động' END AS TrangThai,
            quyen.ngaythem
        FROM 
            quyen 
            JOIN account ON quyen.id = account.idquyen";

            DataTable dt = data.LayDuLieu(sql);
            dataGridView1.DataSource = dt;

        }

        private void textBoxfind_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxfind.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword == "Nhập ID hoặc tên nhân viên")
            {
                // Nếu từ khóa trống hoặc là văn bản mặc định, tải lại tất cả nhà cung cấp
                load();
                return;
            }

            // Câu lệnh SQL tìm kiếm theo ID hoặc tên nhà cung cấp
            string sql = @"
          SELECT 
            quyen.id,
            quyen.mota,
            quyen.email,
            account.taikhoan,
            CASE WHEN account.thamquyen = 2 THEN 'Admin' ELSE 'Nhân viên' END AS Quyen,
            CASE WHEN quyen.trangthai = 1 THEN 'Hoạt động' ELSE 'Ngưng hoạt động' END AS TrangThai,
            quyen.ngaythem
        FROM 
            quyen 
            JOIN account ON quyen.id = account.idquyen
        WHERE 
            CAST(quyen.id AS NVARCHAR) LIKE @Keyword 
            OR quyen.mota LIKE @Keyword";
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
                MessageBox.Show("Lỗi khi tìm kiếm quyền nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxfind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxfind.Text))
            {
                textBoxfind.Text = "Nhập ID hoặc tên nhân viên";
                textBoxfind.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxfind_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxfind.Text == "Nhập ID hoặc tên nhân viên")
            {
                textBoxfind.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromThemQuyen fromThemQuyen = new FromThemQuyen(this);
            fromThemQuyen.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu nhấp vào hàng hợp lệ
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int idQuyen = (int)selectedRow.Cells["ColumnId"].Value;
                string moTa = selectedRow.Cells["ColumnMoTa"].Value.ToString();
                string email = selectedRow.Cells["ColumnEmail"].Value.ToString();
                string trangThai = selectedRow.Cells["ColumnTT"].Value.ToString(); // Giả sử trang thái lưu dưới dạng chuỗi
                string thamquyen = selectedRow.Cells["ColumnTQ"].Value.ToString();
                string tentaikhoam = selectedRow.Cells["ColumnTK"].Value.ToString();

                FromSuaXoaQuyen fromSuaXoaQuyen = new FromSuaXoaQuyen(this, idQuyen, moTa, email, trangThai, thamquyen, tentaikhoam);
                fromSuaXoaQuyen.ShowDialog();
            }
        }
    }
}
