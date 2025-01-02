using IdentityModel.OidcClient;

namespace Alfa5.Maui.Oidc;

public interface ILoginService
{
    Task<LoginResult> LoginAsync();

    Task<LogoutResult> LogoutAsync();

    Task<string> GetAccessTokenAsync();

    Task<string> TryRefreshTokenAsync();
}