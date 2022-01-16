using EasyAbp.Abp.LoginUi.Web.Localization;
using EasyAbp.Abp.LoginUi.Web.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Abp.LoginUi.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LoginUiPageModel : AbpPageModel
{
    protected LoginUiPageModel()
    {
        LocalizationResourceType = typeof(AbpLoginUiResource);
        ObjectMapperContext = typeof(AbpLoginUiWebModule);
    }
}
