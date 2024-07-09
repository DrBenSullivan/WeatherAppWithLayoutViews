using Microsoft.AspNetCore.Mvc;

namespace WeatherAppWithLayoutViews.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
