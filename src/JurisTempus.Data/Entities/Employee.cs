using System.Collections.Generic;

namespace JurisTempus.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string GovernmentId { get; set; }
        public decimal BillingRate { get; set; }

        public ICollection<TimeBill> TimeBilling { get; set; }
    }
}
