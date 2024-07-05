using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.User.View
{  
    public partial class ChangePassword : Form
    {
        private int id_User;
        Modify modify = new Modify();
        public ChangePassword(int id_User)
        {
            InitializeComponent();
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string querry = "SELECT * FROM Users WHERE Id_User = '" + id_User + "'";
            taiKhoans = modify.TaiKhoans(querry);
            FullName.Text = taiKhoans[0].Fullname;
            this.id_User = id_User;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(FullName, -1 / 2 * FullName.Width, FullName.Height);
        }


        private void trangChu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InforUser inforUser = new InforUser(id_User);
            inforUser.ShowDialog();
            this.Close();
        }
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(id_User);
            changePassword.ShowDialog();
            this.Close();
        }

        private void ketQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_User);
            ketQua.ShowDialog();
            this.Close();
        }



        private void vaoThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_User);
            chooseExam.ShowDialog();
            this.Close();
        }


        private bool VerifyOldPassword(int id_User, string oldPassword)
        {     
            ExamModify examModify = new ExamModify();   
            List<TaiKhoan> users = examModify.GetInforUsers(id_User);

            if (users.Count > 0)
            {           
                string currentPassword = users[0].MatKhau;
                return currentPassword == oldPassword;
            }
            else
            {  
                return false;
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string oldPassword = textBox1.Text;
            string newPassword = textBox2.Text;
            string confirmNewPassword = textBox3.Text;

            // Kiểm tra các trường thông tin nếu bị bỏ trống
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            

            bool isOldPasswordCorrect = VerifyOldPassword(id_User, oldPassword);
            if (!isOldPasswordCorrect)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                return;
            }

            if (newPassword == oldPassword)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!");
                return;
            }
            if (modify.ContainsAccentedCharacters(newPassword))
            {
                MessageBox.Show("Mật khẩu không được chứa kí tự có dấu !");
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thay đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ExamModify examModify = new ExamModify();
                bool success = examModify.ChangePassword(id_User, newPassword);

                if (success)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_User);
            chooseExam.ShowDialog();
            this.Close();
        }
        
    }
}
