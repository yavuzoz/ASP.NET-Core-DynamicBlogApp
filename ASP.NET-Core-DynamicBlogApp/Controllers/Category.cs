using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_DynamicBlogApp.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
