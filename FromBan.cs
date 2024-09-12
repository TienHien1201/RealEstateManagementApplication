using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    public partial class FromBan : Form
    {
        public FromBan()
        {
            InitializeComponent();
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void FromBan_Load(object sender, EventArgs e)
        {

            textBoxfind.Text = "Nhập ID hoặc tên bàn";
            textBoxfind.ForeColor = SystemColors.GrayText;
            resetdata();




        }

        public void resetdata()
        {
            dataGridView2.DataSource = data.LayDuLieu("Select * from ban");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FromThemBan fromThemBan = new FromThemBan(this);
            fromThemBan.ShowDialog();
        }

        private void textBoxfind_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxfind.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword == "Nhập ID hoặc tên bàn")
            {
                // Nếu từ khóa trống hoặc là văn bản mặc định, tải lại tất cả bàn
                resetdata();
                return;
            }

            string sql = "SELECT * FROM ban WHERE CAST(id AS NVARCHAR) LIKE @Keyword OR tenban LIKE @Keyword";

            try
            {
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = data.LayDuLieu(command);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu nhấp vào hàng hợp lệ
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                int idBan = (int)selectedRow.Cells["ColumnId"].Value;
                string tenBan = selectedRow.Cells["ColumntenBan"].Value.ToString();
                string moTa = selectedRow.Cells["ColumnMT"].Value.ToString();
                string trangThai = selectedRow.Cells["ColumnTrangThai"].Value.ToString();

                // Khởi tạo và hiển thị form chỉnh sửa/xóa
                FromSuaXoaBan fromSuaXoaBan = new FromSuaXoaBan(this, idBan, tenBan, moTa, trangThai);
                fromSuaXoaBan.ShowDialog();
            }
        }

        private void textBoxfind_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxfind.Text == "Nhập ID hoặc tên bàn")
            {
                textBoxfind.Text = "";
                textBoxfind.ForeColor = SystemColors.ControlText; // Màu văn bản khi có focus
            }
        }
    }
}
