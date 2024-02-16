using System;
using System.Collections.Generic;
using System.Data;


public class ServiceContrller
{
    private static DatabaseManager dbm = new DatabaseManager();

    private static DataTable dt = new DataTable();

    private static List<Service> services = new List<Service>();

    public static List<Service> GetAllServices()
    {
        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM `service`");

        try
        {
            services.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string categoryId = row["category"].ToString(); // Assuming there's a 'category' column in the result
                string price = row["price"].ToString();
                string photo = row["picture"].ToString();
                bool available = Convert.ToBoolean(row["available"]);
                string description = row["description"].ToString();
                string details = row["details"].ToString();
                Category category = CategoryController.getCategoryById(categoryId);

                Service service = new Service(id, name,photo , category, price, available, description, details);
                services.Add(service);
            }
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
        }

        return services;
    }

 

    public static Service getServiceById(string id)
    {

        dt = dbm.ExecuteSelectQuery(@"SELECT *  FROM service WHERE id="+id+";");
        if (dt == null) return null;
        if(dt.Rows.Count == 0) return null; 
        DataRow row = dt.Rows[0];

        string name = row["name"].ToString();
        string categoryId = row["category"].ToString(); // Assuming there's a 'category' column in the result
        string price = row["price"].ToString();
        string photo = row["picture"].ToString();
        bool available = Convert.ToBoolean(row["available"]);
        string description = row["description"].ToString();
        string details = row["details"].ToString();
        Category category = CategoryController.getCategoryById(categoryId);

        Service service = new Service(id, name, photo, category, price, available, description, details);





        return service;
    }

    public static Service Update(Service service)
    {
        string table = "service";
        string where = "id =" + service.id;

        Dictionary<string, object> rows = new Dictionary<string, object> {
            {"name",service.name },
            {"category", service.category.id },
            {"picture",service.photo },
            {"price",service.price },
            {"available",service.available },
            {"description",service.description},
            {"details",service.details},
        };
     
       dbm.UpdateRecord(table,rows,where);
       
        return service;
    }


    public static int InsertService(Service service)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(service.name))
        {
            throw new ArgumentException("Service name is required.");
        }
        if (service.category ==null)
        {
            throw new ArgumentException("Service category  is required.");
        }

        // Prepare data for insertion
        string tableName = "service"; // Assuming 'service' is correct
        Dictionary<string, object> values = new Dictionary<string, object>()
    {
        { "name", service.name },
        { "category", service.category.id }, // Use category_id if applicable
        { "picture", service.photo }, // Assuming 'photo' is used in your database
        { "price", service.price },
        { "available", service.available },
        { "description", service.description },
        { "details", service.details },
    };

        // Use an appropriate method for INSERT operation (replace with your implementation)
        int insertedId =dbm.InsertRecord(tableName, values); // Implement InsertRecord if not provided

        if (insertedId > 0)
        {
            // Use inserted ID to update service object (assuming 'id' property exists)
            service.id = insertedId.ToString();
            return int.Parse( service.id);
        }
        else
        {
            // Handle insertion failure (log, throw exception, etc.)
            // Consider returning null or another appropriate value
            throw new Exception("Failed to insert service."); // Example exception
        }
    }

}

