
public class Address
{
    public string id { get; set; }
    public string city { get; set; }
    public string street { get; set; }
    public string address_note { get; set; }


    public Address(string id, string city, string street, string note)
    {
        this.id = id;
        this.city = city;
        this.street = street;
        this.address_note = note;






    }
}
