
public class Provider
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public string Phone { get; set; }
    public string Picture { get; set; }
    public string IdCard { get; set; }
    public bool Available { get; set; } = true;
    public string Note { get; set; }

    // Constructor
    public Provider(string id,string name, Address address, string phone, string picture, string idCard, bool available, string note )
    {
        Id = id;
        Name = name;
        Address = address;
        Phone = phone;
        Picture = picture;
        IdCard = idCard;
        Note = note;
        Available = available; 
    }
}
