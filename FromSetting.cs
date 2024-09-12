    using Microsoft.Data.SqlClient;
    using QuanLyNhaHang.JDBC;
    using System.Data;
    using System.Diagnostics;
    using System.Globalization;
    using static QuanLyNhaHang.FromDangNhap;
    using static System.Runtime.InteropServices.JavaScript.JSType;

        namespace QuanLyNhaHang
        {
        public partial class FromSetting : Form
        {

            private List<DataGridViewRow> tempRows = new List<DataGridViewRow>();
            private JDBC.DataSql data = new JDBC.DataSql();
            private UserMonAn userMonAn = new UserMonAn();
            private static bool kt = false;
        private string username;
        private string tenNguoiDung;

        public FromSetting(string name)
        {
            InitializeComponent();
           this.username = name;
        }


        public string BanName { get; set; }

            private void FromSetting_Load(object sender, EventArgs e)
            {
                
                LoadDanhMuc();
                lbTenBan.Text = BanName;
                RefreshDataGridView();

            }
            void addMonAn(string title, string price, Image image)
            {

                UserMonAn userMonAn = new UserMonAn()
                {
                    Title = title,
                    Const = price.Trim(),
                    icon = image
                };

                userMonAn.MouseClick += UserMonAn_UserMonAnClicked;
                RegisterMouseClickEvents(userMonAn);
                flowLayoutPanel1.Controls.Add(userMonAn);
            }

            private void RegisterMouseClickEvents(Control control)
            {
                control.MouseClick += UserMonAn_UserMonAnClicked;
                foreach (Control child in control.Controls)
                {
                    RegisterMouseClickEvents(child);
                }
            }
            private void UserMonAn_UserMonAnClicked(object sender, MouseEventArgs e)
            {

                UserMonAn clickedItem = GetUserMonAn(sender as Control);
                if (clickedItem != null)
                {
                    HandleMonAnClick(clickedItem.Title, clickedItem.Const);
                }

            }

            private UserMonAn GetUserMonAn(Control control)
            {
                while (control != null && !(control is UserMonAn))
                {
                    control = control.Parent;
                }
                return control as UserMonAn;
            }
            private void HandleMonAnClick(string title, string price)
            {

            try
            {
                DataTable dt = dataGridView1.DataSource as DataTable;

                if (dt != null)
                {
                    bool found = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["tenmonan"].ToString() == title)
                        {
                            int currentCount = int.Parse(row["soLuong"].ToString());
                            currentCount++;
                            row["soLuong"] = currentCount.ToString();

                            // Loại bỏ dấu phẩy và chuyển đổi giá thành số thập phân
                            decimal unitPrice;
                            if (decimal.TryParse(price.Replace(",", ""), out unitPrice))
                            {
                                decimal totalPrice = currentCount * unitPrice;
                                row["gia"] = totalPrice.ToString("0.##");
                            }
                            else
                            {
                                MessageBox.Show("Giá trị không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        // Thêm hàng mới với giá tiền ban đầu
                        decimal unitPrice;
                        if (decimal.TryParse(price.Replace(",", ""), out unitPrice))
                        {
                            DataRow newRow = dt.NewRow();
                            newRow["tenmonan"] = title;
                            newRow["soLuong"] = "1";
                            newRow["gia"] = unitPrice.ToString("0.##");
                            dt.Rows.Add(newRow);
                        }
                        else
                        {
                            MessageBox.Show("Giá trị không hợp lệ khi thêm món mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Cập nhật tổng giá tiền
                    UpdateTotalPriceLabel();
                }
                else
                {
                    MessageBox.Show("DataGridView không có nguồn dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hàng vào DataGridView: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // chuyển danh muc món ăn qua bên hóa đơn
        private void LoadDanhMuc()
            {
                try
                {
                    DataTable dt = data.GetDanhMucList();

                    foreach (DataRow row in dt.Rows)
                    {
                        string tenDanhMuc = row["tenmonan"].ToString();
                        string moTa = row["gia"].ToString();
                        byte[] hinhAnhBytes = row["hinhAnh"] as byte[];

                        // Chuyển đổi byte[] thành Image
                        Image hinhAnh = null;
                        if (hinhAnhBytes != null)
                        {
                            using (var ms = new MemoryStream(hinhAnhBytes))
                            {
                                hinhAnh = Image.FromStream(ms);
                            }
                        }

                        addMonAn(tenDanhMuc, moTa, hinhAnh);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //cập nhật giá tiền

            private void UpdateTotalPriceLabel()
            {
                decimal totalPrice = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["gia"].Value != null)
                    {
                        decimal rowPrice;
                        if (decimal.TryParse(row.Cells["gia"].Value.ToString().Replace(",", ""), out rowPrice))
                        {
                            totalPrice += rowPrice;
                        }
                    }
                }

                label2.Text = totalPrice.ToString("N0");
            }


            private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
            {

            }
            // load dữ liệu chưa thanh toán lên datagripview
            private void UpdateCurrentBill()
            {
                try
                {
                    int idBan = data.GetIdBanByName(BanName);
                    if (idBan == -1)
                    {
                        MessageBox.Show("Tên bàn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int idHD = data.GetIdHdByBan(idBan);
                    DataTable dt = data.getDataHoaDonTrangThai(idHD);

                    if (dt != null)
                    {
                        // Đảm bảo rằng DataGridView được liên kết với DataTable
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        dataGridView1.DataSource = null;

                    }

                    // Cập nhật tổng giá tiền
                    UpdateTotalPriceLabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            private void label3_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private async void button2_Click(object sender, EventArgs e)
            {

            try
            {
                // Kiểm tra xem DataGridView có chứa dữ liệu không
                bool hasItems = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        hasItems = true;
                        break;
                    }
                }

                if (!hasItems)
                {
                    MessageBox.Show("Vui lòng chọn món ăn để thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenBan = lbTenBan.Text;
                int idBan = data.GetIdBanByName(tenBan);
                if (idBan == -1)
                {
                    MessageBox.Show("Tên bàn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tenNguoiDung1 = username;
                string formattedPrice = label2.Text;
                string cleanedPrice = formattedPrice.Replace(",", "");
                decimal tongTien;
                if (!decimal.TryParse(cleanedPrice, NumberStyles.Number, CultureInfo.InvariantCulture, out tongTien))
                {
                    MessageBox.Show("Không thể chuyển đổi giá trị thành decimal.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idHD = data.GetIdHdByBan(idBan); // Lấy id hóa đơn chưa thanh toán nếu có

                if (idHD == -1)
                {
                    // Nếu không có hóa đơn chưa thanh toán, tạo hóa đơn mới
                    idHD = await data.ThemHoaDonAsync(idBan, tenNguoiDung1, tongTien);
                }
                else
                {
                    // Nếu có hóa đơn chưa thanh toán, cập nhật hóa đơn hiện tại
                    bool updateSuccess = await data.CapNhatHoaDonAsync(idHD, tongTien);
                    if (!updateSuccess)
                    {
                        MessageBox.Show("Lỗi khi cập nhật hóa đơn. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Xử lý chi tiết hóa đơn
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        string tenDanhMuc = row.Cells[0].Value.ToString();
                        int soLuong;
                        decimal giaBan;

                        if (int.TryParse(row.Cells[1].Value.ToString(), out soLuong) &&
                            decimal.TryParse(row.Cells[2].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out giaBan))
                        {
                            int idMonAn = data.GetIdDanhMucByName(tenDanhMuc);
                            List<int> existingCTHDIds = data.GetIdsChiTietHoaDon(idHD, idMonAn);

                            if (existingCTHDIds.Count > 0)
                            {
                                // Cập nhật chi tiết hóa đơn hiện tại
                                foreach (int idCTHD in existingCTHDIds)
                                {
                                    bool updateCTHD = await data.CapNhatChiTietHoaDonAsync(idCTHD, idMonAn, soLuong, idHD);
                                    if (!updateCTHD)
                                    {
                                        MessageBox.Show($"Lỗi cập nhật chi tiết hóa đơn cho món: {idMonAn} : {updateCTHD} : {idCTHD}:{soLuong} : {idHD}" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                // Thêm chi tiết hóa đơn mới
                                bool success = await data.ThemCTHoaDonAsync(idHD, idMonAn, soLuong, giaBan);
                                if (!success)
                                {
                                    MessageBox.Show($"Lỗi thêm chi tiết hóa đơn cho món: {tenDanhMuc}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }

                if (idHD > 0)
                {
                    MessageBox.Show("Hóa đơn đã được cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo hóa đơn. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm/cập nhật hóa đơn: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {

            string tenBan = lbTenBan.Text;
            int idBan = data.GetIdBanByName(tenBan);
            int idHD = data.GetIdHdByBan(idBan);
            //string sql = data.CapNhatDuLieu("");
            if (dataGridView1.CurrentCell != null)
            {
                // Lấy hàng chứa ô hiện tại
                DataGridViewRow selectedRow = dataGridView1.CurrentCell.OwningRow;

                if (selectedRow != null)
                {
                    dataGridView1.Rows.Remove(selectedRow);
                    UpdateTotalPriceLabel();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                        {
                            string tenDanhMuc = row.Cells[0].Value.ToString();
                           

                                int idMonAn = data.GetIdDanhMucByName(tenDanhMuc);
                                List<int> existingCTHDIds = data.GetIdsChiTietHoaDon(idHD, idMonAn);

                                if (existingCTHDIds.Count > 0)
                                {
                                    // Cập nhật chi tiết hóa đơn hiện tại
                                    foreach (int idCTHD in existingCTHDIds)
                                    {
                                        
                                    }
                                }
                               
                            }
                        }
                    }

                }
            
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ô để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public event EventHandler ThanhToanThanhCong;
        private async void button1_Click(object sender, EventArgs e)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong bảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                try
                {
                    int idban = data.GetIdBanByName(lbTenBan.Text);
                    if (idban == -1)
                    {
                        MessageBox.Show("Tên bàn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int id = data.GetIdHdByBan(idban);
                    if (id == -1)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cho bàn này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool success = await data.CapNhatTrangThaiHoaDonAsync(id, "Đã Thanh Toán");
                    int idHD = data.GetIdHdByBan(id);
                    if (success)
                    {
                        
                        MessageBox.Show("Thanh toán thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThanhToanThanhCong?.Invoke(this, EventArgs.Empty);
                         this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi cập nhật trạng thái hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private void RefreshDataGridView()
            {
              dataGridView1.DataSource = null; // Xóa nguồn dữ liệu cũ
              UpdateCurrentBill();
        }
            private void FromSetting_Shown(object sender, EventArgs e)
            {
                RefreshDataGridView();
            }

            private void FromSetting_FormClosed(object sender, FormClosedEventArgs e)
            {

                RefreshDataGridView();                
            }
        }
    }
