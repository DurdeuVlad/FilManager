
namespace FilManager
{
    partial class Register
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
            this.button_Register = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Register = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_ConfirmEmail = new System.Windows.Forms.Label();
            this.textBox_ConfirmEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEREGISTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATELASTLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDRECOVERYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Register.Location = new System.Drawing.Point(390, 212);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(111, 43);
            this.button_Register.TabIndex = 13;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Password.Location = new System.Drawing.Point(48, 119);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(91, 25);
            this.label_Password.TabIndex = 12;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(180, 124);
            this.textBox_Password.MaxLength = 100;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(321, 20);
            this.textBox_Password.TabIndex = 11;
            this.textBox_Password.Text = "123456";
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Email.Location = new System.Drawing.Point(62, 56);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(59, 25);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "Email";
            // 
            // label_Register
            // 
            this.label_Register.AutoSize = true;
            this.label_Register.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_Register.Location = new System.Drawing.Point(10, 8);
            this.label_Register.Name = "label_Register";
            this.label_Register.Size = new System.Drawing.Size(129, 40);
            this.label_Register.TabIndex = 9;
            this.label_Register.Text = "Register";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(180, 62);
            this.textBox_Email.MaxLength = 100;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(321, 20);
            this.textBox_Email.TabIndex = 8;
            this.textBox_Email.Text = "da@y.com";
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(10, 190);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 17);
            this.label_Error.TabIndex = 14;
            // 
            // label_ConfirmEmail
            // 
            this.label_ConfirmEmail.AutoSize = true;
            this.label_ConfirmEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_ConfirmEmail.Location = new System.Drawing.Point(26, 87);
            this.label_ConfirmEmail.Name = "label_ConfirmEmail";
            this.label_ConfirmEmail.Size = new System.Drawing.Size(134, 25);
            this.label_ConfirmEmail.TabIndex = 16;
            this.label_ConfirmEmail.Text = "Confirm Email";
            // 
            // textBox_ConfirmEmail
            // 
            this.textBox_ConfirmEmail.Location = new System.Drawing.Point(180, 92);
            this.textBox_ConfirmEmail.MaxLength = 100;
            this.textBox_ConfirmEmail.Name = "textBox_ConfirmEmail";
            this.textBox_ConfirmEmail.Size = new System.Drawing.Size(321, 20);
            this.textBox_ConfirmEmail.TabIndex = 15;
            this.textBox_ConfirmEmail.Text = "da@y.com";
            this.textBox_ConfirmEmail.TextChanged += new System.EventHandler(this.textBox_ConfirmEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Confirm Password";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(180, 155);
            this.textBox_ConfirmPassword.MaxLength = 100;
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.PasswordChar = '*';
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(321, 20);
            this.textBox_ConfirmPassword.TabIndex = 17;
            this.textBox_ConfirmPassword.Text = "123456";
            this.textBox_ConfirmPassword.TextChanged += new System.EventHandler(this.textBox_ConfirmPassword_TextChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            // 
            // dATEREGISTERDataGridViewTextBoxColumn
            // 
            this.dATEREGISTERDataGridViewTextBoxColumn.Name = "dATEREGISTERDataGridViewTextBoxColumn";
            // 
            // dATELASTLOGINDataGridViewTextBoxColumn
            // 
            this.dATELASTLOGINDataGridViewTextBoxColumn.Name = "dATELASTLOGINDataGridViewTextBoxColumn";
            // 
            // pASSWORDRECOVERYDataGridViewTextBoxColumn
            // 
            this.pASSWORDRECOVERYDataGridViewTextBoxColumn.Name = "pASSWORDRECOVERYDataGridViewTextBoxColumn";
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(399, 181);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkBox_ShowPassword.TabIndex = 19;
            this.checkBox_ShowPassword.Text = "Show Password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 264);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.label_ConfirmEmail);
            this.Controls.Add(this.textBox_ConfirmEmail);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Register);
            this.Controls.Add(this.textBox_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Register;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_ConfirmEmail;
        private System.Windows.Forms.TextBox textBox_ConfirmEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEREGISTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATELASTLOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDRECOVERYDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
    }
}