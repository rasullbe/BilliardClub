namespace BilliardClub.Api.Entities;

public class CustomerSession
{
    public long CustomerSessionId { get; set; }
    // Link to the main SessionInfo
    public long SessionInfoId { get; set; }
    public SessionInfo SessionInfo { get; set; }

    // Link to the Customer for quick lookups
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
}
