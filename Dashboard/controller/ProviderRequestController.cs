using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ProviderRequestController
    {

      private static DatabaseManager dbm = new DatabaseManager();

      private static DataTable dt = new DataTable();

     private static List<ProviderRequest> Requests = new List<ProviderRequest>();


    public static List<ProviderRequest> getAllRequests()
    {
        try
        {

            dt = dbm.ExecuteSelectQuery(@"SELECT * FROM `proveder_requst`");
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
            return null;
        }

        Requests.Clear();
        foreach (DataRow row in dt.Rows)
        {
            //pass data from DataBase into  Provider_Request object 

            ProviderRequest data = new ProviderRequest
            (
                row["id"].ToString(),
                row["name"].ToString(),
                row["phone"].ToString(),
                row["picture"].ToString(), // Replace with the actual column name for the picture
                AddressController.getAddressById(row["address"].ToString()),
                row["id_card"].ToString(),
                Convert.ToDateTime(row["date"]),
                ServiceContrller.getServiceById(row["service"].ToString())
            );

            Requests.Add(data); // add the object to the  list 
        }
        return Requests;
    }

    public static int deleteProviderRequest(string requestId)
    {
        string table = "proveder_requst";
        string where = "id="+requestId;

        return dbm.DeleteRecord(table,where);
    }

}

