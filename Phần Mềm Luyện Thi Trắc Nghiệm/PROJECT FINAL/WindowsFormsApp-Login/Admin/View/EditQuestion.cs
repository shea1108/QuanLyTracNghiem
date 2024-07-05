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
    public partial class EditQuestion : Form
    {
        ExamModify examModify = new ExamModify();
        List<Question> dataList = new List<Question>();
        int pos = 0;
        int id_exam;
        string nameExam;
        int numberExam;
        int soCau;
        public EditQuestion(int idex, string s, int a, int b)
        {
            InitializeComponent();
            Question q = new Question();
            nameExam = s;
            numberExam = a;
            id_exam = idex;
            soCau = b;
            
            tenMon.Text = "Môn học : " + nameExam;
            tenDe.Text = "ĐỀ THI SỐ " + numberExam;
            cauHoi.Text = "Câu Hỏi " + (pos + 1);
            for (int i = 0; i < b; i++)
            {
                q.Status=0;
                dataList.Add(q);
            }
            LoadDataFromDatabase();
            View();
        }
        private void LoadDataFromDatabase()
        {
            dataList = examModify.GetQuestions(id_exam);
        }


        private void back_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void View()
        {
            if (pos >= 0 && pos < dataList.Count)
            {
                tenMon.Text = "Môn học : " + nameExam;
                tenDe.Text = "ĐỀ THI SỐ " + numberExam;
                cauHoi.Text = "Câu Hỏi " + (pos + 1);

                Question q = dataList[pos];
                this.question.Text = q.Question1;
                this.answerA.Text = q.AnswerA;
                this.answerB.Text = q.AnswerB;
                this.answerC.Text = q.AnswerC;
                this.answerD.Text = q.AnswerD;
                int answerValue = q.Answer;
                this.answerCorrect.Text = ConvertNumberToLetter(answerValue);
            }
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
                        id_exam,
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
                        id_exam,
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

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.question.Text)
                && !string.IsNullOrEmpty(this.answerA.Text)
                && !string.IsNullOrEmpty(this.answerB.Text)
                && !string.IsNullOrEmpty(this.answerC.Text)
                && !string.IsNullOrEmpty(this.answerD.Text)
                && !string.IsNullOrEmpty(this.answerCorrect.Text))
            {
                string selectedAnswer = this.answerCorrect.Text.ToUpper();
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
                        id_exam,
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
            }

            ExamModify.DeleteQuestion(id_exam);
            foreach (Question que in dataList)
            {
                ExamModify.InsertQuestion(que);
            }



            MessageBox.Show("Thêm câu hỏi vào đề thành công !");
            
            
            this.Close();
        }
    }
}
