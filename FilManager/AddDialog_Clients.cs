using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilManager
{
    public partial class AddDialog_Clients : Form
    {
        public int userId;
        public bool isEditing = false;
        public int editRow = 0;
        bool FillData => textBox_name.Text != "" && textBox_email.Text != "" && textBox_type.Text != "";

        public AddDialog_Clients()
        {
            InitializeComponent();
            button_add.Enabled = false;
        }
        private void Button_add_Click(object sender, EventArgs e)
        {

            //conectare baza de date si adaugare date + generare alte date
            DataTable dataTable = DatabaseCommands.ReturnDataTable("CLIENTS");
            DataRow dataRow = dataTable.NewRow();
            object[] rowArray = new object[6];
            if (isEditing)
            {
                rowArray[0] = editRow;
            }
            else
            {
                rowArray[0] = dataTable.Rows.Count;
            }
            rowArray[1] = textBox_name.Text.Trim();
            rowArray[2] = textBox_email.Text.Trim();
            rowArray[4] = textBox_type.Text.Trim();
            rowArray[3] = DateTime.Now;
            rowArray[5] = userId;
            dataRow.ItemArray = rowArray;
            if (isEditing)
            {
                DatabaseCommands.RemoveEntry("CLIENTS", editRow);
            }
            DatabaseCommands.InsertDataRow(dataRow, "CLIENTS");
        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = FillData;
        }

        private void TextBox_type_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = FillData;
        }

        private void TextBox_email_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = FillData;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDialog_Clients_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                object[] Entry = DatabaseCommands.GetEntry("CLIENTS", editRow);
                textBox_name.Text = Entry[1].ToString().Trim();
                textBox_type.Text = Entry[4].ToString().Trim();
                textBox_email.Text = Entry[2].ToString().Trim();
                button_add.Text = "Edit";
            }
        }
    }
}
