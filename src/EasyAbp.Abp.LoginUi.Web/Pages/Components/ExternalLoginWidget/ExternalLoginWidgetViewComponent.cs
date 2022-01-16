using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.Abp.LoginUi.Web.Pages.Components.ExternalLoginWidget;

public class ExternalLoginWidgetViewComponent : AbpViewComponent
{
    public IViewComponentResult Invoke(ExternalLoginWidgetModel model)
    {
        return View("Default", model);
    }
}