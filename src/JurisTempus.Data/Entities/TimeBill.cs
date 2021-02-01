using System;

namespace JurisTempus.Data.Entities
{
    public class TimeBill
    {
        public int Id { get; set; }
        public DateTime WorkDate { get; set; }
        public int TimeSegments { get; set; }
        public decimal Rate { get; set; }
        public string WorkDescription { get; set; }

        public Employee Employee { get; set; }
        public Case Case { get; set; }
    }
}
