using CommunityToolkit.Mvvm.Input;
using Volo.Abp.DependencyInjection;
using Alfa5.Maui.Oidc;

namespace Alfa5.Maui.ViewModels;

public partial class MainPageViewModel : Alfa5ViewModelBase, ITransientDependency
{
    protected ILoginService LoginService { get; }
    
    public MainPageViewModel(ILoginService loginService)
    {
        LoginService = loginService;
    }

    [RelayCommand]
    async Task SeeAllUsers()
    {
        await Shell.Current.GoToAsync("///users");
    }
    
    [RelayCommand]
    async Task Login()
    {
        await Shell.Current.GoToAsync("///login");
    }
}
