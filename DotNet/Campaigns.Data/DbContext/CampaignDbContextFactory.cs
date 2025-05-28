public class CampaignDbContextFactory : IDesignTimeDbContextFactory<CampaignDbContext>
{
    public CampaignDbContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        // Add user secrets - requires a reference to Microsoft.Extensions.Configuration.UserSecrets
        builder.AddUserSecrets(Assembly.GetExecutingAssembly(), optional: true);

        var configuration = builder.Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<CampaignDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new CampaignDbContext(optionsBuilder.Options);
    }
}
