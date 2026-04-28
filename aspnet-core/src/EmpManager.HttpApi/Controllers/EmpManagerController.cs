using EmpManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EmpManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EmpManagerController : AbpControllerBase
{
    protected EmpManagerController()
    {
        LocalizationResource = typeof(EmpManagerResource);
    }
}
