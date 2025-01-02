using Alfa5.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Alfa5.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class Alfa5PublicPageModel : AbpPageModel
{
    protected Alfa5PublicPageModel()
    {
        LocalizationResourceType = typeof(Alfa5Resource);
    }
}
