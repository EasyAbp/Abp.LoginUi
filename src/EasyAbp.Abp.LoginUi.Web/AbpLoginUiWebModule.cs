using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using EasyAbp.Abp.LoginUi.Web.Localization;
using Volo.Abp.Account.Localization;
using Volo.Abp.Account.Web;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.Abp.LoginUi.Web;

[DependsOn(
    typeof(AbpAccountWebModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule)
)]
public class AbpLoginUiWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(AbpLoginUiResource), typeof(AbpLoginUiWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpLoginUiWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpLoginUiWebModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpLoginUiResource>("en")
                .AddBaseTypes(typeof(AccountResource))
                .AddVirtualJson("/Localization/EasyAbp/Abp/LoginUi");
        });

        Configure<RazorPagesOptions>(options =>
        {
            //Configure authorization.
        });
    }
}
