namespace QuanLyNhaHang
{
    public partial class FormNhaHang : Form
    {
        private string username;

        public FormNhaHang(string username)
        {
            InitializeComponent();
            this.username = username;
            this.IsMdiContainer = true;
        }
        public FormNhaHang()
        {
            InitializeComponent();
            this.username = username;
            this.IsMdiContainer = true;
        }

        private void MoFormCon(Form form)
        {
            panel3.Controls.Clear(); // Xóa các form con trước đó trong panel3
            form.TopLevel = false; // Không đặt Form là top-level
            form.FormBorderStyle = FormBorderStyle.None; // Loại bỏ đường viền của Form con
            form.Dock = DockStyle.Fill; // Form con sẽ chiếm toàn bộ vùng của Panel
            panel3.Controls.Add(form); // Thêm Form vào Panel
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            FromTrangChu trangChuForm = new FromTrangChu();
            MoFormCon(trangChuForm);
        }

        private void timerday_Tick(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

        }

        private void FormNhaHang_Load(object sender, EventArgs e)
        {
            FromTrangChu trangChuForm = new FromTrangChu();
            MoFormCon(trangChuForm);
            timerday.Tick += timerday_Tick;
            timerday.Interval = 1000;
            timerday.Start();

            timerTime.Tick += timerTime_Tick;
            timerTime.Interval = 1000;
            timerTime.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MoFormCon(new FromDanhMuc());
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            FromHD fromHD = new FromHD(this.username);
            MoFormCon(fromHD);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            MoFormCon(new FromBan());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            MoFormCon(new FromNhaCungCap());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            MoFormCon(new FromHoaDon());

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            MoFormCon(new FromNguyenLieu());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            MoFormCon(new FromQuyen());


        }

    

        private void FormNhaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //    Application.Exit();
        }

       
    }
}
