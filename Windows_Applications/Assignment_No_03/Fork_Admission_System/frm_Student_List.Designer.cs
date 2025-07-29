
namespace Fork_Admission_System
{
    partial class frm_Student_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_Student_List;
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Addmission_SystemDataSet = new Fork_Admission_System.Fork_Addmission_SystemDataSet();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Logged_In_User = new System.Windows.Forms.Label();
            this.lbl_Logout = new System.Windows.Forms.Button();
            this.btn_Add_Student_Details = new System.Windows.Forms.Button();
            this.student_ListTableAdapter = new Fork_Admission_System.Fork_Addmission_SystemDataSetTableAdapters.Student_ListTableAdapter();
            lbl_Student_List = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Student_List
            // 
            lbl_Student_List.AutoSize = true;
            lbl_Student_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lbl_Student_List.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Student_List.ForeColor = System.Drawing.Color.DarkMagenta;
            lbl_Student_List.Location = new System.Drawing.Point(431, 29);
            lbl_Student_List.Name = "lbl_Student_List";
            lbl_Student_List.Size = new System.Drawing.Size(263, 50);
            lbl_Student_List.TabIndex = 0;
            lbl_Student_List.Text = "Student List";
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentListBindingSource;
            this.dgv_Student_List.Location = new System.Drawing.Point(25, 130);
            this.dgv_Student_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowHeadersWidth = 62;
            this.dgv_Student_List.RowTemplate.Height = 28;
            this.dgv_Student_List.Size = new System.Drawing.Size(1137, 458);
            this.dgv_Student_List.TabIndex = 0;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataMember = "Student_List";
            this.studentListBindingSource.DataSource = this.fork_Addmission_SystemDataSet;
            // 
            // fork_Addmission_SystemDataSet
            // 
            this.fork_Addmission_SystemDataSet.DataSetName = "Fork_Addmission_SystemDataSet";
            this.fork_Addmission_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Header.Controls.Add(this.lbl_Logged_In_User);
            this.pnl_Header.Controls.Add(lbl_Student_List);
            this.pnl_Header.Controls.Add(this.lbl_Logout);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1201, 97);
            this.pnl_Header.TabIndex = 7;
            // 
            // lbl_Logged_In_User
            // 
            this.lbl_Logged_In_User.AutoSize = true;
            this.lbl_Logged_In_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Logged_In_User.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_User.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Logged_In_User.Location = new System.Drawing.Point(21, 24);
            this.lbl_Logged_In_User.Name = "lbl_Logged_In_User";
            this.lbl_Logged_In_User.Size = new System.Drawing.Size(87, 20);
            this.lbl_Logged_In_User.TabIndex = 13;
            this.lbl_Logged_In_User.Text = "Login User";
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Logout.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.Red;
            this.lbl_Logout.Location = new System.Drawing.Point(1026, 24);
            this.lbl_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(145, 53);
            this.lbl_Logout.TabIndex = 2;
            this.lbl_Logout.Text = "Logout";
            this.lbl_Logout.UseVisualStyleBackColor = false;
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // btn_Add_Student_Details
            // 
            this.btn_Add_Student_Details.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Add_Student_Details.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student_Details.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Student_Details.Location = new System.Drawing.Point(395, 609);
            this.btn_Add_Student_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Student_Details.Name = "btn_Add_Student_Details";
            this.btn_Add_Student_Details.Size = new System.Drawing.Size(277, 64);
            this.btn_Add_Student_Details.TabIndex = 1;
            this.btn_Add_Student_Details.Text = "Add Student Details";
            this.btn_Add_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Student_Details.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 706);
            this.Controls.Add(this.btn_Add_Student_Details);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.dgv_Student_List);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Student_List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Logged_In_User;
        private System.Windows.Forms.Button lbl_Logout;
        public System.Windows.Forms.Button btn_Add_Student_Details;
        private Fork_Addmission_SystemDataSet fork_Addmission_SystemDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private Fork_Addmission_SystemDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}