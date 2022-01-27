using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilManager
{
    class DatabaseCommands
    {

        public static string sqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\userList.mdf;Integrated Security=True;Connect Timeout=30";
        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30
        /// <summary>
        /// Clasa asta verifica daca exista emailul si returneaza true daca exista,
        /// DataTableul unde a cautat datele si linia unde l-a gasit
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static bool ExistsEmail(string email, out DataTable data, out int row)
        {
            bool exist = false;
            row = 0;
            SqlConnection connection = new SqlConnection(sqlConnection);
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
        /// Clasa asta verifica daca exista emailul si returneaza true daca exista si linia unde l-a gasit
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static bool ExistsEmail(string email, out int row)
        {
            DataTable data;
            bool exist = false;
            row = -1;
            SqlConnection connection = new SqlConnection(sqlConnection);
            data = new DataTable();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string currentEmail = data.Rows[i][1].ToString();
                if (currentEmail.Equals(email))
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
        /// Clasa asta verifica daca exista userul si returneaza true daca exista si userid-ul gasit
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        [Obsolete("Does not work, needs fixing")]
        public static bool ExistsUser(string email, string password, out string userid)
        {
            bool exist = false;
            userid = "-1";
            SqlConnection connection = new SqlConnection(sqlConnection);
            DataTable data = new DataTable();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.[Table]", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string currentEmail = data.Rows[i][1].ToString();
                if (currentEmail.Equals(email))
                {
                    if (data.Rows[i][2].ToString().Equals(password) || data.Rows[i][5].ToString().Equals(password))
                    {
                        userid = i.ToString();
                        exist = true;
                        break;
                    }
                }
            }
            connection.Close();
            return exist;
        }

        /// <summary>
        /// returneaza DataTable cu numele dat
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
            connection = new SqlConnection(sqlConnection);
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
