namespace Campaigns.Data.Models;

public class Contribution
{
  [Key]
  public int ContributionId { get; set; }
  public decimal Amount { get; set; }
  public int UserId { get; set; }
  public User User { get; set; } = default!;
  public int CampaignId { get; set; }
  public Campaign Campaign { get; set; } = default!;
}