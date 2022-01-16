using System.Collections.Generic;
using Volo.Abp.Account.Web.Pages.Account;

namespace EasyAbp.Abp.LoginUi.Web.Pages.Components.ExternalLoginWidget;

public class ExternalLoginWidgetModel
{
    public IEnumerable<LoginModel.ExternalProviderModel> VisibleExternalProviders { get; set; }
    
    public string ReturnUrl { get; set; }
    
    public string ReturnUrlHash { get; set; }

    public ExternalLoginWidgetModel()
    {
        VisibleExternalProviders = new List<LoginModel.ExternalProviderModel>();
    }
    
    public ExternalLoginWidgetModel(IEnumerable<LoginModel.ExternalProviderModel> visibleExternalProviders, string returnUrl, string returnUrlHash)
    {
        VisibleExternalProviders = visibleExternalProviders;
        ReturnUrl = returnUrl;
        ReturnUrlHash = returnUrlHash;
    }
}