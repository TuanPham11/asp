using System.Web;
using System.Web.Mvc;

namespace PhamChanhTuan_2122110283
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
