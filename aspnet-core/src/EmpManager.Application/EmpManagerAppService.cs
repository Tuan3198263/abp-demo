using System;
using System.Collections.Generic;
using System.Text;
using EmpManager.Localization;
using Volo.Abp.Application.Services;

namespace EmpManager;

/* Inherit your application services from this class.
 */
public abstract class EmpManagerAppService : ApplicationService
{
    protected EmpManagerAppService()
    {
        LocalizationResource = typeof(EmpManagerResource);
    }
}
