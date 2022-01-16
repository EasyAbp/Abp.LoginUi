using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EasyAbp.Abp.LoginUi.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class LoginUiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LoginUi";
}
