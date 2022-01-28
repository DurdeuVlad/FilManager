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
    public partial class AddDialog_FilamentRolls : Form
    {
        public int userId = 0;

        public AddDialog_FilamentRolls()
        {
            InitializeComponent();

            //textBox_dateBought.Text = DateTime.Now.ToString();
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--) 
            {
                comboBox_year.Items.Add(i.ToString());
            }
            button_add.Enabled = ReadyToRegister;
            comboBox1.Enabled = false;
            comboBox_day.Enabled = false;
            button_add.Enabled = false;
            comboBox_year.SelectedIndex = 0;
            

        }



        bool ReadyToRegister => textBox_color.Text != "" && textBox_type.Text != "" && textBox_producer.Text != "" && textBox_pricetotal.Text != "" && textBox_startweight.Text != "" && textBox_currentweight.Text != "" && textBox_generated_code.Text != "";

        string colorShort = "", typeShort = "", idShort = "";
        int itemId = 0;
        object[] rowArray = new object[12];
        private void button_add_Click(object sender, EventArgs e)
        {
            //conectare baza de date si adaugare date + generare alte date
            DataTable dataTable = DatabaseCommands.ReturnDataTable("FILAMENT_ROLLS");
            DataRow dataRow;//dataRow.ItemArray
            dataRow = dataTable.NewRow();
            rowArray[0] = dataTable.Rows.Count;
            rowArray[1] = textBox_color.Text;
            rowArray[2] = textBox_type.Text;
            rowArray[3] = textBox_producer.Text;
            rowArray[4] = textBox_generated_code.Text;
            rowArray[5] = textBox_pricetotal.Text;
            rowArray[6] = double.Parse(textBox_pricetotal.Text)
                / double.Parse(textBox_startweight.Text);
            rowArray[7] = int.Parse(textBox_startweight.Text);
            rowArray[8] = double.Parse(textBox_currentweight.Text);
            rowArray[9] = new DateTime(int.Parse(comboBox_year.SelectedItem.ToString()), 
                int.Parse(comboBox1.SelectedItem.ToString()), 
                int.Parse(comboBox_day.SelectedItem.ToString()));
            if (0 <= double.Parse(textBox_currentweight.Text)) {
                rowArray[10] = new DateTime(int.Parse(comboBox_year.SelectedItem.ToString()),
                    int.Parse(comboBox1.SelectedItem.ToString()),
                    int.Parse(comboBox_day.SelectedItem.ToString())); }
            else {
                rowArray[10] = new DateTime(9999, 12, 30);
            }
            rowArray[11] = userId;
            dataRow.ItemArray = rowArray;
            DatabaseCommands.InsertDataRow(dataRow, "FILAMENT_ROLLS");
        }

        private void AddDialog_FilamentRolls_Load(object sender, EventArgs e)
        {

            
        }

        private void textBox_color_TextChanged(object sender, EventArgs e)
        {
            colorShort = textBox_color.Text;
            button_add.Enabled = ReadyToRegister;
            ChangeUniqueCode();
        }

        private void textBox_startweight_TextChanged(object sender, EventArgs e)
        {
            int Result = 0;
            button_add.Enabled = ReadyToRegister;
            int.TryParse(textBox_startweight.Text, out Result);
            textBox_startweight.Text = Result.ToString();
        }

        private void textBox_currentweight_TextChanged(object sender, EventArgs e)
        {
            double Result = 0;
            button_add.Enabled = ReadyToRegister;
            double.TryParse(textBox_currentweight.Text, out Result);
            textBox_currentweight.Text = Result.ToString();
        }

        private void textBox_dateBought_TextChanged(object sender, EventArgs e)
        {
            DateTime dateTime;
            button_add.Enabled = ReadyToRegister;
            //DateTime.TryParse(textBox_dateBought.Text, out dateTime);
            //textBox_dateBought.Text = dateTime.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox_day.Enabled = true;
            int daysInAMonth=0;
            int monthChosen;
            comboBox_day.Items.Clear();
            int.TryParse(comboBox1.SelectedItem.ToString(), out monthChosen);
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
            comboBox_day.SelectedItem = comboBox_day.Items[DateTime.Now.Day-1];
            button_add.Enabled = ReadyToRegister;

        }

        private void textBox_producer_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void textBox_pricetotal_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void textBox_generated_code_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void comboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add.Enabled = ReadyToRegister;
        }

        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = DateTime.Now.Month - 1;
            button_add.Enabled = ReadyToRegister;

        }

        private void comboBox_year_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            int.TryParse(comboBox_year.Text, out aux);
            if (!(int.TryParse(comboBox_year.Text, out aux) && comboBox_year.Items.Contains(aux)))
                comboBox_year.SelectedIndex = 0;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            int.TryParse(comboBox1.Text, out aux);
            if (!(int.TryParse(comboBox1.Text, out aux) && comboBox1.Items.Contains(aux)))
                comboBox1.SelectedIndex = 0;
        }

        private void comboBox_day_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            if(!int.TryParse(comboBox_day.Text, out aux))
            {
                comboBox_day.SelectedItem = comboBox_day.Items[DateTime.Now.Day - 1];
            }


        }

        private void Label_type_Click(object sender, EventArgs e)
        {

        }

        private void textBox_type_TextChanged(object sender, EventArgs e)
        {
            typeShort = textBox_type.Text;
            button_add.Enabled = ReadyToRegister;
            ChangeUniqueCode();
        }

        void ChangeUniqueCode()
        {
            idShort = itemId.ToString();
            if(idShort.Length < 2)
            {
                idShort = 0 + idShort;
            }
            if(colorShort.Length>=2 && typeShort.Length >= 2)
                textBox_generated_code.Text = colorShort.Trim().Substring(0, 2)
                    + idShort.Trim().Substring(0, 2)
                    + typeShort.Trim().Substring(0, 2);

        }
    }
}
