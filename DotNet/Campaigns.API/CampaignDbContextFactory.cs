namespace Campaigns.API;

using System.IO;

public class CampaignDbContextDbContextFactory : IDesignTimeDbContextFactory<CampaignDbContext>
{
	public CampaignDbContext CreateDbContext(string[] args)
	{
		var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddUserSecrets<Program>() // 👈 This works because it's in the same project
				//.AddJsonFile("appsettings.json", optional: true)
				.Build();

		var connectionString = configuration.GetConnectionString("DefaultConnection");

		var optionsBuilder = new DbContextOptionsBuilder<CampaignDbContext>();
		optionsBuilder.UseSqlServer(connectionString);

		return new CampaignDbContext(optionsBuilder.Options);
	}
}
