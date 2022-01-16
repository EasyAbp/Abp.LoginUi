using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.Abp.LoginUi.EntityFrameworkCore;

public class LoginUiHttpApiHostMigrationsDbContext : AbpDbContext<LoginUiHttpApiHostMigrationsDbContext>
{
    public LoginUiHttpApiHostMigrationsDbContext(DbContextOptions<LoginUiHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
