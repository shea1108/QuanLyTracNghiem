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
using WindowsFormsApp_Login.Admin.View;
using WindowsFormsApp_Login.User.View;

namespace WindowsFormsApp_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void quenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ComfirmPass comfirmPass = new ComfirmPass();
            comfirmPass.ShowDialog();
            this.Close();
        }

        private void dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close ();
            
        }
        Modify modify = new Modify();

        private void dangNhap_btn_Click(object sender, EventArgs e)
        {
            string chucvu = chucvuBox.SelectedItem.ToString();
            string tk = taikhoantxt.Text;
            string pass = passTxt.Text;
            if (tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tên tài khoản !");
                return;
            }
            
                
            else if (pass.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin mật khẩu !");
                return;
            }
            

            else
            {
                if (chucvu == "Admin")
                {
                    string querry = "SELECT * FROM Admin WHERE username = '" + tk + "' AND password = '" + pass + "'";
                    if (modify.TaiKhoans(querry).Count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công !");
                        
                        this.Hide();
                        HomeAdmin homeAdmin = new HomeAdmin();
                        homeAdmin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
                    }
                }
                else
                {
                    string querry = "SELECT * FROM Users WHERE username = '" + tk + "' AND password = '" + pass + "'";
                    if (modify.TaiKhoans(querry).Count > 0)
                    {
                        List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
                        taiKhoans = modify.TaiKhoans(querry);
                        MessageBox.Show("Đăng nhập thành công !");

                        this.Hide();
                        HomeUser user = new HomeUser(taiKhoans[0].Id);
                        user.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
                    }
                }
            }
        }
        private void backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
