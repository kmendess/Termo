namespace Termo.Domain.Models
{
    public class Word : BaseEntity
    {
        public string Value { get; set; }
        public DateTime Date { get; set; }
    }
}
