namespace DataAccesLayer.Models;

public class Client:BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = new();
}
