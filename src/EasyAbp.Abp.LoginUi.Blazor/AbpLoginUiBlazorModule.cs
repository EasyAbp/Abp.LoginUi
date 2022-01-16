using Microsoft.Extensions.DependencyInjection;
using EasyAbp.Abp.LoginUi.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.Abp.LoginUi.Blazor;

[DependsOn(
    typeof(AbpLoginUiSharedModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class AbpLoginUiBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpLoginUiBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<LoginUiBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new LoginUiMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpLoginUiBlazorModule).Assembly);
        });
    }
}
