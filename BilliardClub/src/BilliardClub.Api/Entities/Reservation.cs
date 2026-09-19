using System;
using System.Collections.Generic;

namespace BilliardClub.Api.Entities;

public class Reservation
{
    public long ReservationId { get; set; }
    public long TableId { get; set; }
    public Table Table { get; set; }

    public long? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public DateTime ReservedFrom { get; set; }
    public DateTime ReservedTo { get; set; }

    public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

    public long? CreatedByEmployeeId { get; set; }
    public Employee? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
