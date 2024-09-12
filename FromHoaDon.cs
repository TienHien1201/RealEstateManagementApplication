using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class FromHoaDon : Form
    {
        public FromHoaDon()
        {
            InitializeComponent();
        }

        JDBC.DataSql data = new JDBC.DataSql();
        public void LoadDanhMuc()
        {
            string sql = @"
        SELECT 
            h.id AS idhd,
            b.tenban,
            h.tongtien,
            h.trangthai,
            h.ngaytao,
            h.tennguoidung,
            COUNT(ctd.idmonan) AS soLuongMonan,
            STRING_AGG(dm.tenmonan, ', ') AS danhMucMonAn
        FROM 
            hoadon h
        JOIN 
            ban b ON h.idban = b.id
        JOIN 
            CTHoaDon ctd ON h.id = ctd.SoHD
        JOIN 
            danhmuc dm ON ctd.idmonan = dm.id
        GROUP BY 
            h.id, b.tenban, h.tongtien, h.trangthai, h.ngaytao, h.tennguoidung;";

            // Lấy dữ liệu từ cơ sở dữ liệu

            DataTable dt = data.LayDuLieu(sql);
            dataGridView1.DataSource = dt;
        }
        private void FromHoaDon_Load(object sender, EventArgs e)
        {

            textBoxfind.Text = "Nhập ID";
            textBoxfind.ForeColor = SystemColors.GrayText;
            LoadDanhMuc();
        }

 

     
        private void textBoxfind_TextChanged(object sender, EventArgs e)
        {   string keyword = textBoxfind.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword == "Nhập ID")
            {
                LoadDanhMuc();
                return;
            }

            // Câu lệnh SQL tìm kiếm theo ID hoặc tên hóa đơn
            string sql = @"
            SELECT 
                h.id AS idhd,
                b.tenban,
                h.tongtien,
                h.trangthai,
                h.ngaytao,
                h.tennguoidung,
                COUNT(ctd.idmonan) AS soLuongMonAn,
                STRING_AGG(dm.tenmonan, ', ') AS danhMucMonAn
            FROM 
                hoadon h
            JOIN 
                ban b ON h.idban = b.id
            JOIN 
                CTHoaDon ctd ON h.id = ctd.SoHD
            JOIN 
                danhmuc dm ON ctd.idmonan = dm.id
            WHERE 
                CAST(h.id AS NVARCHAR) LIKE @Keyword OR h.tennguoidung LIKE @Keyword
            GROUP BY 
                h.id, b.tenban, h.tongtien, h.trangthai, h.ngaytao, h.tennguoidung;";

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
                MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxfind_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxfind.Text))
            {
                textBoxfind.Text = "Nhập ID";
                textBoxfind.ForeColor = SystemColors.GrayText; // Màu văn bản mặc định
            }

        }

        private void textBoxfind_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxfind.Text == "Nhập ID")
            {
                textBoxfind.Text = "";
                textBoxfind.ForeColor = SystemColors.ControlText; // Màu văn bản khi có focus
            }
        }

        private void textBoxfind_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
