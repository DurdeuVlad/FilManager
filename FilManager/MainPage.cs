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
        bool NoEmail => LoginEmail == null;
        public MainPage()
        {
            InitializeComponent();
            SelectedPrinter.Select(0, "-", label_NamePrinter);
            SelectedFilament.Select(0, "-", label_NameFilament);
            SelectedClient.Select(0, "-", label_NameClient);
            SelectedCommand.Select(0, "-", label_NameCommand);
            SelectedUser.Select(0, "-", label_NameUser);
            button_Decolapse.Visible = false;
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
            account.ShowDialog();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {

        }

        private void button_FilamentRolls_Click(object sender, EventArgs e)
        {
            label_Title.Text = "FILAMENT ROLLS";
            dataGridView_Main.DataSource = DatabaseCommands.ReturnDataTable("FILAMENT_ROLLS");
     
        }

        private void button_Prints_Click(object sender, EventArgs e)
        {
            label_Title.Text = "PRINTS";
            dataGridView_Main.DataSource = DatabaseCommands.ReturnDataTable("PRINTS");

        }

        private void button_Clients_Click(object sender, EventArgs e)
        {
            label_Title.Text = "CLIENTS";
            dataGridView_Main.DataSource = DatabaseCommands.ReturnDataTable("CLIENTS");
        }

        private void button_Commands_Click(object sender, EventArgs e)
        {
            label_Title.Text = "COMMANDS";
            dataGridView_Main.DataSource = DatabaseCommands.ReturnDataTable("COMMANDS");
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            label_Title.Text = "USERS";
            dataGridView_Main.DataSource = DatabaseCommands.ReturnDataTable("LOCAL_USER");
        }

        private void button_Printers_Click(object sender, EventArgs e)
        {
            label_Title.Text = "PRINTERS";
            dataGridView_Main.DataSource = DatabaseCommands.ReturnDataTable("PRINTERS");
        }
    }
}
