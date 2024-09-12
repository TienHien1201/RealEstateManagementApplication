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
    public partial class UserMonAn : UserControl
    {
        public UserMonAn()
        {
            InitializeComponent();
            RegisterMouseClickEvents(this);
        }
        public void RegisterMouseClickEvents(Control control)
        {
            control.MouseClick += UserMonAn_MouseClick_1;
            foreach (Control child in control.Controls)
            {
                RegisterMouseClickEvents(child);
            }
        }
        private void UserMonAn_MouseClick_1(object sender, MouseEventArgs e)
        {

            this.OnClick(e);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {


        }

        public string Title
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public string Const
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        public Image icon
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

    }
}
