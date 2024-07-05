using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login.User.Model
{
    internal class Ranking
    {
        private int id_User;
        private string fullname;
        private int completed_Exams;
        private int total_Points;
        private int total_Time;

        public Ranking()
        {
        }

        public Ranking(int id_User, string username, int completed_Exams, int total_Points, int total_Time)
        {
            this.id_User = id_User;
            this.fullname = username;
            this.completed_Exams = completed_Exams;
            this.total_Points = total_Points;
            this.total_Time = total_Time;

        }

        public int Id_User { get => id_User; set => id_User = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int Completed_Exams { get => completed_Exams; set => completed_Exams = value; }
        public int Total_Points { get => total_Points; set => total_Points = value; }

        public int Total_Time { get => total_Time; set => total_Time = value; }


    }
}
