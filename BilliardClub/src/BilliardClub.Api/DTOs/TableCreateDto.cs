namespace BilliardClub.Api.DTOs;

public class TableCreateDto
{
    public string TableName { get; set; }
    public int TableNumber { get; set; }
    public bool IsAvailable { get; set; }
    public decimal PricePerHour { get; set; }
}
