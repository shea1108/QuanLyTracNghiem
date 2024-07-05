using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.User.View
{
    public partial class ChooseExam : Form
    {
        List<Subject> subjects = new List<Subject>();
        List<Exam> exams = new List<Exam>();
        int id_user;
      
        public ChooseExam(int id)
        {
            InitializeComponent();
            id_user = id;

            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string user_querry = "SELECT * FROM Users WHERE Id_User = '" + id + "'";
            Modify modify = new Modify();
            taiKhoans = modify.TaiKhoans(user_querry);
            FullName.Text = taiKhoans[0].Fullname;


            string querry = "SELECT * FROM list_subject";
            ExamModify examModify = new ExamModify(); 
            subjects = examModify.Subjects(querry);
            querry = "SELECT * FROM list_exam";
            exams =examModify.GetExams(querry);

            


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("Môn thi");
            dataTable.Columns.Add("Đề thi hiện tại trên hệ thống");
            dataTable.Columns.Add("Đề thi hiện tại của bạn");
            for (int i = 0; i < subjects.Count; i++)
            {
                listSubject.Items.Add(subjects[i].NameExam);
                querry = @"
                SELECT id_User, NameExam, COUNT(DISTINCT NumberExam) AS different_number_exams
                FROM History_Test
                GROUP BY id_user, NameExam; ";
                int countExam = examModify.CountExam(querry, subjects[i].NameExam, id_user);


                dataTable.Rows.Add(i + 1, subjects[i].NameExam, CountExam(subjects[i].NameExam),countExam);
                
            }
            listSubject.Texts = subjects[0].NameExam;

            SubjectTable.DataSource = dataTable;
            SubjectTable.DefaultCellStyle.Font = new Font("Montserrat", 9, FontStyle.Bold);
            SubjectTable.Columns["STT"].Width = 100;
            SubjectTable.Columns["Môn thi"].Width = 200;
            SubjectTable.Columns["Đề thi hiện tại trên hệ thống"].Width = 200;
            SubjectTable.Columns["Đề thi hiện tại của bạn"].Width = 200;
        }

        public int CountExam(string s)
        {
            int count = 0;
            for (int i = 0;i<exams.Count;i++)
            {
                if (exams[i].Name_exam == s)
                    count++;
            }    
            return count;
        }

        private void trangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_user);
            homeUser.ShowDialog();
            this.Close();
        }

        private void ketQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_user);
            ketQua.ShowDialog();
            this.Close();
        }



        private void rjButton2_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(FullName, -1 / 2 * FullName.Width, FullName.Height);
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }


        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
            this.Close();
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            string subject = listSubject.Texts;
            this.Hide();
            List_Exam list_Exam = new List_Exam(id_user,subject);
            list_Exam.ShowDialog();
            this.Close();
        }

        private void vaoThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
            this.Close();
        }
    }
}
