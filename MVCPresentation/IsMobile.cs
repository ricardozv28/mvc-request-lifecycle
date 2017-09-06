using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace MVCPresentation
{
    public class IsMobile : Attribute, IActionConstraint
    {
        //public int Order => throw new NotImplementedException();
        public int Order => 0;

        public bool Accept(ActionConstraintContext context)
        {
            //throw new NotImplementedException();
            return context.RouteContext.HttpContext
                .Request.Headers["User-Agent"].Any(x => x.Contains("Android"));

        }
    }
}
