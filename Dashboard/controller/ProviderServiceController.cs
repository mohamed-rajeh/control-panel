using System;
using System.Collections.Generic;
using System.Data;


public class ProviderServiceController
{
    private static DatabaseManager dbm = new DatabaseManager();

    private static DataTable dt = new DataTable();

    private static List<ProviderServices> providersServices = new List<ProviderServices>();


    public static List<ProviderServices> getAllProvidersService()
    {
        try
        {

            dt = dbm.ExecuteSelectQuery(@"SELECT * FROM `provider_service`;");
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
            return null;
        }

        providersServices.Clear();
        foreach (DataRow row in dt.Rows)
        {
            string id = Convert.ToString(row["id"]);
            string providerId = Convert.ToString(row["provider"]); 
            string serviecId = Convert.ToString(row["serviec"]);
            string note = Convert.ToString(row["note"]);

            Provider provider= ProviderController.getProviderById(providerId);
            Service service = ServiceContrller.getServiceById(serviecId);
            ProviderServices providerServices = new ProviderServices(id, service, provider, note);

            providersServices.Add(providerServices);
        }
            return providersServices;
    }
    // get the services of the provider
    public static List<Service> getServicesByProvoder(string id)
    {
        List<Service> services = new List<Service>();   
        try
        {

            dt = dbm.ExecuteSelectQuery(@"SELECT * FROM `provider_service` WHERE provider =" + id);
            if (dt.Rows.Count <= 0) return null;
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
            return null;
        }
        
        services.Clear();
        foreach (DataRow row in dt.Rows)
        {
            string serviecId = Convert.ToString(row["service"]);

            Service service = ServiceContrller.getServiceById(serviecId);

            services.Add(service);
        }
        return services;
    }


    // get the provoders who do a services
    public static List<Provider> getProvidersByServic(string id)
    {
        List<Provider> providers = new List<Provider>();
        try
        {

            dt = dbm.ExecuteSelectQuery(@"SELECT * FROM `provider_service` WHERE service =" + id);
            if (dt.Rows.Count <= 0) return null;
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
            return null;
        }

        providers.Clear();
        foreach (DataRow row in dt.Rows)
        {
            string providerId = Convert.ToString(row["provider"]);

            Provider provider = ProviderController.getProviderById(providerId);

            providers.Add(provider);
        }
        return providers;
    }


    // for insert 
    public static int InsertPS(string proverd , string service , string note)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(proverd))
        {
            throw new ArgumentException("PS provider is required.");
        }
        if (string.IsNullOrEmpty(service))
        {
            throw new ArgumentException("PS service   is required.");
        }

        // Prepare data for insertion
        string tableName = "provider_service"; // Assuming 'service' is correct
        Dictionary<string, object> values = new Dictionary<string, object>()
    {
        { "provider", proverd },
        { "service", service }, 
        { "note", note }, 

    };

        // Use an appropriate method for INSERT operation (replace with your implementation)
        int insertedId = dbm.InsertRecord(tableName, values); // Implement InsertRecord if not provided

        if (insertedId > 0)
        {
            // Use inserted ID to update service object (assuming 'id' property exists)
            return insertedId;
        }
        else
        {
            // Handle insertion failure (log, throw exception, etc.)
            // Consider returning null or another appropriate value
            throw new Exception("Failed to insert PS."); // Example exception
        }
    }

}

