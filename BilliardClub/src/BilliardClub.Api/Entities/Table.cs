using System;
using System.Collections.Generic;

namespace BilliardClub.Api.Entities;

public class Table
{
    public long TableId { get; set; }
    public string TableName { get; set; }
    public int TableNumber { get; set; }
    public bool IsAvailable { get; set; }
    public decimal PricePerHour { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public ICollection<TableSession> Sessions { get; set; } = new List<TableSession>();
}
