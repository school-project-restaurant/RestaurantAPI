using Microsoft.AspNetCore.Identity;

namespace Lume.Domain.Entities;

public class Customer : IdentityUser
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public List<int>? Reservations { get; set; }
}