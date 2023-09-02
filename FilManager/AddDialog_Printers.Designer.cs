namespace FilManager
{
    partial class AddDialog_Printers
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
            this.listBox_lastCommandId = new System.Windows.Forms.ListBox();
            this.textBox_BuyCost = new System.Windows.Forms.TextBox();
            this.listBox_currentFilamentId = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_year2 = new System.Windows.Forms.ComboBox();
            this.comboBox_day2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_month2 = new System.Windows.Forms.ComboBox();
            this.checkBox_inMaintanance = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.textBox_Producer = new System.Windows.Forms.TextBox();
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
            this.button_cancel.Location = new System.Drawing.Point(1197, 132);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(205, 58);
            this.button_cancel.TabIndex = 5;
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
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // panel_Template
            // 
            this.panel_Template.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Template.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Template.Controls.Add(this.listBox_lastCommandId);
            this.panel_Template.Controls.Add(this.textBox_BuyCost);
            this.panel_Template.Controls.Add(this.listBox_currentFilamentId);
            this.panel_Template.Controls.Add(this.label5);
            this.panel_Template.Controls.Add(this.label6);
            this.panel_Template.Controls.Add(this.label7);
            this.panel_Template.Controls.Add(this.label9);
            this.panel_Template.Controls.Add(this.comboBox_year2);
            this.panel_Template.Controls.Add(this.comboBox_day2);
            this.panel_Template.Controls.Add(this.label10);
            this.panel_Template.Controls.Add(this.comboBox_month2);
            this.panel_Template.Controls.Add(this.checkBox_inMaintanance);
            this.panel_Template.Controls.Add(this.label3);
            this.panel_Template.Controls.Add(this.label1);
            this.panel_Template.Controls.Add(this.label2);
            this.panel_Template.Controls.Add(this.label8);
            this.panel_Template.Controls.Add(this.comboBox_year);
            this.panel_Template.Controls.Add(this.comboBox_day);
            this.panel_Template.Controls.Add(this.textBox_Producer);
            this.panel_Template.Controls.Add(this.label_dateBought);
            this.panel_Template.Controls.Add(this.comboBox_month);
            this.panel_Template.Controls.Add(this.label4);
            this.panel_Template.Controls.Add(this.label_id);
            this.panel_Template.Location = new System.Drawing.Point(13, 14);
            this.panel_Template.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Template.Name = "panel_Template";
            this.panel_Template.Size = new System.Drawing.Size(1389, 111);
            this.panel_Template.TabIndex = 3;
            // 
            // listBox_lastCommandId
            // 
            this.listBox_lastCommandId.FormattingEnabled = true;
            this.listBox_lastCommandId.ItemHeight = 25;
            this.listBox_lastCommandId.Location = new System.Drawing.Point(230, 50);
            this.listBox_lastCommandId.Name = "listBox_lastCommandId";
            this.listBox_lastCommandId.Size = new System.Drawing.Size(176, 29);
            this.listBox_lastCommandId.TabIndex = 68;
            // 
            // textBox_BuyCost
            // 
            this.textBox_BuyCost.Location = new System.Drawing.Point(572, 49);
            this.textBox_BuyCost.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BuyCost.MaxLength = 10;
            this.textBox_BuyCost.Name = "textBox_BuyCost";
            this.textBox_BuyCost.Size = new System.Drawing.Size(152, 30);
            this.textBox_BuyCost.TabIndex = 66;
            this.textBox_BuyCost.Text = "100";
            this.textBox_BuyCost.TextChanged += new System.EventHandler(this.TextBox_BuyCost_TextChanged);
            // 
            // listBox_currentFilamentId
            // 
            this.listBox_currentFilamentId.FormattingEnabled = true;
            this.listBox_currentFilamentId.ItemHeight = 25;
            this.listBox_currentFilamentId.Location = new System.Drawing.Point(32, 50);
            this.listBox_currentFilamentId.Name = "listBox_currentFilamentId";
            this.listBox_currentFilamentId.Size = new System.Drawing.Size(180, 29);
            this.listBox_currentFilamentId.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Buy Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1268, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1197, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Month";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1145, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 62;
            this.label9.Text = "Day";
            // 
            // comboBox_year2
            // 
            this.comboBox_year2.FormattingEnabled = true;
            this.comboBox_year2.Location = new System.Drawing.Point(1249, 45);
            this.comboBox_year2.Name = "comboBox_year2";
            this.comboBox_year2.Size = new System.Drawing.Size(84, 33);
            this.comboBox_year2.TabIndex = 61;
            // 
            // comboBox_day2
            // 
            this.comboBox_day2.FormattingEnabled = true;
            this.comboBox_day2.Location = new System.Drawing.Point(1137, 45);
            this.comboBox_day2.Name = "comboBox_day2";
            this.comboBox_day2.Size = new System.Drawing.Size(55, 33);
            this.comboBox_day2.TabIndex = 60;
            this.comboBox_day2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_day2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1163, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Date maintance";
            // 
            // comboBox_month2
            // 
            this.comboBox_month2.FormattingEnabled = true;
            this.comboBox_month2.Items.AddRange(new object[] {
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
            this.comboBox_month2.Location = new System.Drawing.Point(1202, 45);
            this.comboBox_month2.Name = "comboBox_month2";
            this.comboBox_month2.Size = new System.Drawing.Size(41, 33);
            this.comboBox_month2.TabIndex = 59;
            this.comboBox_month2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_month2_SelectedIndexChanged);
            // 
            // checkBox_inMaintanance
            // 
            this.checkBox_inMaintanance.AutoSize = true;
            this.checkBox_inMaintanance.Location = new System.Drawing.Point(952, 45);
            this.checkBox_inMaintanance.Name = "checkBox_inMaintanance";
            this.checkBox_inMaintanance.Size = new System.Drawing.Size(179, 29);
            this.checkBox_inMaintanance.TabIndex = 55;
            this.checkBox_inMaintanance.Text = "In Maintanance?";
            this.checkBox_inMaintanance.UseVisualStyleBackColor = true;
            this.checkBox_inMaintanance.CheckedChanged += new System.EventHandler(this.CheckBox_inMaintanance_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Last Command ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(746, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Day";
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(850, 45);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(84, 33);
            this.comboBox_year.TabIndex = 51;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.ComboBox_year_SelectedIndexChanged);
            // 
            // comboBox_day
            // 
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Location = new System.Drawing.Point(738, 45);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(55, 33);
            this.comboBox_day.TabIndex = 50;
            this.comboBox_day.SelectedIndexChanged += new System.EventHandler(this.ComboBox_day_SelectedIndexChanged);
            // 
            // textBox_Producer
            // 
            this.textBox_Producer.Location = new System.Drawing.Point(414, 49);
            this.textBox_Producer.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Producer.MaxLength = 10;
            this.textBox_Producer.Name = "textBox_Producer";
            this.textBox_Producer.Size = new System.Drawing.Size(152, 30);
            this.textBox_Producer.TabIndex = 39;
            this.textBox_Producer.Text = "Creality";
            this.textBox_Producer.TextChanged += new System.EventHandler(this.TextBox_Producer_TextChanged);
            // 
            // label_dateBought
            // 
            this.label_dateBought.AutoSize = true;
            this.label_dateBought.Location = new System.Drawing.Point(780, -3);
            this.label_dateBought.Name = "label_dateBought";
            this.label_dateBought.Size = new System.Drawing.Size(118, 25);
            this.label_dateBought.TabIndex = 48;
            this.label_dateBought.Text = "Date bought";
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
            this.comboBox_month.Location = new System.Drawing.Point(803, 45);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(41, 33);
            this.comboBox_month.TabIndex = 49;
            this.comboBox_month.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Producer";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(27, 19);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(185, 25);
            this.label_id.TabIndex = 33;
            this.label_id.Text = "Current Filament  ID";
            // 
            // AddDialog_Printers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 204);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_Template);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDialog_Printers";
            this.Text = "AddDialog_Printers";
            this.Load += new System.EventHandler(this.AddDialog_Printers_Load);
            this.panel_Template.ResumeLayout(false);
            this.panel_Template.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_Template;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Producer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.Label label_dateBought;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.CheckBox checkBox_inMaintanance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_year2;
        private System.Windows.Forms.ComboBox comboBox_day2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_month2;
        private System.Windows.Forms.TextBox textBox_BuyCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_lastCommandId;
        private System.Windows.Forms.ListBox listBox_currentFilamentId;
    }
}