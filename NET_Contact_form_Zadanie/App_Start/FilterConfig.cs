using System.Web;
using System.Web.Mvc;

namespace NET_Contact_form_Zadanie
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
