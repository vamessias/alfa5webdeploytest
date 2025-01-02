using Alfa5.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Alfa5.Blazor.Client;

public abstract class Alfa5ComponentBase : AbpComponentBase
{
    protected Alfa5ComponentBase()
    {
        LocalizationResource = typeof(Alfa5Resource);
    }
}
