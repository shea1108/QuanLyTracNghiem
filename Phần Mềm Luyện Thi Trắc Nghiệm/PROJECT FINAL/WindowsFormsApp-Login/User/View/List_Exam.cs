using CustomBox.RJControls;
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

namespace WindowsFormsApp_Login.User.View
{
    public partial class List_Exam : Form
    {
        int id_user;
        string subject;
        public List_Exam()
        {
            InitializeComponent();
        }
        List<Exam> ex = new List<Exam>();
        public List_Exam(int id,string s)
        {
            InitializeComponent();
            id_user = id;
            subject = s;
            title.Text = "Danh sách đề thi : " + subject; 
            ExamModify examModify = new ExamModify();
            string querry = "SELECT * FROM list_exam WHERE Name_Exam = N'" + subject + "' ";
            ex = examModify.GetExams(querry);

            for (int i = 0; i < ex.Count; i++)
            {
                
                RJButton button = new RJButton();
                button.Width = 416; 
                button.Height = 40; 
                button.Font = new Font("Montserrat", 11, FontStyle.Bold);
                button.BackColor = Color.SlateGray;
                button.Text = "Đề " + ex[i].Exam_number + " - " + ex[i].Name_exam +" - " +ex[i].Number_question +" câu - " +ex[i].Time +" phút";
                button.BorderRadius = 16;
                listExam.Controls.Add(button);
                int currentIndex = i;
                int id_exam = ex[currentIndex].Id_exam;
                button.Click += (sender, e) =>
                {   
                   this.Hide();
                   LamBai lamBai = new LamBai(id_user,id_exam);
                   lamBai.ShowDialog();
                   this.Close();
                };
                 
            }
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_user);
            chooseExam.ShowDialog();
            this.Close();
        }
    }
}
