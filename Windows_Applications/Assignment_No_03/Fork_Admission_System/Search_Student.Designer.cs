
namespace Fork_Admission_System
{
    partial class frm_Search_Student
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
            System.Windows.Forms.Label lbl_Search_Student;
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Logged_In_User = new System.Windows.Forms.Label();
            this.lbl_Logout = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            lbl_Search_Student = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Search_Student
            // 
            lbl_Search_Student.AutoSize = true;
            lbl_Search_Student.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lbl_Search_Student.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Search_Student.ForeColor = System.Drawing.Color.DarkMagenta;
            lbl_Search_Student.Location = new System.Drawing.Point(398, 29);
            lbl_Search_Student.Name = "lbl_Search_Student";
            lbl_Search_Student.Size = new System.Drawing.Size(314, 50);
            lbl_Search_Student.TabIndex = 0;
            lbl_Search_Student.Text = "Search Student";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Header.Controls.Add(this.lbl_Logged_In_User);
            this.pnl_Header.Controls.Add(lbl_Search_Student);
            this.pnl_Header.Controls.Add(this.lbl_Logout);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1158, 101);
            this.pnl_Header.TabIndex = 7;
            // 
            // lbl_Logged_In_User
            // 
            this.lbl_Logged_In_User.AutoSize = true;
            this.lbl_Logged_In_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Logged_In_User.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_User.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Logged_In_User.Location = new System.Drawing.Point(20, 29);
            this.lbl_Logged_In_User.Name = "lbl_Logged_In_User";
            this.lbl_Logged_In_User.Size = new System.Drawing.Size(87, 20);
            this.lbl_Logged_In_User.TabIndex = 12;
            this.lbl_Logged_In_User.Text = "Login User";
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Logout.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.Red;
            this.lbl_Logout.Location = new System.Drawing.Point(945, 29);
            this.lbl_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(139, 44);
            this.lbl_Logout.TabIndex = 11;
            this.lbl_Logout.Text = "Logout";
            this.lbl_Logout.UseVisualStyleBackColor = false;
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Enabled = false;
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
            this.cmb_Course.Location = new System.Drawing.Point(509, 463);
            this.cmb_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(405, 37);
            this.cmb_Course.TabIndex = 5;

            this.cmb_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Enabled = false;
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(509, 300);
            this.dtp_Date_Of_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(405, 36);
            this.dtp_Date_Of_Birth.TabIndex = 3;
          
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(509, 384);
            this.tb_Mob_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(405, 36);
            this.tb_Mob_No.TabIndex = 4;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(509, 219);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(405, 36);
            this.tb_Name.TabIndex = 2;

            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(509, 146);
            this.tb_Roll_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(405, 36);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course.Location = new System.Drawing.Point(111, 463);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(118, 40);
            this.lbl_Course.TabIndex = 17;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mob_No.Location = new System.Drawing.Point(111, 384);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(137, 40);
            this.lbl_Mob_No.TabIndex = 15;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(111, 304);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(232, 40);
            this.lbl_Date_Of_Birth.TabIndex = 13;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Roll_No.Location = new System.Drawing.Point(111, 146);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(145, 40);
            this.lbl_Roll_No.TabIndex = 11;
            this.lbl_Roll_No.Text = "Roll No ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(111, 219);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(105, 40);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(35, 586);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(214, 63);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Update_Student.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Update_Student.Location = new System.Drawing.Point(572, 586);
            this.btn_Update_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(230, 64);
            this.btn_Update_Student.TabIndex = 9;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Student_List.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.Red;
            this.btn_Student_List.Location = new System.Drawing.Point(862, 586);
            this.btn_Student_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(230, 63);
            this.btn_Student_List.TabIndex = 10;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Add_Student.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Student.Location = new System.Drawing.Point(295, 585);
            this.btn_Add_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(230, 64);
            this.btn_Add_Student.TabIndex = 8;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(989, 136);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 46);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1158, 706);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Update_Student);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pnl_Header);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Student";
            this.Load += new System.EventHandler(this.frm_Search_Student_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button lbl_Logout;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update_Student;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Label lbl_Logged_In_User;
        private System.Windows.Forms.Button btn_Search;
    }
}