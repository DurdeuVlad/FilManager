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
    public partial class AddDialog_Printers : Form
    {
        public List<string> currentFilamentName, lastCommandName;
        public List<int> currentFilamentId, lastCommandId;
        public int userId = 0;
        object[] rowArray = new object[10];

        public bool isEditing = false;
        public int editRow = 0;
        bool ReadyToRegister => textBox_BuyCost.Text != "" && textBox_Producer.Text != ""
            && comboBox_day.Enabled && comboBox_day2.Enabled;
        public AddDialog_Printers()
        {
            InitializeComponent();

            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--)
            {
                comboBox_year.Items.Add(i.ToString());
            }
            button_add.Enabled = ReadyToRegister;
            comboBox_month.Enabled = true;
            comboBox_day.Enabled = false;
            button_add.Enabled = false;
            comboBox_year.SelectedIndex = 0;

            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--)
            {
                comboBox_year2.Items.Add(i.ToString());
            }
            button_add.Enabled = ReadyToRegister;
            comboBox_year.SelectedIndex = 0;
            comboBox_month.Enabled = true;
            comboBox_month.SelectedIndex = 0;
            comboBox_day.Enabled = true;
            comboBox_day.SelectedIndex = 0;

            comboBox_year2.SelectedIndex = 0;
            comboBox_month2.Enabled = true;
            comboBox_month2.SelectedIndex = 0;
            comboBox_day2.Enabled = true;
            comboBox_day2.SelectedIndex = 0;




        }


        private void ComboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        

        private void ComboBox_month2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_day2.Enabled = true;
            int daysInAMonth = 0;
            int monthChosen;
            comboBox_day2.Items.Clear();
            int.TryParse(comboBox_month2.SelectedItem.ToString(), out monthChosen);
            if (monthChosen == 2)
                if (int.Parse(comboBox_year2.Text) % 4 == 0)
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
                comboBox_day2.Items.Add(i.ToString());
            }
            comboBox_month2.SelectedItem = comboBox_month2.Items[DateTime.Now.Month - 1];
            comboBox_day2.SelectedItem = comboBox_day2.Items[DateTime.Now.Day - 1];
            button_add.Enabled = ReadyToRegister;
        }

        private void TextBox_Producer_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void TextBox_BuyCost_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
            long number;
            long.TryParse(textBox_BuyCost.Text, out number);
            textBox_BuyCost.Text = number.ToString();
        }

        private void ComboBox_day2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void AddDialog_Printers_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                object[] Entry = DatabaseCommands.GetEntryByRow("PRINTERS", editRow);
                textBox_Producer.Text = Entry[1].ToString().Trim();
                textBox_BuyCost.Text = Entry[2].ToString().Trim();
                checkBox_inMaintanance.Checked = bool.Parse(Entry[7].ToString());
                button_add.Text = "Edit";
            }
            foreach (string s in currentFilamentName)
            {
                listBox_currentFilamentId.Items.Add(s);
            }
            listBox_currentFilamentId.SelectedIndex = 0;
            foreach (string s in lastCommandName)
            {
                listBox_lastCommandId.Items.Add(s);
            }
            listBox_lastCommandId.SelectedIndex = 0;
        }

        private void CheckBox_inMaintanance_CheckedChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            //conectare baza de date si adaugare date + generare alte date
            DataTable dataTable = DatabaseCommands.ReturnDataTable("PRINTERS");
            DataRow dataRow;//dataRow.ItemArray
            dataRow = dataTable.NewRow();
            if (isEditing)
            {
                rowArray[0] = editRow;
            }
            else
            {
                rowArray[0] = DatabaseCommands.GetIndex("PRINTERS");
            }
            rowArray[1] = textBox_Producer.Text.Trim();
            rowArray[2] = textBox_BuyCost.Text.Trim();
            rowArray[3] = new DateTime(int.Parse(comboBox_year.SelectedItem.ToString()),
                int.Parse(comboBox_month.SelectedItem.ToString()),
                int.Parse(comboBox_day.SelectedItem.ToString())); ; //buy date
            rowArray[4] = currentFilamentId[listBox_currentFilamentId.SelectedIndex]; //current filament
            rowArray[5] = lastCommandId[listBox_lastCommandId.SelectedIndex]; //last command id
            rowArray[6] = 0; // grams printed total
            rowArray[7] = checkBox_inMaintanance.Checked; //maintanance
            if (checkBox_inMaintanance.Checked)
            {
                rowArray[8] = new DateTime(int.Parse(comboBox_year.SelectedItem.ToString()),
                    int.Parse(comboBox_month.SelectedItem.ToString()),
                    int.Parse(comboBox_day.SelectedItem.ToString()));//maintanance date
            }
            else
            {
                rowArray[8] = new DateTime(9999, 12, 30);//maintanance date
            }
            rowArray[9] = userId; 
            dataRow.ItemArray = rowArray;
            if (isEditing)
            {
                DatabaseCommands.RemoveEntry("PRINTERS", editRow);
            }
            DatabaseCommands.InsertDataRow(dataRow, "PRINTERS");
        }

        
    }
}
