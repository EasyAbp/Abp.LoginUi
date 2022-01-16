using EasyAbp.Abp.LoginUi.Web.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Abp.LoginUi.Pages;

public abstract class LoginUiPageModel : AbpPageModel
{
    protected LoginUiPageModel()
    {
        LocalizationResourceType = typeof(AbpLoginUiResource);
    }
}
