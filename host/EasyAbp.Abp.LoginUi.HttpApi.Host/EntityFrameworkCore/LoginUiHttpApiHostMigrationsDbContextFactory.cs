using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EasyAbp.Abp.LoginUi.EntityFrameworkCore;

public class LoginUiHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<LoginUiHttpApiHostMigrationsDbContext>
{
    public LoginUiHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<LoginUiHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("LoginUi"));

        return new LoginUiHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
