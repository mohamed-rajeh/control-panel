using System;
namespace Dashboard.model
{
    public class Admin
    {
        public static string AdminName { get; set;}
        public string id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string note { get; set; }

        // Constructor
        public Admin(string id, string name, string userName, string password, string phone, string note)
        {
            this.id = id;
            this.name = name;
            this.userName = userName;
            this.password = password;
            this.phone = phone;
            this.note = note;

        }

      
    }
}
