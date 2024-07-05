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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace WindowsFormsApp_Login.User.View
{
    public partial class KetQua : Form
    {
        private int id_User;
        private ExamModify examModify;
        Modify modify = new Modify();
        public KetQua(int id_User)
        {
            InitializeComponent();
            this.id_User = id_User;
            this.examModify = new ExamModify();
            DisplayHistoryTests();

            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string querry = "SELECT * FROM Users WHERE Id_User = '" + id_User + "'";
            taiKhoans = modify.TaiKhoans(querry);
            FullName.Text = taiKhoans[0].Fullname;

        }
        private void DisplayHistoryTests()
        {

            List<History> historyTests = examModify.GetHistoryTests(id_User);
            if (historyTests.Count > 0)
            {
                KetQuaTable.Rows.Clear();

                // Duyệt qua từng kết quả và thêm vào DataGridView
                for (int i = 0; i < historyTests.Count; i++)
                {
                    History historyTest = historyTests[i];
                    string[] row = new string[]
                    {
                (i + 1).ToString(),
                historyTest.Id.ToString(),
                historyTest.Id_user.ToString(),
                historyTest.Id_exam.ToString(),
                historyTest.NameExam,
                historyTest.NumberExam.ToString(),
                historyTest.TotalPoint.ToString(),
                historyTest.Time_Completed.ToString(),
                historyTest.Date_Time.ToString(),
                historyTest.Result
                    };


                    KetQuaTable.Rows.Add(row);
                }
            }

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

        private void KetQua_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = examModify.GetSubjectNames();
            foreach (Subject subject in subjects)
            {
                MonHocOption.Items.Add(subject.NameExam);
            }

        }

        private void DisplayHistoryTests(List<History> historyTests)
        {
            KetQuaTable.Rows.Clear();
            if (historyTests.Count > 0)
            {
                // Duyệt qua từng kết quả và thêm vào DataGridView
                for (int i = 0; i < historyTests.Count; i++)
                {
                    History historyTest = historyTests[i];
                    string[] row = new string[]
                    {
                (i + 1).ToString(), // Thêm STT vào hàng
                historyTest.Id.ToString(),
                historyTest.Id_user.ToString(),
                historyTest.Id_exam.ToString(),
                historyTest.NameExam,
                historyTest.NumberExam.ToString(),
                historyTest.TotalPoint.ToString(),
                historyTest.Time_Completed.ToString(),
                historyTest.Date_Time.ToString(),
                historyTest.Result
                    };

                    KetQuaTable.Rows.Add(row);
                }
            }
            else
            {

                MessageBox.Show("Không có kết quả nào cho môn học này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {

            if (MonHocOption.SelectedIndex != -1)
            {

                string monHoc = MonHocOption.SelectedItem.ToString();
                List<History> historyTests = examModify.GetHistoryTestBySubject(id_User, monHoc);
                DisplayHistoryTests(historyTests);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học.");
            }

        }



        private void trangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(FullName, -1 / 2 * FullName.Width, FullName.Height);
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
        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_User);
            chooseExam.ShowDialog();
            this.Close();
        }

        private void MonHocOption_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }    
}
