namespace JurisTempus.Data.Entities
{
    public class Case
    {
        public int Id { get; set; }
        public string FileNumber { get; set; }
        public CaseStatus Status { get; set; }

        public Client Client { get; set; }
    }
}
