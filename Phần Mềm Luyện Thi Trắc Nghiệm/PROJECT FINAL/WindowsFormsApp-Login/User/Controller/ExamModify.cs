using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.User.Controller
{
    internal class ExamModify
    {
        public ExamModify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Question> Questions(string querry)
        {
            List<Question> q = new List<Question>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    q.Add(new Question(dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetInt32(7), dataReader.GetInt32(8)));

                }
                sqlConnection.Close();
            }
            return q;
        }

        public List<Subject> Subjects(string querry)
        {
            List<Subject> sj = new List<Subject>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    sj.Add(new Subject(dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return sj;
        }
        public List<Exam> GetExams(string querry)
        {
            List<Exam> ex = new List<Exam>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    ex.Add(new Exam(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetInt32(4)));
                }
                sqlConnection.Close();
            }
            return ex;
        }
        public List<History> histories(string querry)
        {
            List<History> hs = new List<History>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    hs.Add(new History(dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetString(3), dataReader.GetInt32(4), dataReader.GetInt32(5), dataReader.GetInt32(7)));
                }
                sqlConnection.Close();
            }
            return hs;
        }
        public int CountExam(string querry, string nameExam, int id)
        {
            int count = 0;
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    int id_user = dataReader.GetInt32(0);
                    string name_exam = dataReader.GetString(1);
                    int different_number_exams = dataReader.GetInt32(2);
                    if (id_user == id && name_exam == nameExam)
                    {
                        count = different_number_exams;
                        break;
                    }
                    
                }
                sqlConnection.Close();
            }
            return count;
        }
        public void HistoryTest(string querry)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        
        public List<Subject> GetSubject(string query)
        {
            List<Subject> subject = new List<Subject>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            subject.Add(new Subject(dataReader.GetInt32(0),dataReader.GetString(1)));
                        }
                    }
                }
            }
            return subject;
        }

        

        public static void DeleteSubject(int id)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "DELETE FROM list_subject WHERE id = @Id";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }


        public static void InsertQuestion(Question q)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "INSERT INTO Question (Id_Exam,question, AnswerA, AnswerB, AnswerC, AnswerD, Correct_Answer, Status) " +
                             "VALUES (@Id_Exam, @question, @AnswerA, @AnswerB, @AnswerC, @AnswerD, @CorrectAnswer, @Status)";

                using (SqlCommand statement = new SqlCommand(sql, conn))
                {
                    statement.Parameters.AddWithValue("@Id_Exam", q.Id_exam);
                    statement.Parameters.AddWithValue("@question", q.Question1);
                    statement.Parameters.AddWithValue("@AnswerA", q.AnswerA);
                    statement.Parameters.AddWithValue("@AnswerB", q.AnswerB);
                    statement.Parameters.AddWithValue("@AnswerC", q.AnswerC);
                    statement.Parameters.AddWithValue("@AnswerD", q.AnswerD);
                    statement.Parameters.AddWithValue("@CorrectAnswer", q.Answer);
                    statement.Parameters.AddWithValue("@Status", 0);

                    statement.ExecuteNonQuery();
                }
            }
        }
        public static void InsertExam(Exam exam)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                // Thực hiện chèn bản ghi
                string query = "INSERT INTO list_exam (Name_Exam, Exam_Number, number_Question, Time) " +
                               "VALUES ( @NameExam, @NumberExam, @SoCauHoi, @ThoiGian)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NameExam", exam.Name_exam);
                    command.Parameters.AddWithValue("@NumberExam", exam.Exam_number);
                    command.Parameters.AddWithValue("@SoCauHoi", exam.Number_question);
                    command.Parameters.AddWithValue("@ThoiGian", exam.Time);

                    command.ExecuteNonQuery();
                }




                conn.Close();
            }
        }

        public static void InsertSubject(string s)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string query = "INSERT INTO list_subject (nameExam) " +
                               "VALUES ( @TenMonHoc)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@TenMonHoc", s);
                    

                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public static void Delete(int id)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "DELETE FROM list_exam WHERE Id_Exam = @Id";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteQuestion(int a)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "DELETE FROM Question WHERE  Id_Exam = @Id_Exam";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {

                    command.Parameters.AddWithValue("@Id_Exam", a);

                    command.ExecuteNonQuery();
                }
            }
        }

        

        public List<Question> GetQuestions(int id_exam)
        {
            List<Question> dataList = new List<Question>();

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM Question WHERE Id_Exam = @Id_Exam";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Id_Exam", id_exam);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataList.Add(new Question
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id_question")),
                                Id_exam = reader.GetInt32(reader.GetOrdinal("Id_Exam")),
                                Question1 = reader.GetString(reader.GetOrdinal("question")),
                                AnswerA = reader.GetString(reader.GetOrdinal("AnswerA")),
                                AnswerB = reader.GetString(reader.GetOrdinal("AnswerB")),
                                AnswerC = reader.GetString(reader.GetOrdinal("AnswerC")),
                                AnswerD = reader.GetString(reader.GetOrdinal("AnswerD")),
                                Answer = reader.GetInt32(reader.GetOrdinal("Correct_Answer")),
                                Status = reader.GetInt32(reader.GetOrdinal("Status"))
                            });
                        }
                    }
                }
            }

            return dataList;
        }
        public List<Exam> GetExams_Search(string name_ex, int de_so)
        {
            List<Exam> exams = new List<Exam>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM list_exam WHERE Name_Exam LIKE @NameExam";
                if (de_so != -1)
                {
                    query += " AND Exam_Number = @NumberExam";
                }
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@NameExam", "%" + name_ex + "%");
                    if (de_so != -1)
                    {
                        sqlCommand.Parameters.AddWithValue("@NumberExam", de_so);
                    }

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            exams.Add(new Exam(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetInt32(4)));
                        }
                    }
                }
            }
            return exams;
        }


        public List<TaiKhoan> GetInforUsers(int id_User)
        {
            List<TaiKhoan> users = new List<TaiKhoan>();
            string query = "SELECT * FROM Users WHERE id_User = @UserId";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserId", id_User);

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            string username = dataReader.GetString(1);
                            string password = dataReader.GetString(2);
                            string fullname = dataReader.GetString(3);
                            string email = dataReader.GetString(4);
                            string phone_number = dataReader.GetString(5);

                            TaiKhoan user = new TaiKhoan(id_User, username, password, fullname, email, phone_number);
                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }


        public void DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE id_User = @UserId";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    // Kiểm tra số hàng đã bị ảnh hưởng
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa người dùng. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public List<TaiKhoan> UpdateUserInfo(int id_User, string username, string fullname, string email, string phone_number)
        {
            string query = "UPDATE Users SET username = @Username, fullname = @Fullname, email = @Email, phone_number = @PhoneNumber WHERE id_User = @UserId";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Username", username);
                    sqlCommand.Parameters.AddWithValue("@Fullname", fullname);
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", phone_number);
                    sqlCommand.Parameters.AddWithValue("@UserId", id_User);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {

                        return GetInforUsers(id_User);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }


        

        public bool ChangePassword(int id_User, string newPassword)
        {
            string query = "UPDATE Users SET password = @NewPassword WHERE id_User = @UserId";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                    sqlCommand.Parameters.AddWithValue("@UserId", id_User);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        public List<History> GetHistoryTests(int id_User)
        {
            List<History> historyTests = new List<History>();
            string query = "SELECT * FROM History_Test WHERE Id_User = @UserId";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserId", id_User);

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            History historyTest = new History()
                            {
                                Id = dataReader.GetInt32(0),
                                Id_user = dataReader.GetInt32(1),
                                Id_exam = dataReader.GetInt32(2),
                                NameExam = dataReader.GetString(3),
                                NumberExam = dataReader.GetInt32(4),
                                Time_Completed = dataReader.GetInt32(5),
                                Result = dataReader.GetString(6),
                                TotalPoint = dataReader.GetInt32(7),
                                Date_Time = dataReader.GetString(8)

                            };
                            historyTests.Add(historyTest);
                        }
                    }
                }
            }

            return historyTests;
        }


        public List<History> GetHistoryTestBySubject(int id_User, string subject)
        {
            List<History> historyTests = new List<History>();
            string query = "SELECT * FROM History_Test WHERE Id_User = @UserId AND NameExam = @Subject";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserId", id_User);
                    sqlCommand.Parameters.AddWithValue("@Subject", subject);

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            History historyTest = new History()
                            {
                                Id = dataReader.GetInt32(0),
                                Id_user = dataReader.GetInt32(1),
                                Id_exam = dataReader.GetInt32(2),
                                NameExam = dataReader.GetString(3),
                                NumberExam = dataReader.GetInt32(4),
                                Time_Completed = dataReader.GetInt32(5),
                                Result = dataReader.GetString(6),
                                TotalPoint = dataReader.GetInt32(7),
                                Date_Time = dataReader.GetString(8)
                            };
                            historyTests.Add(historyTest);
                        }
                    }
                }
            }

            return historyTests;
        }

        public List<Subject> GetSubjectNames()
        {
            List<Subject> subjects = new List<Subject>();
            string query = "SELECT id, nameExam FROM list_subject";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int id = dataReader.GetInt32(0);
                            string nameExam = dataReader.GetString(1);

                            Subject subject = new Subject(id, nameExam);
                            subjects.Add(subject);
                        }
                    }
                }
            }

            return subjects;
        }

    }
}
