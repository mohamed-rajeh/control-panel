using System;
using System.Collections.Generic;
using System.Data;

public class OrderController
{
    public static Order order { get; set; }//temp data
    private static DatabaseManager  dbm     = new DatabaseManager();

    private static DataTable        dt      = new DataTable();

    private static List<Order>      orders  = new List<Order>();

    public static void addOrder()
    {


    }
    public static List<Order> getAllOrders()
    {
        try
        {

        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM `order`");
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
            return null;
        }

        orders.Clear();
        // Iterate through each row of the DataTable and create Class_User objects
        foreach (DataRow row in dt.Rows)
        {
            
            // fetch order 
            string  id          = row["id"].ToString();
            string customer = row["customer"].ToString();
            string provider_id = row["provider"].ToString();
            string service_id = row["service"].ToString();
            DateTime date = Convert.ToDateTime(row["date"]);
            string state_id = row["state"].ToString();
            string note = row["note"].ToString();
 

            // fetch customer  
            User user = UserController.getUserById(customer);
           // System.Windows.Forms.MessageBox.Show(user.Name);


            // fetch service
            Service service = ServiceContrller.getServiceById(service_id);

           // fech provider
            Provider provider = ProviderController.getProviderById(provider_id);

            // fetch state
            Order_State state = StateController.getSateById(state_id);

            Order order  = new Order(id,user,provider , service , date  , state ,note);
            //  Add the created user object to the list
            orders.Add(order);
        }

        return orders;
    }


    public static int UpdateOrder(Order order)
    {
        // Ensure required fields are present
        if (string.IsNullOrEmpty(order.state.name))
        {
            throw new ArgumentException("state is required.");
        }


        string tableName = "`order`";
        string where = "`id`=" + order.id;

        Dictionary<string, object> values = new Dictionary<string, object>()
    {
        { "state", order.state.id },
        { "provider", order.provider == null ? null : order.provider.Id},

    };

        return dbm.UpdateRecord(tableName, values, where);
    }


}

