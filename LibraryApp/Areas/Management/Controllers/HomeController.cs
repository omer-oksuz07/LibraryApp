using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Areas.Management.Controllers
{
	[Area("Management")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
