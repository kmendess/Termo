namespace Termo.Domain.Models
{
    public class Move : BaseEntity
    {
        public string Word { get; set; }
        public Guid MatchId { get; set; }
    }
}
