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
    public partial class AddDialog_Commands : Form
    {
        public List<string> clientName;
        public List<int> clientId;
        public int userId = 0;
        public bool isEditing = false;
        public int editRow = 0;

        public AddDialog_Commands()
        {
            InitializeComponent();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDialog_Commands_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                object[] Entry = DatabaseCommands.GetEntry("COMMANDS", editRow);
                checkBox_wasprinted.Checked = bool.Parse(Entry[3].ToString());
                checkBox_wassent.Checked = bool.Parse(Entry[4].ToString());
                checkBox_wasreceived.Checked = bool.Parse(Entry[5].ToString());
                textBox_pricegrams.Text = Entry[7].ToString().Trim();
                textBox_pricepaid.Text = Entry[8].ToString().Trim();    
                textBox_priceindrects.Text = Entry[9].ToString().Trim();
                textBox_pricetax.Text = Entry[10].ToString().Trim();
                /*
                 * rowArray[7] = double.Parse(textBox_pricepaid.Text);
            rowArray[8] = double.Parse(textBox_pricegrams.Text);
            rowArray[9] = double.Parse(textBox_priceindrects.Text);
            rowArray[10] = double.Parse(textBox_pricetax.Text);
                 */
                button_add.Text = "Edit";
            }
            foreach (string s in clientName)
            {
                listBox_clientId.Items.Add(s);
            }
            listBox_clientId.SelectedIndex = 0;
        }

        bool ReadyToRegister => textBox_pricepaid.Text != "" && textBox_pricegrams.Text != "" && textBox_priceindrects.Text != "" && textBox_pricetax.Text != "";


        private void TextBox_pricepaid_AcceptsTabChanged(object sender, EventArgs e)
        {
            StaticClasses.TextToInt(textBox_pricepaid);
        }

        object[] rowArray = new object[13];
        private void Button_add_Click(object sender, EventArgs e)
        {
            //conectare baza de date si adaugare date + generare alte date
            DataTable dataTable = DatabaseCommands.ReturnDataTable("COMMANDS");
            DataRow dataRow;//dataRow.ItemArray
            dataRow = dataTable.NewRow();
            if (isEditing)
            {
                rowArray[0] = editRow;
            }
            else
            {
                try { rowArray[0] = dataTable.Rows.Count; }// int.Parse(dataTable.Rows[dataTable.Rows.Count].ItemArray[0].ToString()) + 1; }
                catch (Exception) { rowArray[0] = 0; }
            }
            rowArray[1] = DateTime.Now;
            rowArray[2] = clientId[listBox_clientId.SelectedIndex];
            rowArray[3] = checkBox_wasprinted.Checked;
            rowArray[4] = checkBox_wassent.Checked;
            rowArray[5] = checkBox_wasreceived.Checked;
            if (checkBox_wasreceived.Checked) { rowArray[6] = DateTime.Now; }
            

                rowArray[7] = double.Parse(textBox_pricepaid.Text);
            rowArray[8] = double.Parse(textBox_pricegrams.Text);
            rowArray[9] = double.Parse(textBox_priceindrects.Text);
            rowArray[10] = double.Parse(textBox_pricetax.Text);
            rowArray[11] = double.Parse(textBox_pricepaid.Text) - 
                double.Parse(textBox_pricegrams.Text)
                - double.Parse(textBox_pricepaid.Text)* double.Parse(textBox_priceindrects.Text)/100
                - double.Parse(textBox_pricepaid.Text) * double.Parse(textBox_pricetax.Text) / 100;

            rowArray[12] = userId;
            dataRow.ItemArray = rowArray;
            if (isEditing)
            {
                DatabaseCommands.RemoveEntry("COMMANDS", editRow);
            }
            DatabaseCommands.InsertDataRow(dataRow, "COMMANDS");
        }
    }
}
