using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login.User.Model
{
    internal class Exam
    {
        private int id_exam;
        private string name_exam;
        private int exam_number;
        private int number_question;
        private int time;
        public Exam()
        {

        }

        public Exam(int id_exam)
        {
            this.id_exam = id_exam;
        }

        public Exam(string name_exam, int exam_number, int number_question, int time)
        {
            this.name_exam = name_exam;
            this.exam_number = exam_number;
            this.number_question = number_question;
            this.time = time;
        }

        public Exam(int id_exam, string name_exam, int exam_number, int number_question, int time)
        {
            this.id_exam = id_exam;
            this.name_exam = name_exam;
            this.exam_number = exam_number;
            this.number_question = number_question;
            this.time = time;
        }

        public int Id_exam { get => id_exam; set => id_exam = value; }
        public string Name_exam { get => name_exam; set => name_exam = value; }
        public int Exam_number { get => exam_number; set => exam_number = value; }
        public int Number_question { get => number_question; set => number_question = value; }
        public int Time { get => time; set => time = value; }
    }
}
