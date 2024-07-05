using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login
{
    class TaiKhoan
    {
        private int id;
        private string tenTk;
        private string matKhau;
        private string fullname;
        private string email;
        private string phone_number;
        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTk, string matKhau)
        {
            this.tenTk = tenTk;
            this.matKhau = matKhau;
        }

       

        public TaiKhoan(int id, string tenTk, string matKhau, string fullname, string email, string phone_number)
        {
            this.id = id;
            this.tenTk = tenTk;
            this.matKhau = matKhau;
            this.fullname = fullname;
            this.email = email;
            this.phone_number = phone_number;
        }

        public string TenTk { get => tenTk; set => tenTk = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
    }

}
