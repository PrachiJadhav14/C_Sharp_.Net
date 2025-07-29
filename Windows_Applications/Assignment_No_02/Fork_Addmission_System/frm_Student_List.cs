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

        private void lbl_Student_List_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////private void btn_Student_List_Click(object sender, EventArgs e)
            {
                frm_Add_Student_Details obj = new frm_Add_Student_Details();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Hide();

        }


        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet4.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter4.Fill(this.fork_Addmission_SystemDataSet4.Student_List);
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet3.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter3.Fill(this.fork_Addmission_SystemDataSet3.Student_List);
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet3.Student_List' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet2.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter2.Fill(this.fork_Addmission_SystemDataSet2.Student_List);
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet1.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter1.Fill(this.fork_Addmission_SystemDataSet1.Student_List);

        }

       
    }
}
