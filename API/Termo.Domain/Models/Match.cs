namespace Termo.Domain.Models
{
    public class Match : BaseEntity
    {
        public bool Success { get; set; }
        public int DurationInSeconds { get; set; }
        public Guid UserId { get; set; }
        public Guid WordId { get; set; }

        public User User { get; set; }
        public Word Word { get; set; }
        public IEnumerable<Move> Moves { get; set; }
    }
}
