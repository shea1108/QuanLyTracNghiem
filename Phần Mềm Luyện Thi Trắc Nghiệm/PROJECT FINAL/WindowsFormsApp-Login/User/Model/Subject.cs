using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login.User.Model
{
    internal class Subject
    {
        private int id;
        private string nameExam;

        public Subject()
        {

        }

        public Subject(string nameExam)
        {
            this.nameExam = nameExam;
        }



        public Subject(int id, string nameExam)
        {
            this.id = id;
            this.nameExam = nameExam;

        }

        public int Id { get => id; set => id = value; }
        public string NameExam { get => nameExam; set => nameExam = value; }

    }

}
