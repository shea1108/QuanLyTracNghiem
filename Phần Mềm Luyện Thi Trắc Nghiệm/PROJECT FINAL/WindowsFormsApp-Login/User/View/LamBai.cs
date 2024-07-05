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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace WindowsFormsApp_Login.User.View
{
    public partial class LamBai : Form
    {
        List<Question> questions = new List<Question>();
        List<Exam> exams = new List<Exam>();
        Question question = new Question();
        ExamModify examModify = new ExamModify();
        int pos = 0;
        Label DeBaiTxt = new Label();
        int choice = 0;
        int number_Question = 1;

        private Timer countdownTimer;
        private DateTime targetTime;
        private DateTime startTime;
        int id_user, id_exam;
       
       public LamBai(int id,int id_Exam)
       {
            InitializeComponent();
            InitializeTimer();
            id_user = id;
            id_exam = id_Exam;
            // Thiết lập kích thước cho nhãn
            DeBaiTxt.Size = new Size(415, 60);
            DeBaiTxt.Font = new Font("Montserrat", 10, FontStyle.Bold);
            DeBaiTxt.Text = "label";
            
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel1.Controls.Add(DeBaiTxt);
            DeBaiTxt.Parent = panel1;
            DeBaiTxt.BackColor = Color.White;
            
            panel1.BackColor = Color.Transparent;


            

            // Thiết lập kích thước cho nhãn
            DapAnATxt.Size = new Size(222, 57);
            DapAnATxt.Font = new Font("Montserrat", 8, FontStyle.Bold);
            DapAnATxt.Text = "A";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel2.Controls.Add(DapAnATxt);
            DapAnATxt.Parent = panel2;
            DapAnATxt.BackColor = Color.Transparent;
          
            panel2.BackColor = Color.Transparent;



            // Thiết lập kích thước cho nhãn
            DapAnBTxt.Size = new Size(222, 57);
            DapAnBTxt.Font = new Font("Montserrat", 8, FontStyle.Bold);
            DapAnBTxt.Text = "B";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel3.Controls.Add(DapAnBTxt);
            DapAnBTxt.Parent = panel3;
            DapAnBTxt.BackColor = Color.Transparent;
           
            panel3.BackColor = Color.Transparent;



            // Thiết lập kích thước cho nhãn
            DapAnCTxt.Size = new Size(222, 57);
            DapAnCTxt.Font = new Font("Montserrat", 8, FontStyle.Bold);
            DapAnCTxt.Text = "C";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel4.Controls.Add(DapAnCTxt);
            DapAnCTxt.Parent = panel4;
            DapAnCTxt.BackColor = Color.Transparent;
           
            panel4.BackColor = Color.Transparent;



            // Thiết lập kích thước cho nhãn
            DapAnDTxt.Size = new Size(222, 57);
            DapAnDTxt.Font = new Font("Montserrat", 8, FontStyle.Bold);
            DapAnDTxt.Text = "D";
            // Thêm nhãn vào trong một container, chẳng hạn như một Panel
            panel5.Controls.Add(DapAnDTxt);
            DapAnDTxt.Parent = panel5;
            DapAnDTxt.BackColor = Color.Transparent;
            
            panel5.BackColor = Color.Transparent;

           
            numberQuestion.BackColor = Color.Transparent;



            string querryQuestion = "SELECT * FROM Question WHERE Id_Exam= '" + id_exam + "' ";

            string querryExam = "SELECT * FROM list_exam WHERE Id_Exam= '" + id_exam + "' ";
            exams = examModify.GetExams(querryExam);

            questions = examModify.Questions(querryQuestion);

            View();
            StartCountdown(DateTime.Now.AddMinutes(exams[0].Time));
        }
        private void View()
        {
            
            question = questions[pos];
            DeBaiTxt.Text = question.Question1;
            DapAnATxt.Text = "A. " + question.AnswerA;
            DapAnBTxt.Text = "B. " + question.AnswerB;
            DapAnCTxt.Text = "C. " + question.AnswerC;
            DapAnDTxt.Text = "D. " + question.AnswerD;
            choice = question.Status;
            numberQuestion.Text = number_Question.ToString();
            switch (question.Status)
            {
                case 1:
                    DapAnATxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
                case 2:
                    DapAnBTxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
                case 3:
                    DapAnCTxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
                case 4:
                    DapAnDTxt.BackColor = Color.FromArgb(161, 255, 174);
                    break;
            }
            
        }

        private void InitializeTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 giây
            countdownTimer.Tick += CountdownTimer_Tick;
        }
        private void StartCountdown(DateTime target)
        {
            targetTime = target;
            startTime = DateTime.Now;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = targetTime - DateTime.Now;
            if (remainingTime.TotalSeconds > 0)
            {
                labelCountdown.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                countdownTimer.Stop();
                labelCountdown.Text = "00:00:00";
                MessageBox.Show("Đã hết thời gian!");
                SubmitTest();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn thoát khỏi bài thi ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                this.Hide();
                HomeUser homeUser = new HomeUser(id_user);
                homeUser.ShowDialog();
                this.Close();
            }
            
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            
            if (pos < questions.Count - 1)
            {
                questions[pos].Status = choice;
                pos++;
                DapAnATxt.BackColor = Color.Transparent;
                DapAnBTxt.BackColor = Color.Transparent;
                DapAnCTxt.BackColor = Color.Transparent;
                DapAnDTxt.BackColor = Color.Transparent;
                number_Question++;
                View();
                
            }
            else
            {
                MessageBox.Show("KHONG THE CHUYEN SANG CAU HOI TIEP THEO");
            }

        }
        
        private void back_btn_Click(object sender, EventArgs e)
        {
            if (pos >0)
            {
                questions[pos].Status = choice;
                pos--;
                DapAnATxt.BackColor = Color.Transparent;
                DapAnBTxt.BackColor = Color.Transparent;
                DapAnCTxt.BackColor = Color.Transparent;
                DapAnDTxt.BackColor = Color.Transparent;
                number_Question--;
                View();
                
            }
            else
            {
                MessageBox.Show("KHONG THE CHUYEN SANG CAU HOI TIEP THEO");
            }
        }
        private void DapAnATxt_Click(object sender, EventArgs e)
        {
            DapAnATxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnBTxt.BackColor = Color.Transparent;
            DapAnCTxt.BackColor = Color.Transparent;
            DapAnDTxt.BackColor = Color.Transparent;
            choice = 1;
        }

        private void DapAnBTxt_Click(object sender, EventArgs e)
        {
            DapAnBTxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnATxt.BackColor = Color.Transparent;
            DapAnCTxt.BackColor = Color.Transparent;
            DapAnDTxt.BackColor = Color.Transparent;
            choice = 2;
        }

        private void DapAnDTxt_Click(object sender, EventArgs e)
        {
            DapAnDTxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnBTxt.BackColor = Color.Transparent;
            DapAnCTxt.BackColor = Color.Transparent;
            DapAnATxt.BackColor = Color.Transparent;
            choice = 4;
        }

        private void DapAnCTxt_Click(object sender, EventArgs e)
        {
            DapAnCTxt.BackColor = Color.FromArgb(161, 255, 174);
            DapAnBTxt.BackColor = Color.Transparent;
            DapAnATxt.BackColor = Color.Transparent;
            DapAnDTxt.BackColor = Color.Transparent;
            choice = 3;
        }

        public void SubmitTest()
        {
            int d = 0;
            questions[pos].Status = choice;
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Status == questions[i].Answer)
                {
                    d++;
                }
            }
            countdownTimer.Stop();
            TimeSpan elapsedTime = DateTime.Now - startTime;

            double tongDiem = ((double)d / questions.Count) * 10;
            string ketqua = d.ToString() + "/" + questions.Count.ToString();
            int thoigian = (int)elapsedTime.TotalSeconds;

            string insertHistory = "Insert into History_Test values ('" + id_user + "','" + id_exam + "',N'" + exams[0].Name_exam + "','" + exams[0].Exam_number + "','" + thoigian + "','" + ketqua + "','" + tongDiem + "','" + DateTime.Now.ToString() + "' ) ";
            examModify.HistoryTest(insertHistory);

            this.Hide();
            FinalForm finalForm = new FinalForm(id_user, ketqua, tongDiem, thoigian, questions);
            finalForm.ShowDialog();
            this.Close();
        }
        private void NopBaiBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn nộp bài ?", "Xác nhận nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                SubmitTest();
            }
            
        }
    }
}
