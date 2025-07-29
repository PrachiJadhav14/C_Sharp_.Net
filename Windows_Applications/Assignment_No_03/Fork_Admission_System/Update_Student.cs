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
    public partial class frm_Update_Student : Form
    {
        public frm_Update_Student()
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
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_Date_Of_Birth.Text = "01-02-2001";
        }
        void Enable_Controls()
        {
            tb_Name.Enabled = true;
            tb_Mob_No.Enabled = true;
            dtp_Date_Of_Birth.Enabled = true;
            cmb_Course.Enabled = true;

            tb_Roll_No.Enabled = false;

        }

        void Disable_Control()
        {
            tb_Name.Enabled = false;
            tb_Mob_No.Enabled = false;
            dtp_Date_Of_Birth.Enabled = false;
            cmb_Course.Enabled = false;

            tb_Roll_No.Enabled = true;
        }
        private void frm_Update_Student_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = "Welcome " + Shared_Content.UserName;
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if((!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))))
            {
                e.Handled = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Control();
            tb_Roll_No.Focus();
        }
       
        private void btn_Update_Click(object sender, EventArgs e)
        {
            FCon_Start();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.SelectedIndex >= -1)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Update Student_List Set Name = @Nm, DOB = @db, Mob_No = @MNo, Course= @Course Where Roll_No = @RNo";
                Cmd.Connection = FCon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("db", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;

                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;


                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Update SuccesFully ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Control();

            }
            else
            {
                MessageBox.Show("1st Fill all fields");
            }
            FCon_Stop();

        }
        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Show();
        }
        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
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

                Cmd.CommandText = "Select * From Student_List Where Roll_No = @RNo";
                Cmd.Connection = FCon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = DR["DOB"].ToString();
                    tb_Mob_No.Text = (DR["Mob_No"]).ToString();
                    cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("Invalid Roll No.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();
                }
            }
            FCon_Stop();
        }

      
    }
}
