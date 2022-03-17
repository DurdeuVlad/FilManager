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
        public int ClientNumber=0;
        public int userId = 0;
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
            textBox_clientID.Text = ClientNumber.ToString();
        }

        bool ReadyToRegister => textBox_clientID.Text != "" && textBox_pricepaid.Text != "" && textBox_pricegrams.Text != "" && textBox_priceindrects.Text != "" && textBox_pricetax.Text != "";

        string colorShort = "", typeShort = "", idShort = "";
        int itemId = 0;

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
            try { rowArray[0] = dataTable.Rows.Count; }// int.Parse(dataTable.Rows[dataTable.Rows.Count].ItemArray[0].ToString()) + 1; }
            catch (Exception) { rowArray[0] = 0; }
            rowArray[1] = DateTime.Now;
            rowArray[2] = textBox_clientID.Text;
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
            DatabaseCommands.InsertDataRow(dataRow, "COMMANDS");
        }
    }
}
