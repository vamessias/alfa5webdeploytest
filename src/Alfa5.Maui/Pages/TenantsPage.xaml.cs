using Alfa5.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Alfa5.Maui.Pages;

public partial class TenantsPage : ContentPage, ITransientDependency
{
	public TenantsPage(TenantsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
