using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace EasyAbp.Abp.LoginUi.Pages;

public class IndexModel : LoginUiPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
