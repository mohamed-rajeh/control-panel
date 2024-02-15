using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


public class StateController
{
    public static Order_State state { set; get; }
    public static List<Order_State> states = new List<Order_State>();
    public static List<Order_State> getAllSate()
    {
        DatabaseManager dtb = new DatabaseManager();
        DataTable dt = new DataTable();

        string sql = @"SELECT * FROM order_state ;";
        dt = dtb.ExecuteSelectQuery(sql);
        states.Clear();
        try
        {
            foreach (DataRow row in dt.Rows)
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                Order_State state = new Order_State(id, name);
                states.Add(state);
            }
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
        }

        return states;

    }
    public static Order_State getSateById (string id)
    {
         DatabaseManager dtb = new DatabaseManager();


        string sql = @"SELECT * FROM `order_state` WHERE `id`=" +id;
        DataTable dt = dtb.ExecuteSelectQuery(sql);
        if (dt == null) return null;
        DataRow dr = dt.Rows[0];
        string name = dr["name"].ToString();
        Order_State state = new Order_State(id, name);

        return state;
    

    }
}

