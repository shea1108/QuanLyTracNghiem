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
    public partial class ComfirmPass : Form
    {
        Modify modify = new Modify();   
        public ComfirmPass()
        {
            InitializeComponent();
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void xacNhan_btn_Click(object sender, EventArgs e)
        {
            int id = modify.CheckTK(txt_tk.Text, txt_sdt.Text);
            if (id != 0)
            {
                MessageBox.Show("Xác nhận thông tin tài khoản thành công !");
                this.Hide();
                CapNhatMK lostP = new CapNhatMK(id);
                lostP.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không chính xác !");
            }
        }
    }
}
