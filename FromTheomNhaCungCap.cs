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
    public partial class FromTheomNha_CungCap : Form
    {
        private FromNhaCungCap _FromNhaCungCap;
        JDBC.DataSql data = new JDBC.DataSql();
        public FromTheomNha_CungCap(FromNhaCungCap _FromNhaCungCap)
        {
            InitializeComponent();
            this._FromNhaCungCap = _FromNhaCungCap;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FromTheomNha_CungCap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string phone = textBox4.Text.Trim();
            string diachi = textBox3.Text.Trim();

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL để thêm nhà cung cấp
            string sql = "INSERT INTO nhacungcap (ten, email, phone, diachi) VALUES (@Ten, @Email, @Phone, @DiaChi)";

            try
            {
                // Tạo đối tượng SqlCommand và thêm tham số
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@Ten", ten);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@DiaChi", diachi);

                // Thực thi câu lệnh SQL
                data.CapNhatDuLieu(command);

                // Hiển thị thông báo thành công và làm mới dữ liệu trên form
                MessageBox.Show("Nhà cung cấp đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                _FromNhaCungCap.load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
