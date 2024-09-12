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
    public partial class FromSuaXoaBan : Form
    {
        private int _idBan;
        private string _tenBan;
        private string _moTa;
        private string _trangThai;
        private DateTime _ngayTao;
        private FromBan _FromBan;
        public FromSuaXoaBan(FromBan _FromBan,int idBan, string tenBan, string moTa, string trangThai)
        {
            InitializeComponent();
            this._FromBan = _FromBan;
            _idBan = idBan;
            _tenBan = tenBan;
            _moTa = moTa;
            _trangThai = trangThai;
        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void button1_Click(object sender, EventArgs e)
        {
            string tenBan = textBox1.Text.Trim();
            string moTa = textBox2.Text.Trim();
            string trangThai = comboBox1.SelectedItem.ToString();
            DateTime ngayTao = DateTime.Now;

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(tenBan) || tenBan == "Tên Bàn" ||
                string.IsNullOrEmpty(moTa) || moTa == "Mô tả")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Câu lệnh SQL với tham số
            string sql = "UPDATE ban SET tenban = @TenBan, mota = @MoTa, trangthai = @TrangThai, ngaytao = @NgayTao WHERE id = @IdBan";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@TenBan", tenBan);
                command.Parameters.AddWithValue("@MoTa", moTa);
                command.Parameters.AddWithValue("@TrangThai", trangThai);
                command.Parameters.AddWithValue("@NgayTao", ngayTao);
                command.Parameters.AddWithValue("@IdBan", _idBan);

                // Cập nhật cơ sở dữ liệu
                int result = data.CapNhatDuLieu(command);

                if (result > 0)
                {
                    MessageBox.Show("Bàn đã được cập nhật thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FromBan.resetdata();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Câu lệnh SQL để xóa bàn
                string sql = "DELETE FROM ban WHERE id = @IdBan";

                try
                {
                    // Tạo đối tượng SqlCommand và thêm tham số
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@IdBan", _idBan);

                    // Xóa bàn từ cơ sở dữ liệu
                    int result = data.CapNhatDuLieu(command);

                    if (result > 0)
                    {
                        MessageBox.Show("Bàn đã được xóa thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FromBan.resetdata();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Mô tả")
            {
                textBox2.Text = "";

            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Tên Bàn")
            {
                textBox1.Text = "";

            }
        }

        private void FromSuaXoaBan_Load(object sender, EventArgs e)
        {
            textBox1.Text = _tenBan;
            textBox2.Text = _moTa;
            comboBox1.Text = _trangThai;
        }
    }
}
