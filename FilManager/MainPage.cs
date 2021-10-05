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

        public string LoginEmail;
        bool NoEmail => LoginEmail == null;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
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

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
