using System.Web;
using System.Web.Mvc;

namespace Armoniasoft.Corman.Net.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
