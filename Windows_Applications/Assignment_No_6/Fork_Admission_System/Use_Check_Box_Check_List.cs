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
    public partial class frm_Use_CheckBox_Check_ListBox : Form
    {
        public frm_Use_CheckBox_Check_ListBox()
        {
            InitializeComponent();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, LFlag = true;

            /////////////////////////////////////////////

            if (tb_Employee_Name.Text != "")
            {
                Result += tb_Employee_Name.Text + "is From Deparment ";
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Text = "Error Employee Name ";
                lbl_Name_Error.Visible = true;
                Flag = false;
            }

            /////////////////////////////

            if (cmb_Employee_Department.Text != "")
            {
                Result += cmb_Employee_Department.Text;
                lbl_Department_Error.Visible = false;
            }
            else
            {
                lbl_Department_Error.Text = "Select Dept";
                lbl_Department_Error.Visible = true;
                Flag = false;
            }

            ///////////////////////////////////////////

            if (rb_Male.Checked == true)
            {
                Result += ", is " + rb_Male.Text + " And He Knowe ";
                lbl_Gender_Error.Visible = false;

            }
            else if (rb_Female.Checked == true)
            {
                Result += ", is " + rb_Female.Text + "And She Knows";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = "Select Gender";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }
            /////////////////////////////////////////////  

            if (cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + " , ";
                lbl_Lang_Error.Visible = false;
                LFlag = false;

            }

            if (cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + " ,";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }

            if (cb_English.Checked == true)
            {

                Result += cb_English.Text + " ,";
                lbl_Lang_Error.Visible = false;
                LFlag = false;

            }
            if (cb_French.Checked == true)
            {
                Result += cb_French.Text + " , ";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if (LFlag == true)
            {
                lbl_Lang_Error.Text = "Select Known Lang";
                lbl_Lang_Error.Visible = true;
                Flag = false;
            }
            /////////////////////////////////////////////////

            int Cnt = clb_Hobbies.CheckedItems.Count;
            if (Cnt > 0)
            {
                lbl_Hobby_Error.Visible = false;
                Result += " And Has Hobbies As ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] += " ,";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + " .";
                            break;

                        }
                        Cnt--;
                    }
                }
            }
            else
            {
                lbl_Hobby_Error.Text = "Select Atleast 1 Hobby";
                lbl_Hobby_Error.Visible = true;
                Flag = false;
            }
            ///////////////////////////////////////////
            /// 




            if (Flag == false)
            {
                ///MessageBox.Show("Incomplete Data", "Fill Required Details",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tb_Result.Visible = false;
            }

            tb_Result.Text = Result;
            tb_Result.Visible = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;


            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_French.Checked = false;
            cb_English.Checked = false;

            for(int i = 0; i< clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            tb_Result.Visible = false;
        }

        private void gbbt_Submit_MouseHover(object sender, EventArgs e)
        {
            btn_Submit.BackColor = Color.Green;
            btn_Submit.ForeColor = Color.Navy;
        }

        private void gbbt_Submit_MouseLeave(object sender, EventArgs e)
        {
            btn_Submit.BackColor = Color.DeepPink;
            btn_Submit.ForeColor = Color.Yellow;
        }

        private void gbbt_Submit_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Submit.BackColor = Color.Red;

        }

        private void gbbt_Submit_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Submit.BackColor = Color.White;
        }

        private void frm_Use_Check_Box_Check_List_BOx_Load(object sender, EventArgs e)
        {

        }

        
    }
}