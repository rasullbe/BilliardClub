using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class PaymentUpdateDto
{
    public long SessionInfoId { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Method { get; set; }
    public DateTime PaidAt { get; set; }
    public long? ProcessedByEmployeeId { get; set; }
}
