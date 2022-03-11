using System.Web;
using System.Web.Mvc;

namespace viewbeg_viewdata_tempdata_session
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
