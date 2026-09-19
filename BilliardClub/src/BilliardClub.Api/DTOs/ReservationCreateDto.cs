using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class ReservationCreateDto
{
    public long TableId { get; set; }
    public long? CustomerId { get; set; }
    public DateTime ReservedFrom { get; set; }
    public DateTime ReservedTo { get; set; }
    public ReservationStatus Status { get; set; } = ReservationStatus.Pending;
    public long? CreatedByEmployeeId { get; set; }
}
