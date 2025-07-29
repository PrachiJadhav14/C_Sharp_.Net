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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }
        SqlConnection FCon = new SqlConnection(@"Data Source=LAPTOP-T2Q4BSUC;Initial Catalog=Fork_Addmission_System;Integrated Security=True");

       void  FCon_Start()
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

            dtp_Date_Of_Birth.Text = "14-05-2005";
        }
        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = "Welcome " + Shared_Content.UserName;
            tb_Roll_No.Focus();
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();
            if (tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Select * From Student_List where Roll_No = @Rno";
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
                    MessageBox.Show("Invalid Roll No", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();
                }
            }

            FCon_Stop();
        }
        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            frm_Update_Student obj = new frm_Update_Student();
            obj.Show();
            this.Hide();
                 
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Name.Enabled = true;

        }

        private void dtp_Date_Of_Birth_ValueChanged(object sender, EventArgs e)
        {
            dtp_Date_Of_Birth.Enabled = true;
        }

        private void tb_Mob_No_TextChanged(object sender, EventArgs e)
        {
            tb_Mob_No.Enabled= true;

        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Course.Enabled = true;
        }
    }
}
