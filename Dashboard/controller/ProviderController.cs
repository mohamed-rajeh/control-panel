using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

public class ProviderController
{
    public static Provider provider;  
    private static DatabaseManager dbm = new DatabaseManager();

    private static DataTable dt = new DataTable();

    private static List<Provider> providers = new List<Provider>();

    public static List<Provider> getAllProviders()
    {
        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM provider;");

        providers.Clear();
        // Iterate through each row of the DataTable and create Class_User objects
        foreach (DataRow row in dt.Rows)
        {

            // fetch user 
            string id = row["id"].ToString();
            string name = row["name"].ToString();
            string phone = row["phone"].ToString();
            string idCard = row["id_card"].ToString();
            string picture = row["picture"].ToString();
            string note = row["note"].ToString();
            string address_id = row["address"].ToString();
            bool available = Convert.ToBoolean(row["available"]);


            // fetch user Address 
            Address address = AddressController.getAddressById(address_id);

            // Create a new Class_User object with the extracted values
            Provider provider = new Provider(id, name, address , phone ,picture , idCard , available,note );

            //  Add the created user object to the list
            providers.Add(provider);
        }


        return providers;
    }

  

    public static Provider getProviderById(string id)
    {
        if ( string.IsNullOrEmpty(id)) return null;
        dt.Clear();
        string sql ="SELECT * FROM provider WHERE id ="+id;
        
        try
        {
            dt = dbm.ExecuteSelectQuery(sql);
            if (dt.Rows.Count == 0) { return null; }
            DataRow row = dt.Rows[0];
            // fetch provider 

            string name = row["name"].ToString();
            string phone = row["phone"].ToString();
            string idCard = row["id_card"].ToString();
            string picture = row["picture"].ToString();
            string note = row["note"].ToString();
            string address_id = row["address"].ToString();
            bool available = Convert.ToBoolean(row["available"]);


            // fetch user Address 
            Address address = AddressController.getAddressById(address_id);


            // Create a new Class_User object with the extracted values
            Provider provider = new Provider(id, name, address, phone, picture, idCard, available, note);
            return provider;
        }
        catch (Exception e)
        {

            throw e;
        }

    }


    public static int InsertProvider(Provider provider)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(provider.Name))
        {
            throw new ArgumentException("provider name is required.");
        }
        if (string.IsNullOrEmpty(provider.IdCard))
        {
            throw new ArgumentException("provider id Card  is required.");
        }

        // Prepare data for insertion
        string tableName = "provider"; // Assuming 'service' is correct
        Dictionary<string, object> values = new Dictionary<string, object>()
    {
        { "name", provider.Name },
        { "address", provider.Address.id }, // Use category_id if applicable
        { "phone", provider.Phone }, // Assuming 'photo' is used in your database
        { "picture", provider.Picture },
        { "id_card", provider.IdCard },
        { "available", provider.Available },
        { "note", provider.Note },
    };

        // Use an appropriate method for INSERT operation (replace with your implementation)
        int insertedId = dbm.InsertRecord(tableName, values); // Implement InsertRecord if not provided

        if (insertedId > 0)
        {
            // Use inserted ID to update service object (assuming 'id' property exists)
            string getIdQuery = "SELECT MAX(id) id FROM provider ";
            dt.Clear();
            dt = dbm.ExecuteSelectQuery(getIdQuery);
            insertedId = int.Parse(dt.Rows[0]["id"].ToString());
            return insertedId;
        }
        else
        {
            // Handle insertion failure (log, throw exception, etc.)
            // Consider returning null or another appropriate value
            throw new Exception("Failed to insert service."); // Example exception
        }
    }

    public static int UpdateProvider(Provider provider)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(provider.Name))
        {
            throw new ArgumentException("provider name is required.");
        }
        if (string.IsNullOrEmpty(provider.IdCard))
        {
            throw new ArgumentException("provider id Card  is required.");
        }

        // Prepare data for insertion
        string tableName = "provider"; // Assuming 'service' is correct
        Dictionary<string, object> values = new Dictionary<string, object>()
    {
        { "name", provider.Name },
        { "address", provider.Address.id }, // Use category_id if applicable
        { "phone", provider.Phone }, // Assuming 'photo' is used in your database
        { "picture", provider.Picture },
        { "id_card", provider.IdCard },
        { "available", provider.Available },
        { "note", provider.Note },
    };

        // Use an appropriate method for INSERT operation (replace with your implementation)
        return dbm.UpdateRecord(tableName, values, "id=" + provider.Id); // Implement InsertRecord if not provided
    }

}

