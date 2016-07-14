using System.Web;
using System.Web.Mvc;

namespace COMP2007___Lesson_9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
