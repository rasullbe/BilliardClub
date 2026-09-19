using System;

namespace BilliardClub.Api.Entities;

public class SessionInfo
{
    public long SessionInfoId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public decimal PricePerHour { get; set; }
    public SessionStatus Status { get; set; } = SessionStatus.Open;

    public decimal TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
