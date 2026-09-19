using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class SessionInfoUpdateDto
{
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public decimal PricePerHour { get; set; }
    public SessionStatus Status { get; set; }
    public decimal TotalAmount { get; set; }
}
