public class UserInteraction
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime Timestamp { get; set; }
    public bool Purchased { get; set; }
    public int? Rating { get; set; } // Nullable to allow for no rating
}