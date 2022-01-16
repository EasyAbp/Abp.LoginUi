using EasyAbp.Abp.LoginUi.Web.Localization;
using Volo.Abp.AspNetCore.Components;

namespace EasyAbp.Abp.LoginUi.Blazor.Server.Host;

public abstract class LoginUiComponentBase : AbpComponentBase
{
    protected LoginUiComponentBase()
    {
        LocalizationResource = typeof(AbpLoginUiResource);
    }
}
