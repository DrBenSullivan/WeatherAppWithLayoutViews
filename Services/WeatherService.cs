using WeatherAppWithLayoutViews.Models;

namespace WeatherAppWithLayoutViews.Services
{
	public class WeatherService
	{
		// Hard-coded data as per assignment brief.
		private readonly static List<CityWeather> _hardcodedData = new List<CityWeather>()
		{
			new CityWeather() {
				CityUniqueCode = "LDN",
				CityName = "London",
				DateAndTime = DateTime.Parse("2030-01-01 8:00"),
				TemperatureFahrenheit = 33
			},
			new CityWeather() {
				CityUniqueCode = "NYC",
				CityName = "New York",
				DateAndTime = DateTime.Parse("2030-01-01 3:00"),
				TemperatureFahrenheit = 60
			},
			new CityWeather() {
				CityUniqueCode = "PAR",
				CityName = "Paris",
				DateAndTime = DateTime.Parse("2030-01-01 9:00"),
				TemperatureFahrenheit = 82
			}
		};

		public static List<CityWeather> getData() => _hardcodedData;
	}
}
