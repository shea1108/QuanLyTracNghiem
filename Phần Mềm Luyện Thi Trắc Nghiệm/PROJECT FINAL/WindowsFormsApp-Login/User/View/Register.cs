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
using System.Text.RegularExpressions;

namespace WindowsFormsApp_Login.User.View
{
    public partial class Register : Form
    {
        Modify modify = new Modify();
        public Register()
        {
            InitializeComponent();
        }
        private void backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void dangKy_btn_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            string tk = txttaikhoan.Text;
            string mk = txtmatkhau.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;

            // Kiểm tra hợp lệ của email
            

            // Kiểm tra các trường thông tin bắt buộc
            if (hoten.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên!");
                return;
            }
            if (tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (modify.ContainsAccentedCharacters(tk))
            {
                MessageBox.Show("Tên tài khoản không được chứa kí tự có dấu !");
                return;
            }
            if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            if (modify.ContainsAccentedCharacters(mk))
            {
                MessageBox.Show("Mật khẩu không được chứa kí tự có dấu !");
                return;
            }
            
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
                return;
            }
            if (!modify.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            
            if (sdt.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                return;
            }
            // Kiểm tra hợp lệ của số điện thoại
            if (!modify.IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }
            if (modify.TaiKhoans("Select * FROM Users WHERE username = '" + tk + "'").Count != 0)
            {
                MessageBox.Show("Tài khoản này đã được đăng kí");
                return;
            }

            if (modify.TaiKhoans("Select * FROM Users WHERE email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí");
                return;
            }


            try
            {
                string querry = "Insert into Users values (N'" + tk + "',N'" + mk + "',N'" + hoten + "',N'" + email + "',N'" + sdt + "')";
                modify.Command(querry);
                if (MessageBox.Show("Bạn đã đăng ký thành công! Bạn có muốn đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
            }
        }

        

    }
}
