using Microsoft.Data.SqlClient;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaHang.JDBC
{
    internal class DataSql
    {
        SqlConnection connection;

        public void KetNoi()
        {
            if (connection == null)
            {
                connection = new SqlConnection("Data Source=HIEN\\SQLEXPRESS;Initial Catalog=QLNHAHANG7;User ID=sa;Password=123456789,Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            }
            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();
                Console.WriteLine("Kết nối thành công!");
            }
        }

        public void NgatKetNoi()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Đã ngắt kết nối");
            }
        }

        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return dt;
        }

        public DataTable LayDuLieu(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                KetNoi();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return dt;
        }

        public int CapNhatDuLieu(string sql)
        {
            int kq = -1;
            try
            {
                KetNoi();
                SqlCommand command = new SqlCommand(sql, connection);
                kq = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return kq;
        }

        public int CapNhatDuLieu(SqlCommand command)
        {
            int kq = -1;
            try
            {
                KetNoi();
                command.Connection = connection;
                kq = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return kq;
        }
        public async Task<int> CapNhatDuLieuAsync(string sql)
        {
            int kq = -1;
            try
            {
                KetNoi();
                using (var command = new SqlCommand(sql, connection))
                {
                    kq = await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return kq;
        }

        public async Task<int> CapNhatDuLieuAsync(SqlCommand command)
        {
            int kq = -1;
            try
            {
                KetNoi();
                command.Connection = connection;
                kq = await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return kq;
        }
        public List<string> GetDanhSachTenBan()
        {
            List<string> tenBanList = new List<string>();
            string sql = "SELECT tenban FROM ban WHERE trangthai = @trangthai";

            try
            {
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@trangthai", "Còn Sử Dụng");
                    DataTable dt = LayDuLieu(command);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string tenBan = row["tenban"].ToString();
                            tenBanList.Add(tenBan);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu phù hợp.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return tenBanList;
        }

        public DataTable GetDanhMucList()
        {
            string sql = "SELECT tenmonan, gia, hinhAnh FROM danhmuc";
            return LayDuLieu(sql);
        }
        public DataTable GetDanhMucListIDBan()
        {
            string sql = "SELECT idban FROM hoadon where trangthai = 'Chưa Thanh Toán'";
            return LayDuLieu(sql);
        }
        

        public DataTable getDataHoaDonTrangThai(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT danhmuc.tenmonan, CTHoaDon.soLuong, (CTHoaDon.soLuong * danhmuc.gia) as gia " +
                               "FROM hoadon " +
                               "JOIN CTHoaDon ON CTHoaDon.SoHD = hoadon.id " +
                               "JOIN danhmuc ON danhmuc.id = CTHoaDon.idmonan " +
                               "JOIN ban ON ban.id = hoadon.idban " +
                               "WHERE hoadon.trangthai = 'Chưa Thanh Toán' AND hoadon.id = @id";

                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Parameters.AddWithValue("@id", id);

                    dt = LayDuLieu(command);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            return dt;
        }
        public int GetIdHdByBan(int idBan)
        {
            int idban = -1;
            try
            {
                string sql = "SELECT hoadon.id FROM hoadon JOIN ban ON ban.id = hoadon.idban WHERE hoadon.trangthai = 'Chưa thanh toán' AND idban = @idban";
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@idban", idBan);
                    DataTable dt = LayDuLieu(command);

                    if (dt.Rows.Count > 0)
                    {
                        idban = Convert.ToInt32(dt.Rows[0]["id"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy ID bàn: " + ex.Message);
            }
            return idban;
        }
        public int GetIdHd(int idBan)
        {
            int idban = -1;
            try
            {
                string sql = "  select DISTINCT CTHoaDon.SoHD from hoadon join CTHoaDon on CTHoaDon.SoHD = hoadon.id where hoadon.id = @idban and trangthai = 'Chưa thanh toán'";
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@idban", idBan);
                    DataTable dt = LayDuLieu(command);

                    if (dt.Rows.Count > 0)
                    {
                        idban = Convert.ToInt32(dt.Rows[0]["SoHD"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy ID bàn: " + ex.Message);
            }
            return idban;
        }
        public int GetIdBanByName(string tenBan)
        {
            int idBan = -1;
            try
            {
                string sql = "SELECT id FROM ban WHERE tenban = @tenBan";
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@tenBan", tenBan);
                    DataTable dt = LayDuLieu(command);

                    if (dt.Rows.Count > 0)
                    {
                        idBan = Convert.ToInt32(dt.Rows[0]["id"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy ID bàn: " + ex.Message);
            }
            return idBan;
        }


        public bool XoaHoaDon(int idHD)
        {
            bool success = false;
            try
            {
                string sql = "DELETE FROM hoadon WHERE id = @id AND trangthai = 'Chưa Thanh Toán'";
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@id", idHD);
                    int rowsAffected = CapNhatDuLieu(command);
                    success = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa hóa đơn: " + ex.Message);
            }
            return success;
        }
        public async Task<bool> XoaChiTietHoaDonAsync(int idHD, int idMonAn)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE IdHoaDon = @IdHoaDon AND IdMonAn = @IdMonAn";

            try
            {
                
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdHoaDon", idHD);
                        command.Parameters.AddWithValue("@IdMonAn", idMonAn);

                    KetNoi();
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
            
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Lỗi khi xóa chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                NgatKetNoi();
            }
        }


        public async Task<int> ThemHoaDonAsync(int idban, string tennguoidung, decimal tongtien)
        {
            int idHD = -1;
            try
            {
                string sql = "INSERT INTO hoadon (idban, tennguoidung, tongtien) OUTPUT INSERTED.id VALUES (@idban, @tennguoidung, @tongtien)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@idban", idban);
                    command.Parameters.AddWithValue("@tennguoidung", tennguoidung);
                    command.Parameters.AddWithValue("@tongtien", tongtien);


                    KetNoi();
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    object result = await command.ExecuteScalarAsync();
                    if (result != null)
                    {
                        idHD = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm hóa đơn: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return idHD;
        }
        public int GetIdDanhMucByName(string tendanhmuc)
        {
            int idDanhMuc = -1;
            try
            {
                string sql = "SELECT id FROM danhmuc WHERE tenmonan = @tendanhmuc";
                using (SqlCommand command = new SqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@tendanhmuc", tendanhmuc);
                    DataTable dt = LayDuLieu(command);

                    if (dt.Rows.Count > 0)
                    {
                        idDanhMuc = Convert.ToInt32(dt.Rows[0]["id"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy ID danh mục: " + ex.Message);
            }
            return idDanhMuc;
        }
    

public async Task<bool> ThemCTHoaDonAsync(int soHD, int idmonan, int soLuong, decimal giaban)
        {
            bool success = false;
            try
            {
                Console.WriteLine($"Adding CTHoaDon: SoHD={soHD}, idmonan={idmonan}, soLuong={soLuong}, giaban={giaban}");

                string sql = "INSERT INTO CTHoaDon (SoHD, idmonan, soLuong, giaban) VALUES (@soHD, @idmonan, @soLuong, @giaban)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@soHD", soHD);
                    command.Parameters.AddWithValue("@idmonan", idmonan);
                    command.Parameters.AddWithValue("@soLuong", soLuong);
                    command.Parameters.AddWithValue("@giaban", giaban);

                    KetNoi();
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm chi tiết hóa đơn: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return success; 
        }
        public async Task<bool> CapNhatTrangThaiHoaDonAsync(int idHD, string trangThai)
        {
            bool success = false;
            try
            {
                string sql = "UPDATE hoadon SET trangthai = @trangThai WHERE id = @idHD ";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@idHD", idHD);
                    command.Parameters.AddWithValue("@trangThai", trangThai);
                    KetNoi();
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật trạng thái hóa đơn: " + ex.Message);
                return false;
            }

            finally
            {
                NgatKetNoi();
            }
            return success;
        }
        public async Task<bool> CapNhatHoaDonAsync(int idHD, decimal tongtien)
        {
            bool success = false;
            try
            {
                string sql = "UPDATE hoadon SET tongtien = @tongtien WHERE id = @idHD ";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@idHD", idHD);
                    command.Parameters.AddWithValue("@tongtien", tongtien);
                    KetNoi();
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật trạng thái hóa đơn: " + ex.Message);
                return false;
            }

            finally
            {
                NgatKetNoi();
            }
            return success;
        }
        public async Task<bool> CapNhatChiTietHoaDonAsync(int idCTHD, int idmonan, int soLuong, int idHD)
        {
            bool success = false;
            try
            {
                string sql = "UPDATE CTHoaDon SET soLuong = @soLuong " +
                             "WHERE STT = @idCTHD AND idmonan = @idmoan and SoHD = @idHD";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@soLuong", soLuong);
                    command.Parameters.AddWithValue("@idCTHD", idCTHD);
                    command.Parameters.AddWithValue("@idmoan", idmonan);
                    command.Parameters.AddWithValue("@idHD", idHD);


                    KetNoi();
                    if (connection.State != ConnectionState.Open)
                    {
                        await connection.OpenAsync();
                    }

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật chi tiết hóa đơn: " + ex.Message);
                return false;
            }
            finally
            {
                NgatKetNoi();
            }
            return success;
        }
        public List<int> GetIdsChiTietHoaDon(int idHoaDon, int idMonAn)
{
        List<int> ids = new List<int>();
    try
    {
        string sql = "SELECT CTHoaDon.STT FROM CTHoaDon WHERE SoHD = @idHoaDon AND idmonan = @idMonAn;";

        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
            command.Parameters.AddWithValue("@idMonAn", idMonAn);

            KetNoi();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ids.Add(reader.GetInt32(0));
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Lỗi lấy các ID chi tiết hóa đơn: " + ex.Message);
    }
    finally
    {
        NgatKetNoi();
    }
    return ids;
}

    }
}
