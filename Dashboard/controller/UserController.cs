using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class UserController
{
    private static DatabaseManager  dbm   = new DatabaseManager();

    private static DataTable        dt    = new DataTable();

    private static List<User>       users = new List<User>();
    public static List<User> getAllUsers()
    {
        try
        {

        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM user JOIN address ON user.address = address.id;");
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
            return null;
        }

        users.Clear();
        // Iterate through each row of the DataTable and create Class_User objects
        foreach (DataRow row in dt.Rows)
        {
            
            // fetch user 
            string  id          = row["id"].ToString();
            string  name        = row["name"].ToString();
            string  phone       = row["phone"].ToString();
            DateTime  date      = Convert.ToDateTime(row["date"]);
            bool    gender      = Convert.ToBoolean(row["gender"]);
            string  password    = row["password"].ToString();
            bool    availbale   = Convert.ToBoolean(row["available"]);
            
            // fetch user Address 
            string  id_address   = row["id"].ToString();
            string  city         = row["city"].ToString();
            string  street       = row["street"].ToString();
            string address_note  = row["address_note"].ToString();
            Address address      = new Address(id_address, city, street, address_note);


            // Create a new Class_User object with the extracted values
            User user = new User(id, name, phone, date, gender, password, address, availbale);

            //  Add the created user object to the list
            users.Add(user);
        }

        return users;
    }

    public static User getUserById(string id )
    {
        dt.Clear();
        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM user WHERE id="+id);
        if (dt.Rows.Count == 0) return null;
        DataRow row = dt.Rows[0];

        // fetch user 
        string name = row["name"].ToString();
        string phone = row["phone"].ToString();
        DateTime date = Convert.ToDateTime(row["date"]);
        bool gender = Convert.ToBoolean(row["gender"]);
        string password = row["password"].ToString();
        bool availbale = Convert.ToBoolean(row["available"]);
        string address_id = row["address"].ToString(); 

        // fetch user Address 
        Address address = AddressController.getAddressById(address_id);



        // Create a new Class_User object with the extracted values
        User user = new User(id, name, phone, date, gender, password, address, availbale);
        return user;

    }


    public static void addUser()
    {


    }

    public static void blockOrActeiveUser(string id , bool state)
    {
        // Example usage of UpdateRecord function
        string tableName = "user";
        string whereClause = "id ="+id; // Specify the condition for the WHERE clause
        Dictionary<string, object> updateValues = new Dictionary<string, object>                    
        {
            { "available", state } //  update field
        };

        // Assuming 'dbm' is an instance of your database manager class
       dbm.UpdateRecord(tableName, updateValues, whereClause);

    }

}

