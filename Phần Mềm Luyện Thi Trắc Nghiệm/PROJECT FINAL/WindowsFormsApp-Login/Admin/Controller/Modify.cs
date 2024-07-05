using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp_Login
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoan> TaiKhoans(string querry)
        {
            List<TaiKhoan> tk = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection() )
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry,sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tk.Add(new TaiKhoan(dataReader.GetInt32(0),dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5)));
                }
                sqlConnection.Close();
            }
            

            return tk;
        }

        public void Command(string querry)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public int CheckTK(string nameTk, string phoneNumber)
        {
            int check = 0;

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT Id_User FROM Users WHERE username = @username AND phone_number = @phone_number";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@username", nameTk);
                        command.Parameters.AddWithValue("@phone_number", phoneNumber);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            check = reader.GetInt32(0);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An SQL error occurred: " + ex.Message);
                    
                }
            }

            return check;
        }


        public static void UpdatePassword(string newPassword, int id)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE Users SET password = @newPassword WHERE Id_User = @id";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {

                    Console.WriteLine("An SQL error occurred: " + ex.Message);
                    
                }
            }
        }

        public bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        // Phương thức để kiểm tra tính hợp lệ của số điện thoại
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng số điện thoại
            string pattern = @"^(?:0|\+?84)(?:\d){9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public bool ContainsAccentedCharacters(string input)
        {
            // Biểu thức chính quy để kiểm tra nguyên âm và dấu thanh tiếng Việt
            Regex regex = new Regex(@"[àáảãạăằắẳẵặâầấẩẫậèéẻẽẹêềếểễệìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵ]");
            return regex.IsMatch(input);
        }

    }
}
