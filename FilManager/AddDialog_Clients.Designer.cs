namespace FilManager
{
    partial class AddDialog_Clients
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
            this.textBox_producer = new System.Windows.Forms.TextBox();
            this.label_producer = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_Template.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.button_cancel.Location = new System.Drawing.Point(162, 119);
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
            this.button_add.Location = new System.Drawing.Point(19, 119);
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
            this.panel_Template.Controls.Add(this.label_generated_code);
            this.panel_Template.Controls.Add(this.textBox_producer);
            this.panel_Template.Controls.Add(this.label_producer);
            this.panel_Template.Controls.Add(this.textBox_type);
            this.panel_Template.Controls.Add(this.label_type);
            this.panel_Template.Controls.Add(this.textBox_color);
            this.panel_Template.Controls.Add(this.label_id);
            this.panel_Template.Location = new System.Drawing.Point(13, 14);
            this.panel_Template.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Template.Name = "panel_Template";
            this.panel_Template.Size = new System.Drawing.Size(454, 95);
            this.panel_Template.TabIndex = 6;
            // 
            // label_generated_code
            // 
            this.label_generated_code.AutoSize = true;
            this.label_generated_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_generated_code.Location = new System.Drawing.Point(975, 58);
            this.label_generated_code.Name = "label_generated_code";
            this.label_generated_code.Size = new System.Drawing.Size(0, 25);
            this.label_generated_code.TabIndex = 13;
            this.label_generated_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_producer
            // 
            this.textBox_producer.Location = new System.Drawing.Point(228, 53);
            this.textBox_producer.Name = "textBox_producer";
            this.textBox_producer.Size = new System.Drawing.Size(220, 30);
            this.textBox_producer.TabIndex = 5;
            // 
            // label_producer
            // 
            this.label_producer.AutoSize = true;
            this.label_producer.Location = new System.Drawing.Point(309, 25);
            this.label_producer.Name = "label_producer";
            this.label_producer.Size = new System.Drawing.Size(60, 25);
            this.label_producer.TabIndex = 4;
            this.label_producer.Text = "Email";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(117, 53);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(105, 30);
            this.textBox_type.TabIndex = 3;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(144, 25);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(57, 25);
            this.label_type.TabIndex = 2;
            this.label_type.Text = "Type";
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(12, 53);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(99, 30);
            this.textBox_color.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(30, 27);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(64, 25);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Name";
            // 
            // AddDialog_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 192);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_Template);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDialog_Clients";
            this.Text = "AddDialog_Clients";
            this.panel_Template.ResumeLayout(false);
            this.panel_Template.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_Template;
        private System.Windows.Forms.Label label_generated_code;
        private System.Windows.Forms.TextBox textBox_producer;
        private System.Windows.Forms.Label label_producer;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.Label label_id;
    }
}