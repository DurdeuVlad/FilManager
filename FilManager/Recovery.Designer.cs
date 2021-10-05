
namespace FilManager
{
    partial class Recovery
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
            this.button_SendEmail = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_AccountRecovery = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_SendEmail
            // 
            this.button_SendEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_SendEmail.Location = new System.Drawing.Point(243, 95);
            this.button_SendEmail.Name = "button_SendEmail";
            this.button_SendEmail.Size = new System.Drawing.Size(136, 43);
            this.button_SendEmail.TabIndex = 10;
            this.button_SendEmail.Text = "Send Email";
            this.button_SendEmail.UseVisualStyleBackColor = true;
            this.button_SendEmail.Click += new System.EventHandler(this.button_SendEmail_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Email.Location = new System.Drawing.Point(14, 64);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(59, 25);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "Email";
            // 
            // label_AccountRecovery
            // 
            this.label_AccountRecovery.AutoSize = true;
            this.label_AccountRecovery.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_AccountRecovery.Location = new System.Drawing.Point(12, 9);
            this.label_AccountRecovery.Name = "label_AccountRecovery";
            this.label_AccountRecovery.Size = new System.Drawing.Size(265, 40);
            this.label_AccountRecovery.TabIndex = 8;
            this.label_AccountRecovery.Text = "Account Recovery";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(79, 69);
            this.textBox_Email.MaxLength = 100;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(217, 20);
            this.textBox_Email.TabIndex = 7;
            this.textBox_Email.Text = "da@y.com";
            // 
            // label_Feedback
            // 
            this.label_Feedback.AutoSize = true;
            this.label_Feedback.BackColor = System.Drawing.Color.Transparent;
            this.label_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Feedback.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Feedback.Location = new System.Drawing.Point(12, 103);
            this.label_Feedback.Name = "label_Feedback";
            this.label_Feedback.Size = new System.Drawing.Size(0, 16);
            this.label_Feedback.TabIndex = 11;
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 148);
            this.Controls.Add(this.label_Feedback);
            this.Controls.Add(this.button_SendEmail);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_AccountRecovery);
            this.Controls.Add(this.textBox_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Recovery";
            this.Text = "Account recovery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recovery_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SendEmail;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_AccountRecovery;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Feedback;
    }
}