using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class EmployeeGetDto
{
    public long EmployeeId { get; set; }
    public string FullName { get; set; }
    public Role? Role { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
