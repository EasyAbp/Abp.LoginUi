using System.Collections.Generic;

namespace EasyAbp.Abp.LoginUi;

public static class LoginProvidersUi
{
    public static string DefaultButtonClasses = "";

    public static Dictionary<string, LoginProviderUiModel> Providers { get; } = new()
    {
        { "Microsoft", new LoginProviderUiModel { ButtonClasses = "fab fa-microsoft" } },
        { "Facebook", new LoginProviderUiModel { ButtonClasses = "fab fa-facebook-square" } },
        { "Google", new LoginProviderUiModel { ButtonClasses = "fab fa-google" } },
        { "Twitter", new LoginProviderUiModel { ButtonClasses = "fab fa-twitter" } },
        { "Instagram", new LoginProviderUiModel { ButtonClasses = "fab fa-instagram" } },
        { "GitHub", new LoginProviderUiModel { ButtonClasses = "fab fa-github" } },
        { "Weixin", new LoginProviderUiModel { ButtonClasses = "fab fa-weixin" } },
        { "WeChat", new LoginProviderUiModel { ButtonClasses = "fab fa-wechat" } },
        { "QQ", new LoginProviderUiModel { ButtonClasses = "fab fa-qq" } },
    };
    
    public static string GetButtonClasses(string authenticationScheme)
    {
        return Providers.ContainsKey(authenticationScheme)
            ? Providers[authenticationScheme].ButtonClasses
            : DefaultButtonClasses;
    }
}