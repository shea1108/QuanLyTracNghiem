using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login.User.Model
{
    public class Question
    {
        private int id;
        private int id_exam;
        private string question;
        private string answerA;
        private string answerB;
        private string answerC;
        private string answerD;
        private int answer;
        private int status;

        public Question()
        {
        }

        public Question(string question, string answerA, string answerB, string answerC, string answerD)
        {
            this.question = question;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
        }

        public Question(string question, string answerA, string answerB, string answerC, string answerD, int answer, int status)
        {
            this.question = question;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.answer = answer;
            this.status = status;
        }

        public Question(int id_exam, string question, string answerA, string answerB, string answerC, string answerD, int answer, int status)
        {
            this.id_exam = id_exam;
            this.question = question;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.answer = answer;
            this.status = status;
        }

        public Question(int id, int id_exam, string question, string answerA, string answerB, string answerC, string answerD, int answer, int status)
        {
            this.id = id;
            this.id_exam = id_exam;
            this.question = question;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.answer = answer;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public int Id_exam { get => id_exam; set => id_exam = value; }
        public string Question1 { get => question; set => question = value; }
        public string AnswerA { get => answerA; set => answerA = value; }
        public string AnswerB { get => answerB; set => answerB = value; }
        public string AnswerC { get => answerC; set => answerC = value; }
        public string AnswerD { get => answerD; set => answerD = value; }
        public int Answer { get => answer; set => answer = value; }
        public int Status { get => status; set => status = value; }
    }
}
