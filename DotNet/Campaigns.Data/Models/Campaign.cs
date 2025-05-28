namespace Campaigns.Data.Models;

public class Campaign
{
  [Key]
  public int CampaignId { get; set; }
  public string Title { get; set; } = default!;
  public int OwnerId { get; set; }
  public User Owner { get; set; } = default!;
  public ICollection<Contribution> Contributions { get; set; } = default!;
}