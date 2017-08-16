using System.Web;
using System.Web.Mvc;

namespace Action_Filters_WKSP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new TestActionFilter());
        }
    }
}
