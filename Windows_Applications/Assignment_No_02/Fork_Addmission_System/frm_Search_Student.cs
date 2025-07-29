using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fork_Addmission_System
{
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }
        SqlConnection FCon = new SqlConnection(@"Data Source=LAPTOP-T2Q4BSUC;Initial Catalog=Fork_Addmission_System;Integrated Security=True");

        void FCon_Start()
        {
            if (FCon.State != ConnectionState.Open )
            {
                FCon.Open();
            }
        }


        void FCon_Stop()
        {
            if (FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_Date_Of_Birth.Text = "01-02-2001";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
        }
        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Hide();
        }


        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }
        private void btn_logut_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }


        private void lbl_Logged_In_User_Click(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = "WelCome " + Shared_Content.UserName; 
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            FCon_Start();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Select * From Student_List Where Roll_No = @Rno";
                Cmd.Connection = FCon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = DR["DOB"].ToString();
                    tb_Mob_No.Text = (DR["Mob_No"].ToString());
                    cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("Invalid Roll No.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();

                }
            }
            FCon_Stop();
        }

        private void btn_Student_List_Click_1(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }
    }
}
