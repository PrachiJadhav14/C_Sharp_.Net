
namespace Fork_Addmission_System
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
            this.lbl_Student_List = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.studentListBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Addmission_SystemDataSet3 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet3();
            this.studentListBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Addmission_SystemDataSet2 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet2();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Addmission_SystemDataSet = new Fork_Addmission_System.Fork_Addmission_SystemDataSet();
            this.student_ListTableAdapter = new Fork_Addmission_System.Fork_Addmission_SystemDataSetTableAdapters.Student_ListTableAdapter();
            this.btn_Add_Student_Details = new System.Windows.Forms.Button();
            this.fork_Addmission_SystemDataSet1 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet1();
            this.studentListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter1 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet1TableAdapters.Student_ListTableAdapter();
            this.student_ListTableAdapter2 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet2TableAdapters.Student_ListTableAdapter();
            this.student_ListTableAdapter3 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet3TableAdapters.Student_ListTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fork_Addmission_SystemDataSet4 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet4();
            this.studentListBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter4 = new Fork_Addmission_System.Fork_Addmission_SystemDataSet4TableAdapters.Student_ListTableAdapter();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.AutoSize = true;
            this.lbl_Student_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_Student_List.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_List.Location = new System.Drawing.Point(260, 20);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(263, 50);
            this.lbl_Student_List.TabIndex = 0;
            this.lbl_Student_List.Text = "Student List";
            this.lbl_Student_List.Click += new System.EventHandler(this.lbl_Student_List_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Azure;
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Student_List);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(796, 76);
            this.pnl_Header.TabIndex = 1;
            this.pnl_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Logout.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(611, 20);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(114, 39);
            this.btn_Logout.TabIndex = 10;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Student_List.DataSource = this.studentListBindingSource5;
            this.dgv_Student_List.Location = new System.Drawing.Point(12, 101);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowHeadersWidth = 62;
            this.dgv_Student_List.RowTemplate.Height = 28;
            this.dgv_Student_List.Size = new System.Drawing.Size(748, 307);
            this.dgv_Student_List.TabIndex = 2;
            // 
            // studentListBindingSource4
            // 
            this.studentListBindingSource4.DataMember = "Student_List";
            this.studentListBindingSource4.DataSource = this.fork_Addmission_SystemDataSet3;
            // 
            // fork_Addmission_SystemDataSet3
            // 
            this.fork_Addmission_SystemDataSet3.DataSetName = "Fork_Addmission_SystemDataSet3";
            this.fork_Addmission_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource3
            // 
            this.studentListBindingSource3.DataMember = "Student_List";
            // 
            // studentListBindingSource2
            // 
            this.studentListBindingSource2.DataMember = "Student_List";
            this.studentListBindingSource2.DataSource = this.fork_Addmission_SystemDataSet2;
            // 
            // fork_Addmission_SystemDataSet2
            // 
            this.fork_Addmission_SystemDataSet2.DataSetName = "Fork_Addmission_SystemDataSet2";
            this.fork_Addmission_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add_Student_Details
            // 
            this.btn_Add_Student_Details.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Add_Student_Details.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student_Details.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Student_Details.Location = new System.Drawing.Point(244, 422);
            this.btn_Add_Student_Details.Name = "btn_Add_Student_Details";
            this.btn_Add_Student_Details.Size = new System.Drawing.Size(252, 46);
            this.btn_Add_Student_Details.TabIndex = 1;
            this.btn_Add_Student_Details.Text = "Add Student Details";
            this.btn_Add_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Student_Details.Click += new System.EventHandler(this.btn_Add_Student_Details_Click);
            // 
            // fork_Addmission_SystemDataSet1
            // 
            this.fork_Addmission_SystemDataSet1.DataSetName = "Fork_Addmission_SystemDataSet1";
            this.fork_Addmission_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource1
            // 
            this.studentListBindingSource1.DataMember = "Student_List";
            this.studentListBindingSource1.DataSource = this.fork_Addmission_SystemDataSet1;
            // 
            // student_ListTableAdapter1
            // 
            this.student_ListTableAdapter1.ClearBeforeFill = true;
            // 
            // student_ListTableAdapter2
            // 
            this.student_ListTableAdapter2.ClearBeforeFill = true;
            // 
            // student_ListTableAdapter3
            // 
            this.student_ListTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roll_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Roll_No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn3.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mob_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mob_No";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn5.HeaderText = "Course";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // fork_Addmission_SystemDataSet4
            // 
            this.fork_Addmission_SystemDataSet4.DataSetName = "Fork_Addmission_SystemDataSet4";
            this.fork_Addmission_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource5
            // 
            this.studentListBindingSource5.DataMember = "Student_List";
            this.studentListBindingSource5.DataSource = this.fork_Addmission_SystemDataSet4;
            // 
            // student_ListTableAdapter4
            // 
            this.student_ListTableAdapter4.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(796, 508);
            this.Controls.Add(this.btn_Add_Student_Details);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.pnl_Header);
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Student_List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmission_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Student_List;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private Fork_Addmission_SystemDataSet fork_Addmission_SystemDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private Fork_Addmission_SystemDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private System.Windows.Forms.Button btn_Add_Student_Details;
        private System.Windows.Forms.Button btn_Logout;
        private Fork_Addmission_SystemDataSet1 fork_Addmission_SystemDataSet1;
        private System.Windows.Forms.BindingSource studentListBindingSource1;
        private Fork_Addmission_SystemDataSet1TableAdapters.Student_ListTableAdapter student_ListTableAdapter1;
        private Fork_Addmission_SystemDataSet2 fork_Addmission_SystemDataSet2;
        private System.Windows.Forms.BindingSource studentListBindingSource2;
        private Fork_Addmission_SystemDataSet2TableAdapters.Student_ListTableAdapter student_ListTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;

        private System.Windows.Forms.BindingSource studentListBindingSource3;
        private Fork_Addmission_SystemDataSet3 fork_Addmission_SystemDataSet3;
        private System.Windows.Forms.BindingSource studentListBindingSource4;
        private Fork_Addmission_SystemDataSet3TableAdapters.Student_ListTableAdapter student_ListTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Fork_Addmission_SystemDataSet4 fork_Addmission_SystemDataSet4;
        private System.Windows.Forms.BindingSource studentListBindingSource5;
        private Fork_Addmission_SystemDataSet4TableAdapters.Student_ListTableAdapter student_ListTableAdapter4;
    }
}