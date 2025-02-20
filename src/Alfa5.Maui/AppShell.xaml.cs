﻿using Alfa5.Maui.Pages;
using Alfa5.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Alfa5.Maui;

public partial class AppShell : Shell, ITransientDependency
{
    public AppShell(ShellViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();

        Routing.RegisterRoute(nameof(IdentityUserCreateModalPage), typeof(IdentityUserCreateModalPage));
        Routing.RegisterRoute(nameof(IdentityUserEditModalPage), typeof(IdentityUserEditModalPage));
        Routing.RegisterRoute(nameof(TenantCreatePage), typeof(TenantCreatePage));
        Routing.RegisterRoute(nameof(TenantEditPage), typeof(TenantEditPage));
        Routing.RegisterRoute(nameof(ProfilePicturePage), typeof(ProfilePicturePage));
        Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
        Routing.RegisterRoute(nameof(LoginOrLogoutPage), typeof(LoginOrLogoutPage));
    }
}
