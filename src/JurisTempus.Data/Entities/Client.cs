using System.Collections.Generic;

namespace JurisTempus.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }

        public ICollection<Case> Cases { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
