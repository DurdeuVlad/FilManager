using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilManager
{
    public partial class TEst : Form
    {
        public static string sqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
+ Directory.GetCurrentDirectory() + "\\userList.mdf;Integrated Security=True;Connect Timeout=30";

        public TEst()
        {
            //hehe
            InitializeComponent();
            SqlConnection connection;
            connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM FILAMENT_ROLLS", connection);
            sqlCommand.ExecuteNonQuery();
        }


    }
}
