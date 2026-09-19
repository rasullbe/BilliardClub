namespace BilliardClub.Api.DTOs;

public class TableGetDto
{
    public long TableId { get; set; }
    public string TableName { get; set; }
    public int TableNumber { get; set; }
    public bool IsAvailable { get; set; }
    public decimal PricePerHour { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
