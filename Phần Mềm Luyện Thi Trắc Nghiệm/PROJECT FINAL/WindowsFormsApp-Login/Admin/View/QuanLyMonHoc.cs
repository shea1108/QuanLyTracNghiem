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

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class QuanLyMonHoc : UserControl
    {
        ExamModify examModify = new ExamModify();
        List<Subject> subject = new List<Subject>();
        public QuanLyMonHoc()
        {
            InitializeComponent();
            subject = examModify.GetSubject("SELECT * FROM list_subject ");
            ShowData();
        }

        public void ShowData()
        {
            subject = examModify.GetSubject("SELECT * FROM list_subject ");

            listSj_table.Rows.Clear();
            listSj_table.Refresh();
            for(int i = 0; i < subject.Count; i++) 
            {
                listSj_table.Rows.Add(
                    subject[i].Id,
                    i + 1,
                subject[i].NameExam
            ); 
            }
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            string monHoc = "";
            DialogResult result = InputBox("Nhập tên môn học", "Nhập thông tin", ref monHoc);

            if (result == DialogResult.OK && !string.IsNullOrEmpty(monHoc))
            {
                ExamModify.InsertSubject(monHoc);
                MessageBox.Show($"Đã thêm môn học mới : {monHoc}");
                listSj_table.Rows.Clear();
                ShowData();
                listSj_table.Refresh();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên môn học.");
            }
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            int examIdToDelete = GetSelectedSubjectId();
            

            if (examIdToDelete != -1)
            {
                DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    MessageBox.Show("Đã xóa môn thi thành công !");
                    ExamModify.DeleteSubject(examIdToDelete);

                    listSj_table.Rows.Clear();
                    ShowData();
                    listSj_table.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn kỳ thi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetSelectedSubjectId()
        {
            if (listSj_table.SelectedRows.Count >0)
            { int selectedRow = listSj_table.SelectedRows[0].Index;
            
                return Convert.ToInt32(listSj_table.Rows[selectedRow].Cells[0].Value);
            }
            else
            {
                
                return -1;
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

    }
}
