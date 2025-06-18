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

namespace Fork_Addmission_System
{
    public partial class frm_Add_New_Student : Form

    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
            

        }
       

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-T2Q4BSUC;Initial Catalog=DB_Student_Addmission_System;Integrated Security=True");
        void Con_Open()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        void Con_Close()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            cmb_Date_Of_Birth.Text = "14-05-2005";
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Date_Of_Birth.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Insert Into Student_Details Values(@Rno,@Nm,@MNo,@Dob,@Course)";

                cmd.Parameters.Add("RNo",SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name;
                cmd.Parameters.Add("MNo", SqlDbType.Int).Value = tb_Mob_No;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = cmb_Date_Of_Birth;
                cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value = cmb_Course;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully.........");
                
            }
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Show();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
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

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||  (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        
        private void Only_Numbric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
    }
