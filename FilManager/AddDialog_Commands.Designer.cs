namespace FilManager
{
    partial class AddDialog_Commands
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel_Template = new System.Windows.Forms.Panel();
            this.label_generated_code = new System.Windows.Forms.Label();
            this.textBox_clientID = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.checkBox_wasprinted = new System.Windows.Forms.CheckBox();
            this.checkBox_wassent = new System.Windows.Forms.CheckBox();
            this.checkBox_wasreceived = new System.Windows.Forms.CheckBox();
            this.textBox_pricepaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_pricegrams = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_priceindrects = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_pricetax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Template.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.button_cancel.Location = new System.Drawing.Point(1000, 120);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(245, 80);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.Green;
            this.button_add.Location = new System.Drawing.Point(14, 115);
            this.button_add.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(169, 80);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // panel_Template
            // 
            this.panel_Template.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Template.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Template.Controls.Add(this.textBox_pricetax);
            this.panel_Template.Controls.Add(this.label7);
            this.panel_Template.Controls.Add(this.textBox_priceindrects);
            this.panel_Template.Controls.Add(this.label6);
            this.panel_Template.Controls.Add(this.textBox_pricegrams);
            this.panel_Template.Controls.Add(this.label5);
            this.panel_Template.Controls.Add(this.textBox_pricepaid);
            this.panel_Template.Controls.Add(this.label4);
            this.panel_Template.Controls.Add(this.checkBox_wasreceived);
            this.panel_Template.Controls.Add(this.checkBox_wassent);
            this.panel_Template.Controls.Add(this.checkBox_wasprinted);
            this.panel_Template.Controls.Add(this.label_generated_code);
            this.panel_Template.Controls.Add(this.textBox_clientID);
            this.panel_Template.Controls.Add(this.label_id);
            this.panel_Template.Location = new System.Drawing.Point(14, 8);
            this.panel_Template.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.panel_Template.Name = "panel_Template";
            this.panel_Template.Size = new System.Drawing.Size(1240, 93);
            this.panel_Template.TabIndex = 6;
            // 
            // label_generated_code
            // 
            this.label_generated_code.AutoSize = true;
            this.label_generated_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_generated_code.Location = new System.Drawing.Point(1219, 80);
            this.label_generated_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_generated_code.Name = "label_generated_code";
            this.label_generated_code.Size = new System.Drawing.Size(0, 25);
            this.label_generated_code.TabIndex = 13;
            this.label_generated_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_clientID
            // 
            this.textBox_clientID.Location = new System.Drawing.Point(10, 44);
            this.textBox_clientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_clientID.MaxLength = 10;
            this.textBox_clientID.Name = "textBox_clientID";
            this.textBox_clientID.ReadOnly = true;
            this.textBox_clientID.Size = new System.Drawing.Size(108, 28);
            this.textBox_clientID.TabIndex = 1;
            this.textBox_clientID.Text = "Black";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(19, 14);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(79, 24);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Client ID";
            // 
            // checkBox_wasprinted
            // 
            this.checkBox_wasprinted.AutoSize = true;
            this.checkBox_wasprinted.Location = new System.Drawing.Point(128, 45);
            this.checkBox_wasprinted.Name = "checkBox_wasprinted";
            this.checkBox_wasprinted.Size = new System.Drawing.Size(143, 28);
            this.checkBox_wasprinted.TabIndex = 22;
            this.checkBox_wasprinted.Text = "Was Printed?";
            this.checkBox_wasprinted.UseVisualStyleBackColor = true;
            // 
            // checkBox_wassent
            // 
            this.checkBox_wassent.AutoSize = true;
            this.checkBox_wassent.Location = new System.Drawing.Point(277, 45);
            this.checkBox_wassent.Name = "checkBox_wassent";
            this.checkBox_wassent.Size = new System.Drawing.Size(122, 28);
            this.checkBox_wassent.TabIndex = 23;
            this.checkBox_wassent.Text = "Was Sent?";
            this.checkBox_wassent.UseVisualStyleBackColor = true;
            // 
            // checkBox_wasreceived
            // 
            this.checkBox_wasreceived.AutoSize = true;
            this.checkBox_wasreceived.Location = new System.Drawing.Point(405, 45);
            this.checkBox_wasreceived.Name = "checkBox_wasreceived";
            this.checkBox_wasreceived.Size = new System.Drawing.Size(164, 28);
            this.checkBox_wasreceived.TabIndex = 24;
            this.checkBox_wasreceived.Text = "Was Received?";
            this.checkBox_wasreceived.UseVisualStyleBackColor = true;
            // 
            // textBox_pricepaid
            // 
            this.textBox_pricepaid.Location = new System.Drawing.Point(570, 44);
            this.textBox_pricepaid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pricepaid.MaxLength = 10;
            this.textBox_pricepaid.Name = "textBox_pricepaid";
            this.textBox_pricepaid.Size = new System.Drawing.Size(122, 28);
            this.textBox_pricepaid.TabIndex = 26;
            this.textBox_pricepaid.Text = "100";
            this.textBox_pricepaid.AcceptsTabChanged += new System.EventHandler(this.TextBox_pricepaid_AcceptsTabChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price Paid";
            // 
            // textBox_pricegrams
            // 
            this.textBox_pricegrams.Location = new System.Drawing.Point(701, 44);
            this.textBox_pricegrams.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pricegrams.MaxLength = 10;
            this.textBox_pricegrams.Name = "textBox_pricegrams";
            this.textBox_pricegrams.Size = new System.Drawing.Size(129, 28);
            this.textBox_pricegrams.TabIndex = 28;
            this.textBox_pricegrams.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Price Grams";
            // 
            // textBox_priceindrects
            // 
            this.textBox_priceindrects.Location = new System.Drawing.Point(835, 44);
            this.textBox_priceindrects.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_priceindrects.MaxLength = 10;
            this.textBox_priceindrects.Name = "textBox_priceindrects";
            this.textBox_priceindrects.Size = new System.Drawing.Size(186, 28);
            this.textBox_priceindrects.TabIndex = 30;
            this.textBox_priceindrects.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(855, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Price Indirects%";
            // 
            // textBox_pricetax
            // 
            this.textBox_pricetax.Location = new System.Drawing.Point(1029, 44);
            this.textBox_pricetax.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pricetax.MaxLength = 10;
            this.textBox_pricetax.Name = "textBox_pricetax";
            this.textBox_pricetax.Size = new System.Drawing.Size(162, 28);
            this.textBox_pricetax.TabIndex = 32;
            this.textBox_pricetax.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1057, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price Tax%";
            // 
            // AddDialog_Commands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 216);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_Template);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDialog_Commands";
            this.Text = "AddDialog_Commands";
            this.Load += new System.EventHandler(this.AddDialog_Commands_Load);
            this.panel_Template.ResumeLayout(false);
            this.panel_Template.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_Template;
        private System.Windows.Forms.Label label_generated_code;
        private System.Windows.Forms.TextBox textBox_clientID;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_pricetax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_priceindrects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_pricegrams;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_pricepaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_wasreceived;
        private System.Windows.Forms.CheckBox checkBox_wassent;
        private System.Windows.Forms.CheckBox checkBox_wasprinted;
    }
}