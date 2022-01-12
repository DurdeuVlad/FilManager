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
    public partial class MainPage : Form
    {
        StructHolder.SelectedItem SelectedPrinter;
        StructHolder.SelectedItem SelectedFilament;
        StructHolder.SelectedItem SelectedClient;
        StructHolder.SelectedItem SelectedCommand;
        StructHolder.SelectedItem SelectedUser;
        

        public string LoginEmail;
        public string Password;
        public int UserId;
        bool NoEmail => LoginEmail == null || Password == null;
        //bool NoValidUser => DatabaseCommands.ExistsEmail(LoginEmail, out UserId);
        public MainPage()
        {
            InitializeComponent();
            
            

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userListDataSet.Table' table. You can move, or remove it, as needed.
            CheckIfLogged();
            
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button_Collapse_Click(object sender, EventArgs e)
        {
            panel_MainMenu.Visible = false;
            button_Decolapse.Visible = true;
            button_Collapse.Visible = false;
        }

        private void button_Decolapse_Click(object sender, EventArgs e)
        {
            panel_MainMenu.Visible = true;
            button_Decolapse.Visible = false;
            button_Collapse.Visible = true;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            CheckIfLogged();
        }

        void CheckIfLogged()
        {
            LoginEmail = null;
            
            if (NoEmail)
            {
                Login login = new Login();
                login._MainPage = this;
                login.ShowDialog();
            }
            if (NoEmail)
            {
                this.Close();
            }
            SelectedPrinter.Select(0, "-", label_NamePrinter);
            SelectedFilament.Select(0, "-", label_NameFilament);
            SelectedClient.Select(0, "-", label_NameClient);
            SelectedCommand.Select(0, "-", label_NameCommand);
            SelectedUser.Select(0, "-", label_NameUser);
            panel_MainMenu.Visible = true;
            button_Decolapse.Visible = false;
            label_Title.Text = "Welcome Back!";
            dataGridView_Main.DataSource = null;

        }

        private void button_Feedback_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.email = LoginEmail;
            contact.ShowDialog();
        }

        private void button_Support_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.email = LoginEmail;
            contact.ShowDialog();
        }

        private void button_Account_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.currentEmail = LoginEmail;
            account.currentPassword = Password;
            account.ShowDialog();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {

        }

        private void button_FilamentRolls_Click(object sender, EventArgs e)
        {
            ShowData("FILAMENT_ROLLS", "FILAMENT ROLLS");
        }

        private void button_Prints_Click(object sender, EventArgs e)
        {
            ShowData("PRINTS");
            ShowNeeded("COMMANDS");
            ShowNeeded("PRINTERS");
            ShowNeeded("FILAMENT_ROLLS");
        }

        private void button_Clients_Click(object sender, EventArgs e)
        {
            ShowData("CLIENTS");
            
        }

        private void button_Commands_Click(object sender, EventArgs e)
        {
            ShowData("COMMANDS");
            ShowNeeded("CLIENTS");
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            ShowData("LOCAL_USERS", "USERS");
        }

        private void button_Printers_Click(object sender, EventArgs e)
        {
            ShowData("PRINTERS");
            ShowNeeded("FILAMENT_ROLLS");
            ShowNeeded("COMMANDS");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddDialog_FilamentRolls addDialog_FilamentRolls = new AddDialog_FilamentRolls();
            addDialog_FilamentRolls.userId = UserId;
            addDialog_FilamentRolls.ShowDialog();
        }

        void ClearSelected()
        {
            List<Label> nameLabels = new List<Label>();
            nameLabels.Add(label_NamePrinter);
            nameLabels.Add(label_NameFilament);
            nameLabels.Add(label_NameClient);
            nameLabels.Add(label_NameCommand);
            nameLabels.Add(label_NameUser);

            List<Label> selectedLabels = new List<Label>();
            selectedLabels.Add(label_SelectedPrinter);
            selectedLabels.Add(label_SelectedFilament);
            selectedLabels.Add(label_SelectedClient);
            selectedLabels.Add(label_SelectedCommand);
            selectedLabels.Add(label_SelectedUser);

            foreach(Label label in nameLabels)
            {
                label.ForeColor = Color.Gray;
                label.Font = new Font(label_SelectedPrinter.Font, FontStyle.Regular);
            }

            foreach (Label label in selectedLabels)
            {
                label.ForeColor = Color.Gray;
                label.Font = new Font(label_SelectedPrinter.Font, FontStyle.Italic);
            }

        }

        void ShowNeeded(string Name)
        {
            Color color = Color.Black;
            FontStyle fontStyle = FontStyle.Regular;
            Show(Name, color, fontStyle);
        }

        void ShowSelected(string Name)
        {
            Color color = Color.Green;
            FontStyle fontStyle = FontStyle.Bold;
            Show(Name, color, fontStyle);
        }

        void Show(string Name, Color color, FontStyle fontStyle)
        {
            switch (Name)
            {
                case "FILAMENT_ROLLS":
                    label_NameFilament.ForeColor = color;
                    label_SelectedFilament.ForeColor = color;
                    label_NameFilament.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    label_SelectedFilament.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    break;
                case "CLIENTS":
                    label_NameClient.ForeColor = color;
                    label_SelectedClient.ForeColor = color;
                    label_NameClient.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    label_SelectedClient.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    break;
                case "COMMANDS":
                    label_NameCommand.ForeColor = color;
                    label_SelectedCommand.ForeColor = color;
                    label_NameCommand.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    label_SelectedCommand.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    break;
                case "LOCAL_USERS":
                    label_NameUser.ForeColor = color;
                    label_SelectedUser.ForeColor = color;
                    label_NameUser.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    label_SelectedUser.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    break;
                case "PRINTERS":
                    label_NamePrinter.ForeColor = color;
                    label_SelectedPrinter.ForeColor = color;
                    label_NamePrinter.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    label_SelectedPrinter.Font = new Font(label_SelectedPrinter.Font, fontStyle);
                    break;
            }
        }

        void ShowData(string TableName)
        {
            ShowData(TableName, TableName);
        }

        void ShowData(string TableName, string Title)
        {
            label_Title.Text = Title;
            ClearSelected();
            ShowSelected(TableName);
            

            //declare auxiliary list
            DataTable dataTable = new DataTable();
            DataTable dataTableFinal = new DataTable();

            dataTable = DatabaseCommands.ReturnDataTable(TableName);
            dataTableFinal = DatabaseCommands.ReturnDataTable(TableName);
            dataTableFinal.Rows.Clear();
            dataGridView_Main.DataSource = dataTableFinal;

            

            //fill dataTableFinal with rows
            foreach (DataRow dataGrid in dataTable.Rows)
            {
                if (int.Parse(dataGrid[dataGridView_Main.Columns.Count - 1].ToString()) == UserId)
                {

                    DataRow aux = dataTableFinal.NewRow();
                    aux.ItemArray = dataGrid.ItemArray;
                    dataTableFinal.Rows.Add(aux);

                }
            }
            dataTableFinal.Columns.RemoveAt(dataTable.Columns.Count - 1);
            //fill dataGridView with data
            dataGridView_Main.DataSource = dataTableFinal;

            //add items to listBox_Main, not in use anymore
            /*
            //clear list
            //listBox_Main.Items.Clear();
            //remember the number of character each title has, it will be important later
            List<int> letters = new List<int>();

            //fill listBox_Main with data, row by row
            object dataRow = "";
            foreach (object Object in dataTableFinal.Columns)
            {
                string aux = Object.ToString().Replace(" ", "") + "    ";
                letters.Add(aux.Length);
                dataRow += aux;
            }

            
            listBox_Main.Items.Add(dataRow);

            foreach (DataRow dataGrid in dataTableFinal.Rows)
            {
                dataRow = "";
                int columns = 0;
                foreach (object Object in dataGrid.ItemArray)
                {
                    // we will add half the remaining spaces to the left and half to the right
                    int total = letters[columns];
                    string aux = Object.ToString().Replace(" ", "");
                    total -= aux.Length+1;
                    int right = ((int) total / 2) - 2;
                    int left = ((int) total / 2);
                    left += total % 2;
                    
                    for(int i=1; i<= right; i++)
                    {
                        aux = "p" + aux;
                    }
                    for (int i = 1; i <= left; i++)
                    {
                        aux += "o";
                    }
                    dataRow += aux + " ";
                    columns++;
                }
                //listBox_Main.Items.Add(dataRow);
            }
            */

        }
    }
}
