using System;

namespace BilliardClub.Api.Entities;

public class EmployeeSession
{
    public long EmployeeSessionId { get; set; }

    public long SessionInfoId { get; set; }
    public SessionInfo SessionInfo { get; set; }

    public long EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public SessionAction Action { get; set; }
    public DateTime ActionAt { get; set; }
}
