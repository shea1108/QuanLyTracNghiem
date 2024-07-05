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
using WindowsFormsApp_Login.User.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class QuanLyNguoiDung : UserControl
    {
        Modify modify = new Modify();
        List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
        string querry = "SELECT * FROM Users";
        int id;
        public QuanLyNguoiDung()
        {
            InitializeComponent();
            ShowData(querry);
        }

        public void ShowData(string querry)
        {
            taiKhoans = modify.TaiKhoans(querry);
            

            if(taiKhoans.Count > 0 )
            {
                listUser.Rows.Clear();
                listUser.Refresh();
                for (int i = 0; i < taiKhoans.Count; i++)
                {
                    listUser.Rows.Add(
                        taiKhoans[i].Id,
                        i + 1,
                        taiKhoans[i].TenTk,
                        taiKhoans[i].Fullname,
                        taiKhoans[i].Email,
                        taiKhoans[i].Phone_number
                    );
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin người dùng trùng khớp !");
                return;
            }
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text) || string.IsNullOrWhiteSpace(fullNameTxt.Text) || string.IsNullOrWhiteSpace(emailTxt.Text) || string.IsNullOrWhiteSpace(phoneNumberTxt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (!modify.IsValidEmail(emailTxt.Text))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }
            if(!modify.IsValidPhoneNumber(phoneNumberTxt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }    
            if(modify.ContainsAccentedCharacters(usernameTxt.Text))
            {
                MessageBox.Show("Tên tài khoản không được chứa kí tự có dấu !");
                return;
            }    

            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin người dùng này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                string username = usernameTxt.Text;
                string fullName = fullNameTxt.Text;
                string email = emailTxt.Text;
                string phoneNumber = phoneNumberTxt.Text;

                ExamModify examModify = new ExamModify();
                examModify.UpdateUserInfo(id, username, fullName, email, phoneNumber);
                MessageBox.Show("Đã cập nhật thông tin người dùng thành công !");

                listUser.Rows.Clear();
                ShowData(querry);
                listUser.Refresh();
            }

        }
        private void tim_kiemBtn_Click(object sender, EventArgs e)
        {
            string keyword = ""; 
            DialogResult result = InputBox("Tìm kiếm", "Nhập tên tài khoản cần tìm kiếm:", ref keyword);

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.ToLower();
                string querySelect = "SELECT * FROM Users WHERE username LIKE N'%" + keyword + "%'";

                ShowData(querySelect);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int rowIndex = listUser.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    DataGridViewRow row = listUser.Rows[rowIndex];

                    int selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                    id = selectedId;
                    

                    string querySelect = "SELECT * FROM Users WHERE Id_User = " + selectedId;


                    Modify modify = new Modify();
                    List<TaiKhoan> selectedUserData = modify.TaiKhoans(querySelect);

                   
                    if (selectedUserData.Count > 0)
                        
                    { 
                        usernameTxt.Text = selectedUserData[0].TenTk;
                        fullNameTxt.Text = selectedUserData[0].Fullname;
                        emailTxt.Text = selectedUserData[0].Email;
                        phoneNumberTxt.Text = selectedUserData[0].Phone_number;
                        
                    }
                }
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            ShowData(querry);
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {           
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn một người dùng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {               
                ExamModify examModify = new ExamModify();
                examModify.DeleteUser(id);              
                MessageBox.Show("Đã xóa người dùng thành công !");               
                listUser.Rows.Clear();
                ShowData(querry);
                listUser.Refresh();
                usernameTxt.Text = "";
                phoneNumberTxt.Text = "";
                fullNameTxt.Text = "";
                emailTxt.Text = "";
                id = 0;
            }

        }
    }
}
