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
            rowArray[0] = dataTable.Rows.Count;
            rowArray[1] = textBox_name.Text;
            rowArray[2] = textBox_email.Text;
            rowArray[4] = textBox_type.Text;
            rowArray[3] = DateTime.Now;
            rowArray[5] = userId;
            dataRow.ItemArray = rowArray;
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
    }
}
