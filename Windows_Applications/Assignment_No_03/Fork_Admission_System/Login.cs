using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fork_Admission_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection FCon = new SqlConnection(@"Data Source=LAPTOP-T2Q4BSUC;Initial Catalog=Fork_Addmission_System;Integrated Security=True");

        void FCon_Start()
        {
            if(FCon.State != ConnectionState.Open)
            {
                FCon.Open();

            }
        }
        void FCon_Stop()
        {
            if(FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }
            
        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_UserName.Focus();
        }
        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;

        }
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            FCon_Start();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = FCon;
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username = @Unm And Password = @Pw";

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = tb_UserName.Text;
            Cmd.Parameters.Add("Pw", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Welcome To Fork Admissions App", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.UserName = tb_UserName.Text;

                frm_Add_Student_Details Obj = new frm_Add_Student_Details();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_UserName.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_UserName.Focus();

            FCon_Stop();
        }

      
    }

       
    }

