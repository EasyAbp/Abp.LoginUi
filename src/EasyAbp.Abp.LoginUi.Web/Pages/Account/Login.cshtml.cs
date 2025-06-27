using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Volo.Abp.Account.Web;
using Volo.Abp.Account.Web.Pages.Account;
using Volo.Abp.Identity;

namespace EasyAbp.Abp.LoginUi.Web.Pages.Account;

public class LoginUiLoginModel : LoginModel
{
    public LoginUiLoginModel(IAuthenticationSchemeProvider schemeProvider, IOptions<AbpAccountOptions> accountOptions,
        IOptions<IdentityOptions> identityOptions,
        IdentityDynamicClaimsPrincipalContributorCache identityDynamicClaimsPrincipalContributorCache,
        IWebHostEnvironment webHostEnvironment) : base(schemeProvider, accountOptions, identityOptions,
        identityDynamicClaimsPrincipalContributorCache, webHostEnvironment)
    {
    }
}