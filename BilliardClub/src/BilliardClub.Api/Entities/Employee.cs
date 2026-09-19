using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BilliardClub.Api.Entities;

public class Employee
{
    public long EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } = string.Empty;
    [Required] public string PhoneNumber { get; set; }
    public Role? Role { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }


    public ICollection<EmployeeSession> OpenedSessions { get; set; } = new List<EmployeeSession>();
    public ICollection<Payment> ProcessedPayments { get; set; } = new List<Payment>();
}
