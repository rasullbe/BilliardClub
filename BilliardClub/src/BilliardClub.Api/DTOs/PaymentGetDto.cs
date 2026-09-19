using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class PaymentGetDto
{
    public long PaymentId { get; set; }
    public long SessionInfoId { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Method { get; set; }
    public DateTime PaidAt { get; set; }
    public long? ProcessedByEmployeeId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
