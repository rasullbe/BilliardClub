using BilliardClub.Api.Entities;

namespace BilliardClub.Api.DTOs;

public class EmployeeSessionUpdateDto
{
    public long SessionInfoId { get; set; }
    public long EmployeeId { get; set; }
    public SessionAction Action { get; set; }
    public DateTime ActionAt { get; set; }
}
