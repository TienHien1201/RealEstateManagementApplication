using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    public partial class FromNhaCungCap : Form
    {
        public FromNhaCungCap()
        {
            InitializeComponent();
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void FromNhaCungCap_Load(object sender, EventArgs e)
        {
            load();
            textBoxfind.Text = "Nhập ID hoặc tên nhà cung cấp";
            textBoxfind.ForeColor = SystemColors.GrayText;

        }

      
        public void load()
        {
            string sql = "  select * from nhacungcap";
            DataTable dt = data.LayDuLieu(sql);
            dataGridView1.DataSource = dt;
        }
    

        private void textBoxfind_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxfind.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword == "Nhập ID hoặc tên nhà cung cấp")
            {
                // Nếu từ khóa trống hoặc là văn bản mặc định, tải lại tất cả nhà cung cấp
                load();
                return;
            }

            // Câu lệnh SQL tìm kiếm theo ID hoặc tên nhà cung cấp
            string sql = "SELECT * FROM nhacungcap WHERE CAST(id AS NVARCHAR) LIKE @Keyword OR ten LIKE @Keyword";

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
                MessageBox.Show("Lỗi khi tìm kiếm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxfind_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxfind.Text == "Nhập ID hoặc tên nhà cung cấp")
            {
                textBoxfind.Text = "";
            }
        }

        private void textBoxfind_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxfind.Text))
            {
                textBoxfind.Text = "Nhập ID hoặc tên nhà cung cấp";
                textBoxfind.ForeColor = SystemColors.GrayText; // Màu văn bản mặc định
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             if (e.RowIndex >= 0) // Kiểm tra rằng có chọn một hàng
    {
        // Lấy dữ liệu từ dòng được chọn
        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        int id = Convert.ToInt32(row.Cells["ColumnID"].Value);
        string ten = row.Cells["ColumnTen"].Value.ToString();
        string email = row.Cells["ColumnEmail"].Value.ToString();
        string phone = row.Cells["ColumnPhone"].Value.ToString();
        string address = row.Cells["ColumnAddress"].Value.ToString();

        // Tạo instance của form sửa/xóa nhà cung cấp
        FromSuaXoaNhaCungCap fromSuaXoa = new FromSuaXoaNhaCungCap(this);
        
        // Gán dữ liệu cho form sửa/xóa nhà cung cấp
        fromSuaXoa.SetNhaCungCapInfo(id, ten, email, phone, address);
        
        // Hiển thị form sửa/xóa nhà cung cấp
        fromSuaXoa.ShowDialog();
    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromTheomNha_CungCap fromTheomNha_CungCap = new FromTheomNha_CungCap(this);
            fromTheomNha_CungCap.ShowDialog();
        }
    }
}
