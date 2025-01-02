using Alfa5.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Alfa5.Maui.Pages;

public partial class ChangePasswordPage : ContentPage, ITransientDependency
{
	public ChangePasswordPage(ChangePasswordViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}