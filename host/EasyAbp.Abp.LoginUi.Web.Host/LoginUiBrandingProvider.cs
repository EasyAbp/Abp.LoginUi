using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.Abp.LoginUi;

[Dependency(ReplaceServices = true)]
public class LoginUiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LoginUi";
}
