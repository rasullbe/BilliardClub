namespace BilliardClub.Api.DTOs;

public class CustomerGetDto
{
    public long CustomerId { get; set; }
    public string? FirstName { get; set; }
    public string LastName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
