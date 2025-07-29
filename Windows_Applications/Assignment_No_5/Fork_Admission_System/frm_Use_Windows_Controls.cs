using System;
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
    public partial class frm_Use_Windows_Control : Form
    {
        public frm_Use_Windows_Control()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void tb_Employee_Department_TextChanged(object sender, EventArgs e)
        {
            tb_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           ///-Harry - from department - Testing - is- Male - candidate , prefers shift timing - Eveningh-.
            String Result = "";
            bool Flag = true;

            if (tb_Name.Text != "")
            {
                Result += tb_Name.Text + " form department ";

                if(cmb_Department.Text != "")
                {
                    Result += cmb_Department.Text + " is ";

                    if(rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " candidate , prefers shift timing ";
                    }
                    else if(rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " candiadte , prefers shift timing ";

                    }
                    else
                    {
                        MessageBox.Show("Select Gender Of Employee ");
                        Flag = false;
                    }

                    if(rb_Mornigh.Checked == true)
                    {
                        Result += rb_Mornigh.Text + ".";
                       
                    }
                    else if(rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ".";

                    }
                    else if(rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Time ");
                        Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee Dept");
                    Flag = false;
                }
            }
            else
            {
                MessageBox.Show("Enter Name Of Emplyoee ");
                Flag = false;
            }
            if(Flag == true)
            {
                tb_Output.Text = Result;
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Output.Clear();
            cmb_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Mornigh.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;

        }
        private void frm_Use_Windows_Control_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
        }
    } 
}
