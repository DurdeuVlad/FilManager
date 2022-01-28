﻿using System;
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
<<<<<<< Updated upstream

        public static string sqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\userList.mdf;Integrated Security=True;Connect Timeout=30";
        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30
=======
       
>>>>>>> Stashed changes
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

        /// <summary>
        /// updateaza un dataTable bazat pe dataTableul si pe numele dat, returneaza debug data
        /// </summary>
        /// <param name="name">Numele bazei de date</param>
        /// <param dataTable="dataTable">Baza de data updatata</param>
        /// <returns></returns>
        [Obsolete("Does not work, needs fixing")]
        public static string InsertDataTable(string name, DataRow dataRow)
        {
            
            return "Updated table "+ name + " the item succesfully";
        }

        /// <summary>
        /// updateaza un dataTable bazat pe dataTableul si pe numele dat, returneaza debug data
        /// </summary>
        /// <param name="name">Numele bazei de date</param>
        /// <param dataTable="dataTable">Baza de data updatata</param>
        /// <returns></returns>
        public static string RemoveEntry(string TableName, int ID)
        {
            SqlConnection connection;

            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM dbo.["+TableName+"] WHERE Id="+ID+";", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.DeleteCommand = sqlCommand;
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            return "Removed number:"+ ID + " from table " + TableName + " the item succesfully";
        }

        /// <summary>
        /// updateaza un dataTable bazat pe dataTableul si pe numele dat, returneaza debug data
        /// </summary>
        /// <param name="name">Numele bazei de date</param>
        /// <param dataTable="dataTable">Baza de data updatata</param>
        /// <returns></returns>
        public static string InsertDataRow(DataRow dataRow, string TableName)
        {
            SqlConnection connection;

            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub Project\FilManager\FilManager\userList.mdf;Integrated Security=True;Connect Timeout=30");
            DataTable data = new DataTable();
            List<string> vs = new List<string>();
            for (int i = 0; i < dataRow.Table.Columns.Count; i++)
            {
                vs.Add(dataRow.Table.Columns[i].ColumnName);
            }
            connection.Open();
            string commandString = "INSERT INTO dbo.[" + TableName + "] (";
            foreach (string aux in vs)
            {
                //commandString = commandString + aux + "=@" + aux+",";
                commandString = commandString + aux;
                if (vs.IndexOf(aux) < vs.Count - 1)
                {
                    commandString += ",";
                }
            }
            commandString += ")";
            commandString += " Values (";
            foreach (string aux in vs)
            {
                //commandString = commandString + aux + "=@" + aux;
                commandString += "@" + aux;
                if (vs.IndexOf(aux) < vs.Count - 1)
                {
                    commandString += ",";
                }
            }
            commandString += ");";

            SqlCommand sqlCommand = new SqlCommand(commandString, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = sqlCommand;
            foreach (string aux in vs)
            {
                try
                {
                    sqlCommand.Parameters.Add("@" + aux,
                        SqlHelper.GetDbType(dataRow.Table.Columns[vs.IndexOf(aux)].DataType), 50, aux);
                    sqlCommand.Parameters["@" + aux].Value = dataRow.ItemArray[vs.IndexOf(aux)];
                }
                catch (Exception e)
                {
                    throw new ArgumentException($"NULL is not a supported .NET class, at " + aux
                        + " vs.IndexOf(aux)=" + vs.IndexOf(aux) + " dataRow.ItemArray[vs.IndexOf(aux)]=" + dataRow.ItemArray[vs.IndexOf(aux)]
                        + " dataRow.Table.Columns[vs.IndexOf(aux)]=" + dataRow.Table.Columns[vs.IndexOf(aux)].DataType);
                }
            }

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Syntax Error " + e.Message + "\n Command: " + commandString + "\nItem array " + dataRow.ItemArray[0]);
            }
            connection.Close();
            return "Updated table " + TableName + " the item succesfully";
        }
    }

    public static class SqlHelper
    {
        private static Dictionary<Type, SqlDbType> typeMap;

        // Create and populate the dictionary in the static constructor
        static SqlHelper()
        {
            typeMap = new Dictionary<Type, SqlDbType>();

            typeMap[typeof(string)] = SqlDbType.NVarChar;
            typeMap[typeof(char[])] = SqlDbType.NVarChar;
            typeMap[typeof(byte)] = SqlDbType.TinyInt;
            typeMap[typeof(short)] = SqlDbType.SmallInt;
            typeMap[typeof(int)] = SqlDbType.Int;
            typeMap[typeof(long)] = SqlDbType.BigInt;
            typeMap[typeof(byte[])] = SqlDbType.Image;
            typeMap[typeof(bool)] = SqlDbType.Bit;
            typeMap[typeof(DateTime)] = SqlDbType.DateTime2;
            typeMap[typeof(DateTimeOffset)] = SqlDbType.DateTimeOffset;
            typeMap[typeof(decimal)] = SqlDbType.Money;
            typeMap[typeof(float)] = SqlDbType.Real;
            typeMap[typeof(double)] = SqlDbType.Float;
            typeMap[typeof(TimeSpan)] = SqlDbType.Time;
            /* ... and so on ... */
        }

        // Non-generic argument-based method
        public static SqlDbType GetDbType(Type giveType)
        {
            // Allow nullable types to be handled
            giveType = Nullable.GetUnderlyingType(giveType) ?? giveType;

            if (typeMap.ContainsKey(giveType))
            {
                return typeMap[giveType];
            }

            throw new ArgumentException($"{giveType.FullName} is not a supported .NET class");
        }

        // Generic version
        public static SqlDbType GetDbType<T>()
        {
            return GetDbType(typeof(T));
        }
    }
}
