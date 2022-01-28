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
        public int userId;

        public AddDialog_FilamentRolls()
        {
            InitializeComponent();

            //textBox_dateBought.Text = DateTime.Now.ToString();
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--) 
            {
                comboBox_year.Items.Add(i.ToString());
            }
        }

        

        string colorShort = "", typeShort = "", idShort = "";
        int itemId = 0;
        private void button_add_Click(object sender, EventArgs e)
        {
            //conectare baza de date si adaugare date + generare alte date
            DataTable dataTable = DatabaseCommands.ReturnDataTable("FILAMENT_ROLLS");
            DataRow dataRow = dataTable.NewRow();
            dataRow.ItemArray[0] = dataTable.Rows.Count;
            dataRow.ItemArray[1] = textBox_color.Text;
            dataRow.ItemArray[2] = textBox_type.Text;
            dataRow.ItemArray[3] = textBox_producer.Text;
            dataRow.ItemArray[4] = label_generated_code.Text;
            dataRow.ItemArray[5] = textBox_pricetotal.Text;
            dataRow.ItemArray[6] = int.Parse(textBox_pricetotal.Text)
                / int.Parse(textBox_startweight.Text);
            dataRow.ItemArray[7] = int.Parse(textBox_startweight.Text);
            dataRow.ItemArray[8] = double.Parse(textBox_currentweight.Text);
            dataRow.ItemArray[9] = null;
            dataRow.ItemArray[10] = null;
            dataRow.ItemArray[11] = userId;
        }

        private void AddDialog_FilamentRolls_Load(object sender, EventArgs e)
        {

            
        }

        private void textBox_color_TextChanged(object sender, EventArgs e)
        {
            colorShort = textBox_color.Text;
            ChangeUniqueCode();
        }

        private void textBox_startweight_TextChanged(object sender, EventArgs e)
        {
            int Result = 0;
            int.TryParse(textBox_startweight.Text, out Result);
            textBox_startweight.Text = Result.ToString();
        }

        private void textBox_currentweight_TextChanged(object sender, EventArgs e)
        {
            double Result = 0;
            double.TryParse(textBox_currentweight.Text, out Result);
            textBox_currentweight.Text = Result.ToString();
        }

        private void textBox_dateBought_TextChanged(object sender, EventArgs e)
        {
            DateTime dateTime;
            //DateTime.TryParse(textBox_dateBought.Text, out dateTime);
            //textBox_dateBought.Text = dateTime.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
        }

        private void Label_type_Click(object sender, EventArgs e)
        {

        }

        private void textBox_type_TextChanged(object sender, EventArgs e)
        {
            typeShort = textBox_type.Text;
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
