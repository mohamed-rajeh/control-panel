using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class DatabaseManager
{
    private string connectionString = @"server=localhost;
                                        database=service_db;
                                        UID=root;password=;";

    public DatabaseManager() { }

    public DatabaseManager(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void OpenConnection()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
        }
    }



    public DataTable ExecuteSelectQuery(string query)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable results = new DataTable();
                        results.Load(reader);
                        return results;
                    }
                }
            }
        }
        catch (System.Exception e)
        {
            MessageBox.Show(e.Message);
           return null;
            
        }
    }

    private int ExecuteNonQuery(string query, MySqlParameter[] parameters)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }


    public int ExecuteNonQuery(string query)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
               
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }

    public int UpdateRecord(string tableName, Dictionary<string, object> values, string whereClause)
    {
        if (string.IsNullOrEmpty(tableName) || values == null || values.Count == 0 || string.IsNullOrEmpty(whereClause))
        {
            MessageBox.Show("invaild parms");
            return 0;
        }

        // Build the SET clause for the UPDATE query
        string setClause = string.Join(", ", values.Select(kv => $"{kv.Key} = @{kv.Key}"));

        // Build the UPDATE query
        string updateQuery = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";
        // Create and add parameters for the query
        List<MySqlParameter> parameters = values.Select(kv => new MySqlParameter($"@{kv.Key}", kv.Value)).ToList();
      

        // Execute the UPDATE query
        return ExecuteNonQuery(updateQuery, parameters.ToArray());

    }

    public int InsertRecord(string tableName, Dictionary<string, object> values)
    {
        if (string.IsNullOrEmpty(tableName) || values == null || values.Count == 0)
        {
            // Handle invalid input parameters
            return 0;
        }



        // Build the INSERT query dynamically
        List<string> columnNames = new List<string>();
        List<string> parameterNames = new List<string>();
        List<MySqlParameter> parameters = new List<MySqlParameter>();

        foreach (KeyValuePair<string, object> kv in values)
        {
            columnNames.Add(kv.Key);
            parameterNames.Add($"@{kv.Key}");
            parameters.Add(new MySqlParameter(parameterNames.Last(), kv.Value));
        }

        string insertQuery = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

        // Execute the INSERT query
        return ExecuteNonQuery(insertQuery, parameters.ToArray());
    }



    public int DeleteRecord(string tableName, string whereClause)
    {
        if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(whereClause))
        {
            // Handle invalid input parameters
            throw new ArgumentException("Both tableName and whereClause are required.");
        }

        // Build the DELETE query dynamically
        StringBuilder deleteQuery = new StringBuilder($"DELETE FROM {tableName} WHERE {whereClause}");

        // Execute the DELETE query
        return ExecuteNonQuery(deleteQuery.ToString());
    }

}
