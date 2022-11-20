using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.Abp.LoginUi;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class LoginUiInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LoginUiInstallerModule>();
        });
    }
}
