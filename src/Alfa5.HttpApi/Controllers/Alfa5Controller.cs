using Alfa5.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Alfa5.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Alfa5Controller : AbpControllerBase
{
    protected Alfa5Controller()
    {
        LocalizationResource = typeof(Alfa5Resource);
    }
}
