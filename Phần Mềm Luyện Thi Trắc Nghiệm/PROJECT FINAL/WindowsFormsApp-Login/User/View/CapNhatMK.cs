using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Login.User.View
{
    public partial class CapNhatMK : Form
    {
        Modify modify = new Modify();
        int idUser;
        public CapNhatMK(int id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void capNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(new_pass.Text) && !string.IsNullOrEmpty(new_passAg.Text))
            {
                if (new_pass.Text.Equals(new_passAg.Text))
                {
                    Modify.UpdatePassword(new_pass.Text, idUser);
                    MessageBox.Show("Cập nhật mật khẩu thành công !");
                    this.Hide();
                    Login log = new Login();
                    log.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin mật khẩu không trùng khớp !");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô !");
            }
        }
    }
}
