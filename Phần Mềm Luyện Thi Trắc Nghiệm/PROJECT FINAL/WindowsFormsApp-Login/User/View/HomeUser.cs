using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;

namespace WindowsFormsApp_Login.User.View
{
    public partial class HomeUser : Form
    {
        Modify modify = new Modify();
        int id_user;
        public HomeUser(int id)
        {
            InitializeComponent();
            id_user = id;
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string querry = "SELECT * FROM Users WHERE Id_User = '" + id + "'";
            taiKhoans = modify.TaiKhoans(querry);
            FullName.Text = taiKhoans[0].Fullname;
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(FullName,- 1/2*FullName.Width , FullName.Height);
            
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InforUser inforUser = new InforUser(id_user);
            inforUser.ShowDialog();
            this.Close();
        }
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(id_user);
            changePassword.ShowDialog();
            this.Close();
        }

        private void trangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_user);
            homeUser.ShowDialog();
            this.Close();
        }

        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
            this.Close();
        }

        private void vaoThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
            this.Close(); 

        }

        private void ketQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_user);
            ketQua.ShowDialog();
            this.Close();
        }

    }
}
