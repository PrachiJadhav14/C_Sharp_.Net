
namespace Fork_Admission_System
{
    partial class frm_Add_Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbl_Add_Student_Details;
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Logged_In_User = new System.Windows.Forms.Label();
            this.lbl_Logout = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search_Student = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            lbl_Add_Student_Details = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Student_Details
            // 
            lbl_Add_Student_Details.AutoSize = true;
            lbl_Add_Student_Details.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lbl_Add_Student_Details.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Add_Student_Details.ForeColor = System.Drawing.Color.DarkMagenta;
            lbl_Add_Student_Details.Location = new System.Drawing.Point(373, 33);
            lbl_Add_Student_Details.Name = "lbl_Add_Student_Details";
            lbl_Add_Student_Details.Size = new System.Drawing.Size(414, 50);
            lbl_Add_Student_Details.TabIndex = 0;
            lbl_Add_Student_Details.Text = "Add Student Details";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(169, 232);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(105, 40);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Roll_No.Location = new System.Drawing.Point(169, 156);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(145, 40);
            this.lbl_Roll_No.TabIndex = 2;
            this.lbl_Roll_No.Text = "Roll No ";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(169, 315);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(232, 40);
            this.lbl_Date_Of_Birth.TabIndex = 3;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mob_No.Location = new System.Drawing.Point(169, 397);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(137, 40);
            this.lbl_Mob_No.TabIndex = 4;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course.Location = new System.Drawing.Point(169, 476);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(118, 40);
            this.lbl_Course.TabIndex = 5;
            this.lbl_Course.Text = "Course";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Header.Controls.Add(this.lbl_Logged_In_User);
            this.pnl_Header.Controls.Add(lbl_Add_Student_Details);
            this.pnl_Header.Controls.Add(this.lbl_Logout);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1200, 108);
            this.pnl_Header.TabIndex = 20;
            // 
            // lbl_Logged_In_User
            // 
            this.lbl_Logged_In_User.AutoSize = true;
            this.lbl_Logged_In_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Logged_In_User.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_User.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Logged_In_User.Location = new System.Drawing.Point(33, 28);
            this.lbl_Logged_In_User.Name = "lbl_Logged_In_User";
            this.lbl_Logged_In_User.Size = new System.Drawing.Size(87, 20);
            this.lbl_Logged_In_User.TabIndex = 13;
            this.lbl_Logged_In_User.Text = "Login User";
            this.lbl_Logged_In_User.Click += new System.EventHandler(this.lbl_Logged_In_User_Click);
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Logout.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.Red;
            this.lbl_Logout.Location = new System.Drawing.Point(982, 28);
            this.lbl_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(139, 55);
            this.lbl_Logout.TabIndex = 11;
            this.lbl_Logout.Text = "Logout";
            this.lbl_Logout.UseVisualStyleBackColor = false;
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(41, 597);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(166, 61);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search_Student
            // 
            this.btn_Search_Student.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Search_Student.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Search_Student.Location = new System.Drawing.Point(690, 597);
            this.btn_Search_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search_Student.Name = "btn_Search_Student";
            this.btn_Search_Student.Size = new System.Drawing.Size(218, 59);
            this.btn_Search_Student.TabIndex = 10;
            this.btn_Search_Student.Text = "Search Student";
            this.btn_Search_Student.UseVisualStyleBackColor = false;
            this.btn_Search_Student.Click += new System.EventHandler(this.btn_Search_Student_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Update_Student.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Update_Student.Location = new System.Drawing.Point(446, 599);
            this.btn_Update_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(216, 59);
            this.btn_Update_Student.TabIndex = 8;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(239, 599);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(162, 57);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Student_List.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.Red;
            this.btn_Student_List.Location = new System.Drawing.Point(937, 599);
            this.btn_Student_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(189, 57);
            this.btn_Student_List.TabIndex = 9;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(582, 160);
            this.tb_Roll_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(387, 36);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(582, 236);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(387, 36);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(582, 397);
            this.tb_Mob_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(387, 36);
            this.tb_Mob_No.TabIndex = 4;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(582, 315);
            this.dtp_Date_Of_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(387, 36);
            this.dtp_Date_Of_Birth.TabIndex = 3;
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "MSC(CS)",
            "BCOM(IT)",
            "BSC(CS)",
            "BCS(CS)",
            "MSA",
            "BCA",
            "BCS"});
            this.cmb_Course.Location = new System.Drawing.Point(582, 476);
            this.cmb_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(387, 37);
            this.cmb_Course.TabIndex = 5;
            this.cmb_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // frm_Add_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1200, 706);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Update_Student);
            this.Controls.Add(this.btn_Search_Student);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Name);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Details";
            this.Load += new System.EventHandler(this.frm_Add_Student_Details_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button lbl_Logout;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search_Student;
        private System.Windows.Forms.Button btn_Update_Student;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label lbl_Logged_In_User;
    }
}