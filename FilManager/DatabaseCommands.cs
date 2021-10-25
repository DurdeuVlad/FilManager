using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilManager
{
    class DatabaseCommands
    {
        public static bool ExistsEmail(string email, out DataTable data, out int row)
        {
            bool exist = false;
            row = 0;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30");
            data = new DataTable();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string currentEmail = data.Rows[i][1].ToString();
                if (currentEmail.Contains(email))
                {
                    row = i;
                    exist = true;
                    break;
                }
            }
            connection.Close();
            return exist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable ReturnDataTable(string name)
        {
            SqlConnection connection;
            switch (name)
            {
                case "name":
                    {
                        break;
                    }
            }
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30");
            DataTable data = new DataTable();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.["+name+"]", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Fill(data);
            }
            catch (Exception e)
            {
                data = null;
            }
            connection.Close();
            return data;
        }
    }
}
