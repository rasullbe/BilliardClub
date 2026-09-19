using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class SessionInfoCreateDto
{
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public decimal PricePerHour { get; set; }
    public SessionStatus Status { get; set; } = SessionStatus.Open;
    public decimal TotalAmount { get; set; }
}
