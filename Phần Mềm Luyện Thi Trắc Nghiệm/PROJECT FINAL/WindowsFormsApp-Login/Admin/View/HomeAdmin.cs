using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
            QuanLyDeThi quanLyDeThi = new QuanLyDeThi();
            add_UC(quanLyDeThi);
        }
        private void add_UC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void dangXuat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void butQuanLyDeThi_Click(object sender, EventArgs e)
        {
            QuanLyDeThi quanLyDeThi = new QuanLyDeThi();
            add_UC(quanLyDeThi);
        }

        private void butQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung quanLyNguoiDung = new QuanLyNguoiDung();
            add_UC(quanLyNguoiDung);
        }

        private void butQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc quanLyMonHoc = new QuanLyMonHoc();
            add_UC(quanLyMonHoc);
        }
    }
}
