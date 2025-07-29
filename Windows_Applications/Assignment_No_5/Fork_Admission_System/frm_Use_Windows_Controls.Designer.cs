
namespace Fork_Admission_System
{
    partial class frm_Use_Windows_Control
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
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Mornigh = new System.Windows.Forms.RadioButton();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.gb_Gender.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.Ivory;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(362, 37);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(454, 62);
            this.lbl_Employee_Details.TabIndex = 0;
            this.lbl_Employee_Details.Text = "Employee Deatils";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(121, 154);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(263, 40);
            this.lbl_Employee_Name.TabIndex = 1;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(121, 268);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(357, 40);
            this.lbl_Employee_Department.TabIndex = 2;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Gender.Location = new System.Drawing.Point(124, 376);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(127, 40);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Shift_Time.Location = new System.Drawing.Point(121, 487);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(183, 40);
            this.lbl_Shift_Time.TabIndex = 4;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(735, 161);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(424, 40);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Employee_Department_TextChanged);
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "R & D",
            "Finance",
            "IT",
            "Marketing",
            "Human Resources"});
            this.cmb_Department.Location = new System.Drawing.Point(735, 276);
            this.cmb_Department.MaxLength = 15;
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(424, 39);
            this.cmb_Department.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(373, 591);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(168, 57);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(667, 591);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(168, 57);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Sumbit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Output.Location = new System.Drawing.Point(62, 679);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(128, 41);
            this.lbl_Output.TabIndex = 9;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(196, 684);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(987, 36);
            this.tb_Output.TabIndex = 11;
            // 
            // gb_Gender
            // 
            this.gb_Gender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_Gender.BackColor = System.Drawing.Color.Beige;
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Location = new System.Drawing.Point(735, 376);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(424, 66);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.Color.Black;
            this.rb_Male.Location = new System.Drawing.Point(58, 21);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(65, 24);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.Color.Black;
            this.rb_Female.Location = new System.Drawing.Point(238, 21);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(81, 24);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = false;
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_Shift_Time.BackColor = System.Drawing.Color.Beige;
            this.gb_Shift_Time.Controls.Add(this.rb_Evening);
            this.gb_Shift_Time.Controls.Add(this.rb_Mornigh);
            this.gb_Shift_Time.Controls.Add(this.rb_Night);
            this.gb_Shift_Time.Location = new System.Drawing.Point(735, 481);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(424, 71);
            this.gb_Shift_Time.TabIndex = 5;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Shift Time";
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.ForeColor = System.Drawing.Color.Black;
            this.rb_Evening.Location = new System.Drawing.Point(177, 31);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(86, 24);
            this.rb_Evening.TabIndex = 7;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Mornigh
            // 
            this.rb_Mornigh.AutoSize = true;
            this.rb_Mornigh.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Mornigh.ForeColor = System.Drawing.Color.Black;
            this.rb_Mornigh.Location = new System.Drawing.Point(33, 31);
            this.rb_Mornigh.Name = "rb_Mornigh";
            this.rb_Mornigh.Size = new System.Drawing.Size(90, 24);
            this.rb_Mornigh.TabIndex = 6;
            this.rb_Mornigh.Text = "Mornigh";
            this.rb_Mornigh.UseVisualStyleBackColor = true;
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.ForeColor = System.Drawing.Color.Black;
            this.rb_Night.Location = new System.Drawing.Point(317, 31);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(68, 24);
            this.rb_Night.TabIndex = 8;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // frm_Use_Windows_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1210, 746);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Employee_Details);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Use_Windows_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use Windows Control";
            this.Load += new System.EventHandler(this.frm_Use_Windows_Control_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Mornigh;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
    }
}

