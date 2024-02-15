using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


    public class AddressController
    {
        public static Address address;
        private static DatabaseManager dbm = new DatabaseManager();

         private static DataTable dt = new DataTable();

         public static Address getAddressById(string id)
    {
        dt = dbm.ExecuteSelectQuery("SELECT * FROM address WHERE id="+id+";");
        if(dt.Rows.Count == 0) { return null; }
        DataRow row = dt.Rows[0];

        string city     = row["city"].ToString();
        string street   = row["street"].ToString();
        string note     = row["address_note"].ToString();

        Address address = new Address(id, city, street, note);  
        return address;


    }

          public static int Insertaddress(Address address)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(address.city))
        {
            throw new ArgumentException("address city is required.");
        }
        if (string.IsNullOrEmpty(address.street))
        {
            throw new ArgumentException("address street  is required.");
        }

        // Prepare data for insertion
        string tableName = "address"; // Assuming 'service' is correct
        Dictionary<string, object> values = new Dictionary<string, object>()
    {
        { "city", address.city },
        { "street", address.street }, // Use category_id if applicable
        { "address_note", address.address_note }, // Use category_id if applicable

    };

        // Use an appropriate method for INSERT operation (replace with your implementation)
        int insertedId = dbm.InsertRecord(tableName, values); // Implement InsertRecord if not provided

        if (insertedId > 0)
        {
            // Use inserted ID to update service object (assuming 'id' property exists)
            address.id = insertedId.ToString();
            return int.Parse(address.id);
        }
        else
        {
            // Handle insertion failure (log, throw exception, etc.)
            // Consider returning null or another appropriate value
            throw new Exception("Failed to insert address."); // Example exception
        }
    }

    public static int Updateaddress(Address address)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(address.city))
        {
            throw new ArgumentException("address city is required.");
        }
        if (string.IsNullOrEmpty(address.street))
        {
            throw new ArgumentException("address street  is required.");
        }

        // Prepare data for insertion
        string tableName = "address"; // Assuming 'service' is correct
        Dictionary<string, object> values = new Dictionary<string, object>()
          {
              { "city", address.city },
              { "street", address.street }, // Use category_id if applicable
              { "address_note", address.address_note }, // Use category_id if applicable

          };
        
        
       return dbm.UpdateRecord(tableName, values , "id="+address.id); 

       
    }

}

