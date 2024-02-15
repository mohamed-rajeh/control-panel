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



    public static Service getServiceById(string id)
    {

        dt = dbm.ExecuteSelectQuery(@"SELECT
                                        s.id,
                                        s.name,
                                        s.category,
                                        s.price,
                                        s.available,
                                        s.description,
                                        s.details,
                                        c.name cname,
                                        c.available cavailable
                                    FROM service AS s
                                    JOIN category AS c ON s.category = c.id WHERE s.id=" + id + ";");


        DataRow row = dt.Rows[0];


        string name = row["name"].ToString();
        string categoryId = row["category"].ToString(); // Assuming there's a 'category' column in the result
        string price = row["price"].ToString();
        bool available = Convert.ToBoolean(row["available"]);
        string description = row["description"].ToString();
        string details = row["details"].ToString();
        Category category = new Category(categoryId, row["cname"].ToString(), Convert.ToBoolean(row["cavailable"]));

        Service service = new Service(id, name, category, price, available, description, details);




        return service;
    }

    public static Service Update(Service service)
    {
        string table = "service";
        Dictionary<string, object> rows = new Dictionary<string, object> {
            {"name",service.name },
            {"category", service.category.id },
            {"picture","d" },
            {"price","d" },
            {"available","d" },
            {"description","d" },
            {"details","d" },
        };

        //dbm.UpdateRecord();
        return service;
    }
}

