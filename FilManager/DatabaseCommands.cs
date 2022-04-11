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


        public static string sqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" 
+ Directory.GetCurrentDirectory() + "\\userList.mdf;Integrated Security=True;Connect Timeout=30";

        public static int GetColumnByName(string TableName, string ColumnName)
        {
            DataTable dataTable = ReturnDataTable(TableName);
            int result = 0;
            int i = 0;
            foreach (object obj in dataTable.Columns)
            {
                if (dataTable.Columns[i].ToString() == ColumnName)
                {
                    result = i;
                    break;
                }
                i++;
            }
            return result;
        }
        public static string GetCellByName(string TableName, string ColumnName, int Row)
        {
            DataTable dataTable = ReturnDataTable(TableName);
            DataRow dataRow = dataTable.Rows[Row];
            string result = "";
            int i = 0;
            foreach(object obj in dataRow.ItemArray)
            {
                if (dataTable.Columns[i].ToString() == ColumnName)
                {
                    result = obj.ToString();
                    break;
                }
                i++;
            }
            return result;
        }
        
        public static int GetEntryCount(string TableName)
        {
            return ReturnDataTable(TableName).Rows.Count;
        }

        /// <summary>
        /// Updates a single item from a row
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="editRow"></param>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public static void UpdateItemRow(string TableName, int editRow, object item, int index)
        {
            DataTable dataTable = ReturnDataTable(TableName);
            DataRow dataRow = dataTable.Rows[editRow];
            dataRow[index] = item;
            RemoveEntry(TableName, editRow);
            InsertDataRow(dataRow, TableName);
        }

        /// <summary>
        /// Adds every entry of from sumColumn which conditionColumn.Coloumns[index] is == conditionIndex
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="index"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static float ColumnSum(string TableName, int conditionIndex, int conditionColumn, int sumColumn)
        {
            float sum = 0;
            DataTable dataTable = ReturnDataTable(TableName);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (int.Parse(dataRow.ItemArray[conditionColumn].ToString()) == conditionIndex) { 
                    sum += int.Parse(dataRow.ItemArray[sumColumn].ToString());
                }
            }
            return sum;
        }

        /// <summary>
        /// Will get the smallest unique index available
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static int GetIndex(string TableName)
        {
            int index = -1;
            List<int> ins = new List<int>();
            DataTable dataTable = ReturnDataTable(TableName);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                ins.Add(int.Parse(dataRow.ItemArray[0].ToString()));
            }
            for(int i=0;i<= dataTable.Rows.Count; i++)
            {
                if (!ins.Contains(i))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }



        /// <summary>
        /// Gets an entry from the table
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public static object[] GetEntryByRow(string TableName, int Index)
        {
            DataTable dataTable = ReturnDataTable(TableName);
            DataRow dataRow;
            try {
                dataRow = dataTable.Rows[Index];
                return dataRow.ItemArray;
            }
            catch (Exception)
            {

                return GetEntryBySearch(TableName, Index);
            }
            
        }

        public static object[] GetEntryBySearch(string TableName, int Index)
        {
            DataTable dataTable = ReturnDataTable(TableName);
            DataRow dataRow = null;
            for(int i=0; i < dataTable.Rows.Count; i++) { 
                if (int.Parse(dataTable.Rows[i].ItemArray[0].ToString()) == Index) { 
                    dataRow = dataTable.Rows[i];
                    break;
                }
            }
            return dataRow.ItemArray;
        }


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
        public static string RemoveEntry(string TableName, int ID)
        {
            SqlConnection connection;
            connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM "+TableName+ " WHERE Id=" + ID + ";", connection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.DeleteCommand = sqlCommand;
            int a = sqlCommand.ExecuteNonQuery();
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

            connection = new SqlConnection(sqlConnection);
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
                {                    sqlCommand.Parameters.Add("@" + aux,
                        SqlHelper.GetDbType(dataRow.Table.Columns[vs.IndexOf(aux)].DataType), 50, aux);
                    sqlCommand.Parameters["@" + aux].Value = dataRow.ItemArray[vs.IndexOf(aux)];                }
                catch (Exception e)
                {
                    throw new ArgumentException($"NULL is not a supported .NET class, at " + aux
                        + " vs.IndexOf(aux)=" + vs.IndexOf(aux) + " dataRow.ItemArray[vs.IndexOf(aux)]=" + dataRow.ItemArray[vs.IndexOf(aux)]
                        + " dataRow.Table.Columns[vs.IndexOf(aux)]=" + dataRow.Table.Columns[vs.IndexOf(aux)].DataType);
                }
            }
            try            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)            {
                throw new ArgumentException($"Syntax Error " + e.Message + "\n Command: " + commandString + "\nItem array " + dataRow.ItemArray[0]);
            }
            connection.Close();
            return "Updated table " + TableName + " the item succesfully";        }
        }

    

    public static class SqlHelper
    {
        private static Dictionary<Type, SqlDbType> typeMap;
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
        }
        public static SqlDbType GetDbType(Type giveType)
        {
            giveType = Nullable.GetUnderlyingType(giveType) ?? giveType;

            if (typeMap.ContainsKey(giveType))
            {
                return typeMap[giveType];
            }

            throw new ArgumentException($"{giveType.FullName} is not a supported .NET class");
        }

        public static SqlDbType GetDbType<T>()
        {
            return GetDbType(typeof(T));
        }
    }
}
