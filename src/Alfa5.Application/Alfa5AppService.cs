using Alfa5.Localization;
using Volo.Abp.Application.Services;

namespace Alfa5;

/* Inherit your application services from this class.
 */
public abstract class Alfa5AppService : ApplicationService
{
    protected Alfa5AppService()
    {
        LocalizationResource = typeof(Alfa5Resource);
    }
}
