using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCPresentation
{
    public class LogAction : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Action is executing");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action has executed");
        }
    }
}
