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
    public partial class AddQuestion : Form
    {
        List<Exam > exams = new List<Exam>();
        List<Question> dataList = new List<Question>();
        int pos = 0;
        string nameExam;
        int numberExam;
        int soCau;
        int time_ex;
        int id_ex;
        public AddQuestion(string s, int a, int b, int c)
        {
            InitializeComponent();  
            nameExam = s;
            soCau = b;
            numberExam = a;
            time_ex = c;
            tenMon.Text = ("Môn học: " + nameExam);
            tenDe.Text = ("Đề số: " + a);
            cauHoi.Text = ("Câu số: " + (pos + 1));
            for (int i = 0; i < soCau; i++)
            {
                Question q = new Question();
                dataList.Add(q);
            }
            View();

        }
        public void View()
        {
            cauHoi.Text = "Câu hỏi " + (pos + 1);
            if (dataList[pos].Status == 0)
            {
                question.Text = "";
                answerA.Text = "";
                answerB.Text = "";
                answerC.Text = "";
                answerD.Text = "";
                answerCorrect.SelectedItem = null;
            }
            else
            {
                question.Text = dataList[pos].Question1;
                answerA.Text = dataList[pos].AnswerA;
                answerB.Text = dataList[pos].AnswerB;
                answerC.Text = dataList[pos].AnswerC;
                answerD.Text = dataList[pos].AnswerD;
                this.answerCorrect.Text = ConvertNumberToLetter(dataList[pos].Answer);
            }
            Luu.Visible = (pos == soCau - 1);
        }
        private string ConvertNumberToLetter(int number)
        {
            switch (number)
            {
                case 1:
                    return "A";
                case 2:
                    return "B";
                case 3:
                    return "C";
                case 4:
                    return "D";
                default:
                    return "";
            }
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(question.Text)
                && !string.IsNullOrEmpty(answerA.Text)
                && !string.IsNullOrEmpty(answerB.Text)
                && !string.IsNullOrEmpty(answerC.Text)
                && !string.IsNullOrEmpty(answerD.Text)
                && answerCorrect.SelectedItem != null
                && !string.IsNullOrEmpty(answerCorrect.SelectedItem.ToString()))
            {
                string selectedAnswer = answerCorrect.SelectedItem.ToString();
                int answerValue;

                switch (selectedAnswer)
                {
                    case "A":
                        answerValue = 1;
                        break;
                    case "B":
                        answerValue = 2;
                        break;
                    case "C":
                        answerValue = 3;
                        break;
                    case "D":
                        answerValue = 4;
                        break;
                    default:
                        answerValue = 0;
                        break;
                }

                if (answerValue != 0)
                {
                    Question q = new Question(
                        
                        question.Text,
                        answerA.Text,
                        answerB.Text,
                        answerC.Text,
                        answerD.Text,
                        answerValue,
                        1
                    );
                    dataList[pos] = q;
                    if (pos + 1 < soCau)
                    {
                        pos++;
                        View();
                    }
                    else
                    {
                        MessageBox.Show("Không thể chuyển sang câu hỏi tiếp theo. Hãy lưu câu hỏi nếu bạn đã nhập đủ câu hỏi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị đúng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô trên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (pos - 1 >= 0)
            {
                if (!string.IsNullOrEmpty(question.Text)
                    && !string.IsNullOrEmpty(answerA.Text)
                    && !string.IsNullOrEmpty(answerB.Text)
                    && !string.IsNullOrEmpty(answerC.Text)
                    && !string.IsNullOrEmpty(answerD.Text)
                    && answerCorrect.SelectedItem != null
                    && !string.IsNullOrEmpty(answerCorrect.SelectedItem.ToString()))
                {
                    string selectedAnswer = answerCorrect.SelectedItem.ToString();
                    int answerValue = 0;

                    switch (selectedAnswer)
                    {
                        case "A":
                            answerValue = 1;
                            break;
                        case "B":
                            answerValue = 2;
                            break;
                        case "C":
                            answerValue = 3;
                            break;
                        case "D":
                            answerValue = 4;
                            break;
                        default:

                            MessageBox.Show("Giá trị đúng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    Question q = new Question(
                        
                        question.Text,
                        answerA.Text,
                        answerB.Text,
                        answerC.Text,
                        answerD.Text,
                        answerValue,
                        1
                    );

                    dataList[pos] = q;
                }

                pos--;
                View();
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            Exam exm = new Exam(nameExam, numberExam, soCau, time_ex);
            ExamModify.InsertExam(exm);

            ExamModify examModify = new ExamModify();


            string query = "SELECT * FROM list_exam ";
            exams = examModify.GetExams(query);

            id_ex = exams[exams.Count - 1].Id_exam;

            if (!string.IsNullOrEmpty(question.Text)
                 && !string.IsNullOrEmpty(answerA.Text)
                 && !string.IsNullOrEmpty(answerB.Text)
                 && !string.IsNullOrEmpty(answerC.Text)
                 && !string.IsNullOrEmpty(answerD.Text)
                 && answerCorrect.SelectedItem != null
                 && !string.IsNullOrEmpty(answerCorrect.SelectedItem.ToString()))
            {
                string selectedAnswer = answerCorrect.SelectedItem.ToString();
                int answerValue;

                switch (selectedAnswer)
                {
                    case "A":
                        answerValue = 1;
                        break;
                    case "B":
                        answerValue = 2;
                        break;
                    case "C":
                        answerValue = 3;
                        break;
                    case "D":
                        answerValue = 4;
                        break;
                    default:
                        answerValue = 0;
                        break;
                }

                if (answerValue != 0)
                {
                    Question q = new Question(
                        
                        question.Text,
                        answerA.Text,
                        answerB.Text,
                        answerC.Text,
                        answerD.Text,
                        answerValue,
                        1
                    );
                    dataList[pos] = q;

                    List<Question> dataList1 = new List<Question>();
                    foreach (Question c in dataList)
                    {
                        Question q1 = new Question(
                        id_ex,
                        c.Question1,
                        c.AnswerA,
                        c.AnswerB,
                        c.AnswerC,
                        c.AnswerD,
                        c.Answer,
                        0
                        );
                        dataList1.Add( q1 );    
                    }
                    foreach (Question c in dataList1)
                    {
                        ExamModify.InsertQuestion(c);
                    }
                    MessageBox.Show("Thêm câu hỏi vào đề thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
