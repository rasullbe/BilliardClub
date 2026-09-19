using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class ReservationGetDto
{
    public long ReservationId { get; set; }
    public long TableId { get; set; }
    public long? CustomerId { get; set; }
    public DateTime ReservedFrom { get; set; }
    public DateTime ReservedTo { get; set; }
    public ReservationStatus Status { get; set; }
    public long? CreatedByEmployeeId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
