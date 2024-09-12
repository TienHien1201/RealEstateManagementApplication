using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class FromDanhMuc : Form
    {
        public FromDanhMuc()
        {
            InitializeComponent();
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void FromDanhMuc_Load(object sender, EventArgs e)
        {

            textBoxfind.Text = "Nhập ID hoặc tên danh mục";
            textBoxfind.ForeColor = SystemColors.GrayText;
            LoadDanhMuc();

        }
        public void RefreshData()
        {
            LoadDanhMuc();
        }
        public void LoadDanhMuc()
        {
            string sql = "  select danhmuc.id,hinhAnh,tenmonan,danhmuc.gia,ngaytao, nguyenlieu.ten from danhmuc join nguyenlieu on danhmuc.idnguyenlieu = nguyenlieu.id;";
            DataTable dt = data.LayDuLieu(sql);
            dataGridView1.DataSource = dt;
        }

        private void textBoxfind_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxfind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxfind.Text))
            {
                textBoxfind.Text = "Nhập ID hoặc tên danh mục";
                textBoxfind.ForeColor = SystemColors.GrayText; // Màu văn bản mặc định
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromThemDanhMuc fromThemDanhMuc = new FromThemDanhMuc(this);
            fromThemDanhMuc.ShowDialog();
        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu nhấp vào hàng hợp lệ
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int idDanhMuc = (int)selectedRow.Cells["ColumnId"].Value;
                string tenDanhMuc = selectedRow.Cells["ColumnTenDanhMuc"].Value.ToString();
                string moTa = selectedRow.Cells["ColumnMoTa"].Value.ToString();
                byte[] hinhAnh = selectedRow.Cells["cloumnHinhAnh"].Value as byte[];
                DateTime ngayTao = (DateTime)selectedRow.Cells["ColumnDayTao"].Value;
                string nglieu = selectedRow.Cells["nguyenlieu"].Value.ToString();
                FromSuaXoaDanhMuc fromSuaXoaDanhMuc = new FromSuaXoaDanhMuc(this, idDanhMuc, tenDanhMuc, moTa, nglieu, hinhAnh, ngayTao);
                fromSuaXoaDanhMuc.ShowDialog();
            }
        }

        private void textBoxfind_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBoxfind_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxfind.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword == "Nhập ID hoặc tên danh mục")
            {
                // Nếu từ khóa trống hoặc là văn bản mặc định, tải lại tất cả danh mục
                LoadDanhMuc();
                return;
            }

            // Câu lệnh SQL tìm kiếm theo ID hoặc tên danh mục
            string sql = "SELECT id, hinhAnh, tenmonan, gia, ngaytao FROM danhmuc WHERE CAST(id AS NVARCHAR) LIKE @Keyword OR tenmonan LIKE @Keyword";

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
                MessageBox.Show("Lỗi khi tìm kiếm danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
