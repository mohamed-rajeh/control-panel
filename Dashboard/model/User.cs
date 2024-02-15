using System;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime Date { get; set; }
    public Boolean Gender { get; set; }
    public string Password { get; set; }
    public Address Address { get; set; }
    public bool Availbale { get; set; }

    public User(string id, string name, string phone, DateTime date,
        bool gender, string password, Address address, bool availbale)
    {
        Id = id;
        Name = name;
        Phone = phone;
        Date = date;
        Gender = gender;
        Password = password;
        Address = address;
        Availbale = availbale;
    }

    public  void Block(User user)
    {
        DatabaseManager dbManager = new DatabaseManager();


    }

}

