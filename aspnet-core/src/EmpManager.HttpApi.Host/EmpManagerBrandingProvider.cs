using Microsoft.Extensions.Localization;
using EmpManager.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EmpManager;

[Dependency(ReplaceServices = true)]
public class EmpManagerBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<EmpManagerResource> _localizer;

    public EmpManagerBrandingProvider(IStringLocalizer<EmpManagerResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
