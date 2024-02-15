using System;

public class Order
{
    public string id { get; set; }
    public User customer { get; set; }
    public Provider provider { get; set; }
    public Service service { get; set; }
    public DateTime date { get; set; }
    public Order_State state { get; set; }
    public string note { get; set; }

    // Constructor
    public Order(string id, User customer, Provider provider, Service service, DateTime date, Order_State state, string note)
    {
        this.id = id;
        this.customer = customer;
        this.provider = provider;
        this.service = service;
        this.date = date;
        this.state = state;
        this.note = note;


    }
}
