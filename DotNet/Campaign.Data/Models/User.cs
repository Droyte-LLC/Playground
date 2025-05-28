namespace Campaigns.Data.Models;

public class User
{
  [Key]
  public int UserId { get; set; }
  public string Name { get; set; } = default!;
  public ICollection<Campaign> Campaigns { get; set; } = default!;
  public ICollection<Contribution> Contributions { get; set; } = default!;
}