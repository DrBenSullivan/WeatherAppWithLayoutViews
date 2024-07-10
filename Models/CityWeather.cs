namespace WeatherAppWithLayoutViews.Models
{
	public class CityWeather
	{
		public string CityUniqueCode { get; set; } = String.Empty;
		public string CityName { get; set; } = String.Empty;
		public DateTime DateAndTime { get; set; }
		public int TemperatureFahrenheit { get; set; }
	}
}
