
public class Service
{
    private object p1;
    private string text;
    private object p2;

    public string id { get; set; }
    public string name { get; set; }
    public Category category { get; set; }
    public string photo { get; set; }
    public string price { get; set; }
    public bool available { get; set; }
    public string description { get; set; }
    public string details { get; set; }

    public Service(string id, string name,string photo, Category category, string price,
                    bool available, string description, string details)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.price = price;
        this.available = available;
        this.description = description;
        this.details = details;
        this.photo = photo;


    }

    public Service(object p1, string text, Category category, object p2)
    {
        this.p1 = p1;
        this.text = text;
        this.category = category;
        this.p2 = p2;
    }
}
