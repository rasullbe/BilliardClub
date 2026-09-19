using System;
using System.Collections.Generic;

namespace BilliardClub.Api.Entities;

public class Customer
{
    public long CustomerId { get; set; }
    public string? FirstName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public ICollection<CustomerSession> Sessions { get; set; } = new List<CustomerSession>();
}
