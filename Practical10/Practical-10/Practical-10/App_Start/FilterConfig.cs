using System.Web;
using System.Web.Mvc;
using Practical_10.Filters;
namespace Practical_10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new DivideByZeroExceptionFilter());
        }
    }
}
