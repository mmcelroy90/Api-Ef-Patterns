using API.Dtos;
using AutoMapper;

namespace API.Profiles
{
    public class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile()
        {
            CreateMap<WeatherForecast, GetWeatherForecastResponse>()
                .ForMember(dest => dest.Date, source => source.MapFrom(s => s.Date.ToString("MM/dd/yyyy")));
        }
    }
}
