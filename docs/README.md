# Abp.LoginUi

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FEasyAbp%2FAbp.LoginUi%2Fmaster%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/EasyAbp.Abp.LoginUi.Web.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.LoginUi.Web)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.Abp.LoginUi.Web.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.LoginUi.Web)
[![Discord online](https://badgen.net/discord/online-members/xyg8TrRa27?label=Discord)](https://discord.gg/xyg8TrRa27)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/Abp.LoginUi?style=social)](https://www.github.com/EasyAbp/Abp.LoginUi)

An ABP module that provides enhanced login pages.

![demo.gif](/docs/images/WithMicrosoft.apng)

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * EasyAbp.Abp.LoginUi.Web

1. Add `DependsOn(typeof(AbpLoginUiWebModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-module-dependencies))

## Usage

### External Login UI

1. Find and install the social authentication provider packages you want.
   * https://github.com/dotnet/aspnetcore/tree/main/src/Security/Authentication
   * https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers

2. Configure the providers, for example the Microsoft account:
   ```c#
   public override void ConfigureServices(ServiceConfigurationContext context)
   {
       context.Services.AddAuthentication()
           .AddMicrosoftAccount(options =>
           {
               options.ClientId = "8208d98e-400d-4ce9-89ba-d92610c67e13";
               options.ClientSecret = "hsrMP46|_kfkcYCWSW516?%";
           });
   }
   ```

### Local Login Extensions

Coming soon. We want to further enhance the login page so that developers can implement [phone number login](https://github.com/EasyAbp/Abp.PhoneNumberLogin) UI and more. 

## Road map

- [ ] Enhanced local login.
