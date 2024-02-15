

public class Category
{
    public string id { get; set; }
    public string name { get; set; }
    public bool available { get; set; }

    public Category(string id, string name, bool available)
    {
        this.id = id;
        this.name = name;
        this.available = available;

    }
}
