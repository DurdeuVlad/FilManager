namespace FilManager
{
    partial class AddDialog_Prints
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
            this.checkBox_wasSuccessful = new System.Windows.Forms.CheckBox();
            this.listBox_filamentId = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_printerId = new System.Windows.Forms.ListBox();
            this.listBox_commandId = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.textBox_GramsUsed = new System.Windows.Forms.TextBox();
            this.label_dateBought = new System.Windows.Forms.Label();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_Template.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.button_cancel.Location = new System.Drawing.Point(1012, 135);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(205, 58);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.Green;
            this.button_add.Location = new System.Drawing.Point(13, 135);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(135, 58);
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
            this.panel_Template.Controls.Add(this.checkBox_wasSuccessful);
            this.panel_Template.Controls.Add(this.listBox_filamentId);
            this.panel_Template.Controls.Add(this.label6);
            this.panel_Template.Controls.Add(this.listBox_printerId);
            this.panel_Template.Controls.Add(this.listBox_commandId);
            this.panel_Template.Controls.Add(this.label3);
            this.panel_Template.Controls.Add(this.label1);
            this.panel_Template.Controls.Add(this.label2);
            this.panel_Template.Controls.Add(this.label8);
            this.panel_Template.Controls.Add(this.comboBox_year);
            this.panel_Template.Controls.Add(this.comboBox_day);
            this.panel_Template.Controls.Add(this.textBox_GramsUsed);
            this.panel_Template.Controls.Add(this.label_dateBought);
            this.panel_Template.Controls.Add(this.comboBox_month);
            this.panel_Template.Controls.Add(this.label4);
            this.panel_Template.Controls.Add(this.label_id);
            this.panel_Template.Location = new System.Drawing.Point(13, 14);
            this.panel_Template.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Template.Name = "panel_Template";
            this.panel_Template.Size = new System.Drawing.Size(1204, 111);
            this.panel_Template.TabIndex = 6;
            // 
            // checkBox_wasSuccessful
            // 
            this.checkBox_wasSuccessful.AutoSize = true;
            this.checkBox_wasSuccessful.Location = new System.Drawing.Point(602, 49);
            this.checkBox_wasSuccessful.Name = "checkBox_wasSuccessful";
            this.checkBox_wasSuccessful.Size = new System.Drawing.Size(183, 29);
            this.checkBox_wasSuccessful.TabIndex = 71;
            this.checkBox_wasSuccessful.Text = "Was successful?";
            this.checkBox_wasSuccessful.UseVisualStyleBackColor = true;
            // 
            // listBox_filamentId
            // 
            this.listBox_filamentId.FormattingEnabled = true;
            this.listBox_filamentId.ItemHeight = 25;
            this.listBox_filamentId.Location = new System.Drawing.Point(420, 50);
            this.listBox_filamentId.Name = "listBox_filamentId";
            this.listBox_filamentId.Size = new System.Drawing.Size(176, 29);
            this.listBox_filamentId.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "Filament ID";
            // 
            // listBox_printerId
            // 
            this.listBox_printerId.FormattingEnabled = true;
            this.listBox_printerId.ItemHeight = 25;
            this.listBox_printerId.Location = new System.Drawing.Point(230, 50);
            this.listBox_printerId.Name = "listBox_printerId";
            this.listBox_printerId.Size = new System.Drawing.Size(176, 29);
            this.listBox_printerId.TabIndex = 68;
            // 
            // listBox_commandId
            // 
            this.listBox_commandId.FormattingEnabled = true;
            this.listBox_commandId.ItemHeight = 25;
            this.listBox_commandId.Location = new System.Drawing.Point(32, 50);
            this.listBox_commandId.Name = "listBox_commandId";
            this.listBox_commandId.Size = new System.Drawing.Size(180, 29);
            this.listBox_commandId.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(926, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Printer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(803, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Day";
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(907, 48);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(84, 33);
            this.comboBox_year.TabIndex = 51;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.ComboBox_year_SelectedIndexChanged);
            // 
            // comboBox_day
            // 
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Location = new System.Drawing.Point(795, 48);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(55, 33);
            this.comboBox_day.TabIndex = 50;
            this.comboBox_day.SelectedIndexChanged += new System.EventHandler(this.ComboBox_day_SelectedIndexChanged);
            // 
            // textBox_GramsUsed
            // 
            this.textBox_GramsUsed.Location = new System.Drawing.Point(1011, 49);
            this.textBox_GramsUsed.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_GramsUsed.MaxLength = 10;
            this.textBox_GramsUsed.Name = "textBox_GramsUsed";
            this.textBox_GramsUsed.Size = new System.Drawing.Size(152, 30);
            this.textBox_GramsUsed.TabIndex = 39;
            this.textBox_GramsUsed.Text = "100";
            this.textBox_GramsUsed.TextChanged += new System.EventHandler(this.TextBox_GramsUsed_TextChanged);
            // 
            // label_dateBought
            // 
            this.label_dateBought.AutoSize = true;
            this.label_dateBought.Location = new System.Drawing.Point(832, 0);
            this.label_dateBought.Name = "label_dateBought";
            this.label_dateBought.Size = new System.Drawing.Size(119, 25);
            this.label_dateBought.TabIndex = 48;
            this.label_dateBought.Text = "Date Printed";
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_month.Location = new System.Drawing.Point(860, 48);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(41, 33);
            this.comboBox_month.TabIndex = 49;
            this.comboBox_month.SelectedIndexChanged += new System.EventHandler(this.ComboBox_month_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1032, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Grams Used";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(63, 22);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(127, 25);
            this.label_id.TabIndex = 33;
            this.label_id.Text = "Command ID";
            // 
            // AddDialog_Prints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 212);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_Template);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDialog_Prints";
            this.Text = "AddDialog_Prints";
            this.Load += new System.EventHandler(this.AddDialog_Prints_Load);
            this.panel_Template.ResumeLayout(false);
            this.panel_Template.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_Template;
        private System.Windows.Forms.ListBox listBox_printerId;
        private System.Windows.Forms.ListBox listBox_commandId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.TextBox textBox_GramsUsed;
        private System.Windows.Forms.Label label_dateBought;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ListBox listBox_filamentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_wasSuccessful;
    }
}