using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_10.Filters
{
    

    public class DivideByZeroExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is DivideByZeroException)
            {
                filterContext.ExceptionHandled = true;

                filterContext.Result = new ViewResult
                {
                    ViewName = "DivideByZeroError"
                };
            }
        }
    }

}