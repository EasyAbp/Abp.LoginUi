using Volo.Abp.Bundling;

namespace EasyAbp.Abp.LoginUi.Blazor.Host;

public class LoginUiBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
