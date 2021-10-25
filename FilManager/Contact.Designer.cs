
namespace FilManager
{
    partial class Contact
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
            this.textBox_YourMessage = new System.Windows.Forms.TextBox();
            this.label_YourMessage = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SendEmail = new System.Windows.Forms.Button();
            this.label_Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_YourMessage
            // 
            this.textBox_YourMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_YourMessage.Location = new System.Drawing.Point(12, 92);
            this.textBox_YourMessage.Multiline = true;
            this.textBox_YourMessage.Name = "textBox_YourMessage";
            this.textBox_YourMessage.Size = new System.Drawing.Size(402, 338);
            this.textBox_YourMessage.TabIndex = 3;
            // 
            // label_YourMessage
            // 
            this.label_YourMessage.AutoSize = true;
            this.label_YourMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_YourMessage.Location = new System.Drawing.Point(12, 58);
            this.label_YourMessage.Name = "label_YourMessage";
            this.label_YourMessage.Size = new System.Drawing.Size(209, 31);
            this.label_YourMessage.TabIndex = 2;
            this.label_YourMessage.Text = "Your message:";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(99, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(224, 42);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "Contact Us!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "We will contact you back via email.";
            // 
            // button_SendEmail
            // 
            this.button_SendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_SendEmail.Location = new System.Drawing.Point(277, 446);
            this.button_SendEmail.Name = "button_SendEmail";
            this.button_SendEmail.Size = new System.Drawing.Size(137, 42);
            this.button_SendEmail.TabIndex = 6;
            this.button_SendEmail.Text = "Send!";
            this.button_SendEmail.UseVisualStyleBackColor = true;
            this.button_SendEmail.Click += new System.EventHandler(this.button_SendEmail_Click);
            // 
            // label_Feedback
            // 
            this.label_Feedback.AutoSize = true;
            this.label_Feedback.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Feedback.Location = new System.Drawing.Point(15, 457);
            this.label_Feedback.Name = "label_Feedback";
            this.label_Feedback.Size = new System.Drawing.Size(0, 13);
            this.label_Feedback.TabIndex = 7;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 500);
            this.Controls.Add(this.label_Feedback);
            this.Controls.Add(this.button_SendEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.textBox_YourMessage);
            this.Controls.Add(this.label_YourMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_YourMessage;
        private System.Windows.Forms.Label label_YourMessage;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SendEmail;
        private System.Windows.Forms.Label label_Feedback;
    }
}