namespace datingAppAPI.Entities;

public class AppUser
{
    public long Id { get; set; }
    public string? UserName { get; set;}
    public byte[] passwordHash { get; set; }
    public byte[] passwordSalt { get; set; }
}
