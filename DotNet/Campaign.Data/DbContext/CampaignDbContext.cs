namespace Campaigns.Data.DbContext;

public class CampaignDbContext : Microsoft.EntityFrameworkCore.DbContext
{
  public CampaignDbContext(DbContextOptions<CampaignDbContext> options) : base(options) { }

  public DbSet<User> Users { get; set; }
  public DbSet<Campaign> Campaigns { get; set; }
  public DbSet<Contribution> Contributions { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    // Fluent API for relationships
    modelBuilder.Entity<Campaign>()
        .HasOne(c => c.Owner)
        .WithMany(u => u.Campaigns)
        .HasForeignKey(c => c.OwnerId);

    modelBuilder.Entity<Contribution>()
        .HasOne(c => c.User)
        .WithMany(u => u.Contributions)
        .HasForeignKey(c => c.UserId);

    modelBuilder.Entity<Contribution>()
        .HasOne(c => c.Campaign)
        .WithMany(c => c.Contributions)
        .HasForeignKey(c => c.CampaignId);

    // Seed data
    modelBuilder.Entity<User>().HasData(
        new User { UserId = 1, Name = "Alice" },
        new User { UserId = 2, Name = "Bob" }
    );

    modelBuilder.Entity<Campaign>().HasData(
        new Campaign { CampaignId = 1, Title = "Save the Forest", OwnerId = 1 }
    );

    modelBuilder.Entity<Contribution>().HasData(
        new Contribution { ContributionId = 1, Amount = 100, UserId = 2, CampaignId = 1 }
    );
  }
}
