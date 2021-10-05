
namespace FilManager
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.bindingSource_Login = new System.Windows.Forms.BindingSource(this.components);
            this.userListDataSet_Login = new FilManager.userListDataSet();
            this.linkLabel_Recovery = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListDataSet_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(105, 62);
            this.textBox_Email.MaxLength = 100;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(347, 20);
            this.textBox_Email.TabIndex = 0;
            this.textBox_Email.Text = "da@y.com";
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_Login.Location = new System.Drawing.Point(10, 8);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(94, 40);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Login";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Email.Location = new System.Drawing.Point(24, 60);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(59, 25);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Password.Location = new System.Drawing.Point(8, 90);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(91, 25);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(105, 95);
            this.textBox_Password.MaxLength = 100;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(347, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.Text = "123456";
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(10, 155);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 17);
            this.label_Error.TabIndex = 5;
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_Login.Location = new System.Drawing.Point(365, 130);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(87, 61);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Register.Location = new System.Drawing.Point(260, 130);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(99, 61);
            this.button_Register.TabIndex = 7;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // bindingSource_Login
            // 
            this.bindingSource_Login.DataSource = this.userListDataSet_Login;
            this.bindingSource_Login.Position = 0;
            // 
            // userListDataSet_Login
            // 
            this.userListDataSet_Login.DataSetName = "userListDataSet";
            this.userListDataSet_Login.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkLabel_Recovery
            // 
            this.linkLabel_Recovery.AutoSize = true;
            this.linkLabel_Recovery.Location = new System.Drawing.Point(10, 130);
            this.linkLabel_Recovery.Name = "linkLabel_Recovery";
            this.linkLabel_Recovery.Size = new System.Drawing.Size(102, 13);
            this.linkLabel_Recovery.TabIndex = 8;
            this.linkLabel_Recovery.TabStop = true;
            this.linkLabel_Recovery.Text = "Password Recovery";
            this.linkLabel_Recovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Recovery_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 203);
            this.Controls.Add(this.linkLabel_Recovery);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.Login_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListDataSet_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Register;
        private userListDataSet userListDataSet;
        private System.Windows.Forms.BindingSource bindingSource_Login;
        private userListDataSet userListDataSet_Login;
        private System.Windows.Forms.LinkLabel linkLabel_Recovery;
    }
}

