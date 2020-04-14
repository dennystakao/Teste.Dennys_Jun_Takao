using System.Web;
using System.Web.Mvc;

namespace Teste.Dennys_Jun_Takao.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
