using Microsoft.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaHang
{
    public partial class FromThemBan : Form
    {
        private FromBan FromBan1;
        public FromThemBan(FromBan FromBan1)
        {
            InitializeComponent();

            this.FromBan1 = FromBan1;

        }
        JDBC.DataSql data = new JDBC.DataSql();
        private void button1_Click(object sender, EventArgs e)
        {
            string tenBan = textBox1.Text.Trim();
            string moTa = textBox2.Text.Trim();


            if (string.IsNullOrEmpty(tenBan) || string.IsNullOrEmpty(moTa) || textBox2.Text == "Mô tả" || textBox1.Text == "Tên Bàn" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string trangThai = comboBox1.SelectedItem.ToString();
                string sql = "INSERT INTO ban (tenban, mota, trangthai, ngaytao) VALUES (@tenban, @mota, @trangthai, GETDATE())";
                try
                {

                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@tenban", tenBan);
                    command.Parameters.AddWithValue("@mota", moTa);
                    command.Parameters.AddWithValue("@trangthai", trangThai);

                    int result = data.CapNhatDuLieu(command);
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm bàn thành công!");
                        FromBan1.resetdata();
                        textBox2.Text = "Mô tả";
                        textBox1.Text = "Tên Bàn";
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
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

        private void FromThemBan_Load(object sender, EventArgs e)
        {

        }
    }
}
