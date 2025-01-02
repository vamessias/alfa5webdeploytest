using Alfa5.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Alfa5.Maui.Pages;

public partial class IdentityUserCreateModalPage : ContentPage, ITransientDependency
{
    public IdentityUserCreateModalPage(IdentityUserCreateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}