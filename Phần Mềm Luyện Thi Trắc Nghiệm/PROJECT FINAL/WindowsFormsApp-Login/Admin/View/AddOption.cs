using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class AddOption : Form
    {
       
        string name_ex;
        int number_ex;
        int soCau;
        int time_ex;
        
        public AddOption(int id, string s, int a, int b, int c)
        {
            InitializeComponent();
            name_ex = s;
            number_ex = a;
            soCau = b;
            time_ex = c;
        }

        private void btn_thucong_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuestion aq = new AddQuestion( name_ex, number_ex, soCau, time_ex);
            aq.ShowDialog();
            this.Close();
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
