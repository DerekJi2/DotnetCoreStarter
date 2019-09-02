using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreStarter.Utilities.ActionFilters
{
    public interface IAuthActionFilter : IActionFilter, IResultFilter
    {
    }
}
