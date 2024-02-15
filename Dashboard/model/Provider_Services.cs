
public class ProviderServices
{
    public string id { get; set; }
    public Service service { get; set; }
    public Provider privder { get; set; }
    public string note { get; set; }

    public ProviderServices(string id, Service service, Provider provider, string note)
    {
        this.id = id;
        this.service = service;
        this.privder = provider;
        this.note = note;


    }
}
