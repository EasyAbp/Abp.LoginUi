using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using EasyAbp.Abp.LoginUi.Localization;
using Volo.Abp.Account;
using Volo.Abp.Account.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.Abp.LoginUi;

[DependsOn(
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpValidationModule)
)]
public class AbpLoginUiSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpLoginUiSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<LoginUiResource>("en")
                .AddBaseTypes(typeof(AccountResource))
                .AddVirtualJson("/EasyAbp/Abp/LoginUi/Localization");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("EasyAbpAbpLoginUi", typeof(LoginUiResource));
        });
    }
}
