using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class CategoryController
    {

    private static DatabaseManager dbm = new DatabaseManager();

    private static DataTable dt = new DataTable();

    private static List<Category> category = new List<Category>();

    public static List<Category> GetAllcategorys()
    {
        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM category");
        List<Category> categorys = new List<Category>();

        try
        {
            foreach (DataRow row in dt.Rows)
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                bool available = Convert.ToBoolean(row["available"]);
                Category category = new Category(id, name,available);


                categorys.Add(category);
            }
        }
        catch (Exception e)
        {

            System.Windows.Forms.MessageBox.Show(e.Message);
        }

        return categorys;
    }



    public static Category getCategoryById(string id)
    {

        dt = dbm.ExecuteSelectQuery(@"SELECT * FROM category");

        if(dt.Rows.Count == 0) return null;
        DataRow row = dt.Rows[0];

        string name = row["name"].ToString();
        bool available = Convert.ToBoolean(row["available"]);
        Category category = new Category(id, name, available);
        return category;

    }

    
}

