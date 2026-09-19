namespace BilliardClub.Api.Entities;

public class TableSession
{
    public long TableSessionId { get; set; }
    // Link to the main SessionInfo
    public long SessionInfoId { get; set; }
    public SessionInfo SessionInfo { get; set; }

    // Link to the Table for quick lookups
    public long TableId { get; set; }
    public Table Table { get; set; }
}
