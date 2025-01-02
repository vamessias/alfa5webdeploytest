using Alfa5.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Alfa5.Maui.Pages;

public partial class TenantCreatePage : ContentPage, ITransientDependency
{
    public TenantCreatePage(TenantCreateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
