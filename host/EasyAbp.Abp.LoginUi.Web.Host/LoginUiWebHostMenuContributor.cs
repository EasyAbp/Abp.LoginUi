using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using EasyAbp.Abp.LoginUi.Web.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.Abp.LoginUi;

public class LoginUiWebHostMenuContributor : IMenuContributor
{
    private readonly IConfiguration _configuration;

    public LoginUiWebHostMenuContributor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.User)
        {
            AddLogoutItemToMenu(context);
        }

        return Task.CompletedTask;
    }

    private void AddLogoutItemToMenu(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<AbpLoginUiResource>();

        context.Menu.Items.Add(new ApplicationMenuItem(
            "Account.Manage",
            l["MyAccount"],
            $"{_configuration["AuthServer:Authority"].EnsureEndsWith('/')}Account/Manage",
            icon: "fa fa-cog",
            order: int.MaxValue - 1001,
            null,
            "_blank"
        ).RequireAuthenticated());

        context.Menu.Items.Add(new ApplicationMenuItem(
            "Account.Logout",
            l["Logout"],
            "~/Account/Logout",
            "fas fa-power-off",
            order: int.MaxValue - 1000
        ).RequireAuthenticated());
    }
}
