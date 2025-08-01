﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fork_Admission_System
{
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = "Welcome " + Shared_Content.UserName;
            // TODO: This line of code loads data into the 'fork_Addmission_SystemDataSet.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter.Fill(this.fork_Addmission_SystemDataSet.Student_List);
            

        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();

        }
    }
}
