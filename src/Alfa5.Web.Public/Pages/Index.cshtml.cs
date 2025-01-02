using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Alfa5.Web.Public.Pages;

public class IndexModel : Alfa5PublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
