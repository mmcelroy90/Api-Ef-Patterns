namespace API.Dtos
{
    public class GetWeatherForecastResponse
    {
        public string Date { get; set; } = String.Empty;

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string? Summary { get; set; }
    }
}
