using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_DynamicBlogApp.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm= new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			var values = bm.GetList();
			return View(values);
		}
	}
}
