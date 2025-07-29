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
        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_UserName.Focus();
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            tb_UserName.Enabled = true;
            lbl_Error.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_UserName.Text == "Admin" && tb_Password.Text == "a@123") || (tb_UserName.Text == "A" && tb_Password.Text == "1"))
            {
                MessageBox.Show("Welcome To Fork Admission App", "Login Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                Shared_Content.UserName = tb_UserName.Text;

                frm_Add_Student_Details obj = new frm_Add_Student_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect UserName/Password", "Login Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
             tb_UserName.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_UserName.Focus();
        }

       
    }
}
