using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCPresentation
{
    public class ResultLog : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Debug.WriteLine("Before the result execution");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine("After the result Execution");
        }
    }
}
