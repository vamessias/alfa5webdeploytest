using Microsoft.Extensions.Localization;
using Alfa5.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Alfa5.Blazor;

[Dependency(ReplaceServices = true)]
public class Alfa5BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Alfa5Resource> _localizer;

    public Alfa5BrandingProvider(IStringLocalizer<Alfa5Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
