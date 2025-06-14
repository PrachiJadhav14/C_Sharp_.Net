using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fork_Addmission_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "Admin" && tb_Password.Text == "1455")
            {
                MessageBox.Show("Login Successful", "WELCOME");

                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Login Failed, Enter Correct UserName/Password.", "Failure");
            }
            tb_UserName.Clear();
            tb_Password.Clear();
            tb_UserName.Focus();
        }

       
    }
}
