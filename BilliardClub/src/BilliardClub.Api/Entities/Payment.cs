using System;

namespace BilliardClub.Api.Entities;

public class Payment
{
    public long PaymentId { get; set; }
    public long SessionInfoId { get; set; }
    public SessionInfo SessionInfo { get; set; }

    public decimal Amount { get; set; }
    public PaymentMethod Method { get; set; }
    public DateTime PaidAt { get; set; }

    public long? ProcessedByEmployeeId { get; set; }
    public Employee? ProcessedBy { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
