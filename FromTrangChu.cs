using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Globalization;

namespace QuanLyNhaHang
{
    public partial class FromTrangChu : Form
    {

        JDBC.DataSql data = new JDBC.DataSql();
        public FromTrangChu()
        {
            InitializeComponent();
        }

        private void FromTrangChu_Load(object sender, EventArgs e)
        {
            // Lấy tổng hóa đơn
            // Lấy tổng hóa đơn
            string sqlTongTien = "SELECT SUM(tongtien) AS TongTien FROM hoadon where trangthai = N'Đã Thanh Toán'";
            // Lấy số lượng hóa đơn
            string sqlSoHoaDon = "SELECT COUNT(*) AS SoHoaDon FROM hoadon where trangthai = N'Đã Thanh Toán'";

            try
            {
                // Thực thi câu lệnh SQL để lấy tổng hóa đơn
                DataTable dtTongTien = data.LayDuLieu(sqlTongTien);
                if (dtTongTien.Rows.Count > 0)
                {
                    decimal tongTien = dtTongTien.Rows[0]["TongTien"] != DBNull.Value
                        ? Convert.ToDecimal(dtTongTien.Rows[0]["TongTien"])
                        : 0;

                    // Định dạng tiền tệ và gán vào lbtien
                    lbtien.Text = tongTien.ToString("N0", new CultureInfo("vi-VN"));

                }

                // Thực thi câu lệnh SQL để lấy số lượng hóa đơn
                DataTable dtSoHoaDon = data.LayDuLieu(sqlSoHoaDon);
                if (dtSoHoaDon.Rows.Count > 0)
                {
                    int soHoaDon = dtSoHoaDon.Rows[0]["SoHoaDon"] != DBNull.Value
                        ? Convert.ToInt32(dtSoHoaDon.Rows[0]["SoHoaDon"])
                        : 0;

                    // Gán số lượng hóa đơn vào lbhoadon
                    lbhoadon.Text = soHoaDon.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker3.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            string sqlTongTien = "SELECT SUM(tongtien) AS TongTien FROM hoadon WHERE MONTH(ngaytao) = @Month AND YEAR(ngaytao) = @Year AND trangthai = N'Đã Thanh Toán'";
            string sqlSoHoaDon = "SELECT COUNT(*) AS SoHoaDon FROM hoadon WHERE MONTH(ngaytao) = @Month AND YEAR(ngaytao) = @Year AND trangthai = N'Đã Thanh Toán'";

            try
            {
                // Lấy tổng tiền hóa đơn
                using (SqlCommand command = new SqlCommand(sqlTongTien))
                {
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", year);

                    DataTable dtTongTien = data.LayDuLieu(command);
                    if (dtTongTien.Rows.Count > 0)
                    {
                        decimal tongTien = dtTongTien.Rows[0]["TongTien"] != DBNull.Value
                            ? Convert.ToDecimal(dtTongTien.Rows[0]["TongTien"])
                            : 0;

                        // Định dạng số tiền và gán vào lbtien
                        lbtien.Text = tongTien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                    }
                }

                // Lấy số lượng hóa đơn
                using (SqlCommand command = new SqlCommand(sqlSoHoaDon))
                {
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", year);

                    DataTable dtSoHoaDon = data.LayDuLieu(command);
                    if (dtSoHoaDon.Rows.Count > 0)
                    {
                        int soHoaDon = dtSoHoaDon.Rows[0]["SoHoaDon"] != DBNull.Value
                            ? Convert.ToInt32(dtSoHoaDon.Rows[0]["SoHoaDon"])
                            : 0;

                        // Gán số lượng hóa đơn vào lbhoadon
                        lbhoadon.Text = soHoaDon.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy tổng tiền và số lượng hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

