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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }
        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Show();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet1.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter1.Fill(this.fork_Addmission_SystemDataSet1.Student_List);
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter.Fill(this.fork_Addmission_SystemDataSet.Student_List);
            // TODO: This line of code loads data into the 'yC_Student_Addmission_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.


        }
    }
}
