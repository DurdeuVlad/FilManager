﻿using System;
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

        string Selected = "";
        public string LoginEmail;
        public string Password;
        public int UserId;
        bool NoEmail => LoginEmail == null || Password == null;
        //bool NoValidUser => DatabaseCommands.ExistsEmail(LoginEmail, out UserId);
        public MainPage()
        {
            InitializeComponent();
            
            

        }
        
        public void SetSelected(string newTitle)
        {
            Selected = newTitle;
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
            switch (Selected) { 
            case "FILAMENT ROLLS":
                AddDialog_FilamentRolls addDialog_FilamentRolls = new AddDialog_FilamentRolls();
                addDialog_FilamentRolls.userId = UserId;
                addDialog_FilamentRolls.ShowDialog();
                break;
            case "CLIENTS":
                AddDialog_Clients addDialog_clients = new AddDialog_Clients();
                addDialog_clients.userId = UserId;
                addDialog_clients.ShowDialog();
                break;
            }

        }
        /// <summary>
        /// Clears selected highlights
        /// </summary>
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
        /// <summary>
        /// Shows what variables are needed
        /// </summary>
        /// <param name="Name"></param>
        void ShowNeeded(string Name)
        {
            Color color = Color.Black;
            FontStyle fontStyle = FontStyle.Regular;
            Show(Name, color, fontStyle);
        }
        /// <summary>
        /// Shows what variables is selected
        /// </summary>
        /// <param name="Name"></param>
        void ShowSelected(string Name)
        {
            Color color = Color.Green;
            FontStyle fontStyle = FontStyle.Bold;
            Show(Name, color, fontStyle);
            SetSelected(Name);
        }
        /// <summary>
        /// Highlight what variables are in use
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="color"></param>
        /// <param name="fontStyle"></param>
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
        /// <summary>
        /// Shows data if the sql table name is the same as the title shown to the user
        /// </summary>
        /// <param name="TableName"></param>
        void ShowData(string TableName)
        {
            ShowData(TableName, TableName);
        }
        /// <summary>
        /// Shows data to the user
        /// </summary>
        /// <param name="TableName">What sql table we acces</param>
        /// <param name="Title">What we show to the user</param>
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

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DatabaseCommands.RemoveEntry();
        }
    }
}
