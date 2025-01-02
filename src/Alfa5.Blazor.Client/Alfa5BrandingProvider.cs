using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Alfa5.Localization;

namespace Alfa5.Blazor.Client;

public class Alfa5BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Alfa5Resource> _localizer;

    public Alfa5BrandingProvider(IStringLocalizer<Alfa5Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
