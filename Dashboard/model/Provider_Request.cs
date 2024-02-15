using System;


public class ProviderRequest
{
    public string id { get; set; }
    public string name { get; set; }
    public string phone { get; set; }
    public string picuter { get; set; }
    public Address addres { get; set; }
    public string id_card { get; set; }

    public DateTime date { get; set; }
    public Service service { get; set; }

    // Constructor to initialize properties
    public ProviderRequest(string id, string name, string phone, string picuter,
                            Address addres, string id_card, DateTime date,
                             Service service)
    {
        this.id = id;
        this.name = name;
        this.phone = phone;
        this.picuter = picuter;
        this.addres = addres;
        this.id_card = id_card;
        this.date = date;
        this.service = service;
    }
}

