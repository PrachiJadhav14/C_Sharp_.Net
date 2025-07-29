
namespace Fork_Admission_System
{
    partial class frm_Login
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
            System.Windows.Forms.Label lbl_Login_Form;
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            lbl_Login_Form = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            lbl_Login_Form.AutoSize = true;
            lbl_Login_Form.BackColor = System.Drawing.Color.LightSteelBlue;
            lbl_Login_Form.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Login_Form.ForeColor = System.Drawing.Color.MidnightBlue;
            lbl_Login_Form.Location = new System.Drawing.Point(307, 49);
            lbl_Login_Form.Name = "lbl_Login_Form";
            lbl_Login_Form.Size = new System.Drawing.Size(321, 62);
            lbl_Login_Form.TabIndex = 0;
            lbl_Login_Form.Text = "Login Form";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_UserName.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(124, 185);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(185, 41);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "UserName";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(124, 347);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(171, 41);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(358, 532);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(218, 50);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(573, 192);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_UserName.MaxLength = 20;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(340, 34);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.TextChanged += new System.EventHandler(this.tb_UserName_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(573, 354);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '$';
            this.tb_Password.Size = new System.Drawing.Size(340, 34);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Error.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(329, 470);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(285, 20);
            this.lbl_Error.TabIndex = 4;
            this.lbl_Error.Text = "Note : Enter Your Username & Password";
            this.lbl_Error.Visible = false;

            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(977, 617);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(lbl_Login_Form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Error;
    }
}

