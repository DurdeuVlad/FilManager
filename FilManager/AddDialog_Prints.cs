using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FilManager
{
    public partial class AddDialog_Prints : Form
    {
        public List<string> commandName, printerName, filamentName;
        public List<int> commandId, printerId, filamentId;
        public int userId = 0;
        object[] rowArray = new object[10];

        public bool isEditing = false;
        public int editRow = 0;
        public AddDialog_Prints()
        {
            InitializeComponent();

            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--)
            {
                comboBox_year.Items.Add(i.ToString());
            }
            button_add.Enabled = ReadyToRegister;
            
            
            button_add.Enabled = false;
            comboBox_year.SelectedIndex = 0;
            comboBox_month.Enabled = true;
            comboBox_month.SelectedIndex = 0;
            comboBox_day.Enabled = true;
            comboBox_day.SelectedIndex = 0;

            

        }


        private void ComboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDialog_Prints_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                object[] Entry = DatabaseCommands.GetEntryByRow("PRINTS", editRow);
                checkBox_wasSuccessful.Checked = bool.Parse(Entry[4].ToString());
                textBox_GramsUsed.Text = Entry[6].ToString().Trim();
                button_add.Text = "Edit";
            }
            foreach (string s in filamentName)
            {
                listBox_filamentId.Items.Add(s);
            }
            listBox_filamentId.SelectedIndex = 0;
            foreach (string s in commandName)
            {
                listBox_commandId.Items.Add(s);
            }
            listBox_commandId.SelectedIndex = 0;
            foreach (string s in printerName)
            {
                listBox_printerId.Items.Add(s);
            }
            listBox_printerId.SelectedIndex = 0;
        }

        private void TextBox_GramsUsed_TextChanged(object sender, EventArgs e)
        {

            long number;
            long.TryParse(textBox_GramsUsed.Text, out number);
            textBox_GramsUsed.Text = number.ToString();
            button_add.Enabled = ReadyToRegister;
        }

        private void ComboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_day.Enabled = true;
            int daysInAMonth = 0;
            int monthChosen;
            comboBox_day.Items.Clear();
            int.TryParse(comboBox_month.SelectedItem.ToString(), out monthChosen);
            if (monthChosen == 2)
                if (int.Parse(comboBox_year.Text) % 4 == 0)
                {
                    daysInAMonth = 29;
                }
                else
                {
                    daysInAMonth = 28;
                }
            else if ((monthChosen % 2 == 1 && monthChosen <= 5) || ((monthChosen % 2 == 0 && monthChosen >= 5)))
            {
                daysInAMonth = 31;
            }
            else if (monthChosen == 0)
            {
                daysInAMonth = 0;

            }
            else
            {
                daysInAMonth = 30;
            }


            for (int i = 1; i <= daysInAMonth; i++)
            {
                comboBox_day.Items.Add(i.ToString());
            }
            comboBox_month.SelectedItem = comboBox_month.Items[DateTime.Now.Month - 1];
            comboBox_day.SelectedItem = comboBox_day.Items[DateTime.Now.Day - 1];
            button_add.Enabled = ReadyToRegister;

        }

        private void ComboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }
        

        bool ReadyToRegister => textBox_GramsUsed.Text != ""
            && comboBox_day.Enabled;

       
        private void Button_add_Click(object sender, EventArgs e)
        {
            //conectare baza de date si adaugare date + generare alte date
            DataTable dataTable = DatabaseCommands.ReturnDataTable("PRINTS");
            DataRow dataRow;//dataRow.ItemArray
            dataRow = dataTable.NewRow();
            if (isEditing)
            {
                rowArray[0] = editRow;
            }
            else
            {
                rowArray[0] = DatabaseCommands.GetIndex("PRINTS");
            }
            rowArray[1] = commandId[listBox_commandId.SelectedIndex];
            rowArray[2] = printerId[listBox_printerId.SelectedIndex];
            rowArray[3] = filamentId[listBox_filamentId.SelectedIndex];
            rowArray[4] = checkBox_wasSuccessful.Checked;
            rowArray[5] = new DateTime(int.Parse(comboBox_year.SelectedItem.ToString()),
                int.Parse(comboBox_month.SelectedItem.ToString()),
                int.Parse(comboBox_day.SelectedItem.ToString()));
            rowArray[6] = int.Parse(textBox_GramsUsed.Text); // grams printed total 
            rowArray[7] = userId;
            rowArray[8] = userId;
            rowArray[9] = userId;
            dataRow.ItemArray = rowArray;
            if (isEditing)
            {
                DatabaseCommands.RemoveEntry("PRINTS", editRow);
            }
            DatabaseCommands.InsertDataRow(dataRow, "PRINTS");
        }
    }
}
