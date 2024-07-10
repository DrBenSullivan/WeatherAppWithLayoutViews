using Microsoft.AspNetCore.Mvc;
using WeatherAppWithLayoutViews.Services;
using WeatherAppWithLayoutViews.Models;

namespace WeatherAppWithLayoutViews.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			List<CityWeather> model = WeatherService.getData();
			return View(model);
		}

		[Route("/weather/{cityIdentifier:alpha:length(3)}")]
		public IActionResult Weather(string cityIdentifier)
		{
			CityWeather? cityModel = WeatherService.getData()
				.Where(c => c.CityUniqueCode ==  cityIdentifier.ToUpper())
				.FirstOrDefault();

			if (cityModel == null)
			{
				HttpContext.Response.StatusCode = 404;
				ViewBag.Status = "404: NOT FOUND";
				ViewBag.ErrorMessage = $"An incorrect 3-letter unique city code was provided.\nProvided: {cityIdentifier}";
				return View("Error", "Shared");
			}

			CityWeatherPartialViewModel model = new CityWeatherPartialViewModel()
			{
				CityWeatherData = cityModel,
				IsSelected = true
			};

			return View(model);
		}

		[Route("weather")]
		[Route("/weather/{invalidValue}")]
		public IActionResult InvalidWeather(string? invalidValue)
		{
			HttpContext.Response.StatusCode = 400;
			ViewBag.Status = "400: BAD REQUEST";
			ViewBag.ErrorMessage = invalidValue == null
				? $"A 3-letter unique city code was not provided"
				: $"The unique city code must be exactly 3-letters long.\nProvided: {invalidValue}";
			return View("Error", "Shared");
		}
	}
}
