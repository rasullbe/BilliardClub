using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class EmployeeUpdateDto
{
    public string FullName { get; set; }
    public Role? Role { get; set; }
    public bool IsActive { get; set; }
}
