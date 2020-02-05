using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WpfWeatherApi.Services;

namespace WpfWeatherApi.ClassBiz
{
    public class BizClass
    {
        
        public string GetTempatureBasedOnCity(string city)
        {
            OpenWeatherService openWeather = new OpenWeatherService();
            openWeather.AppId = "3654de113ecd4a2bf4e4144d9403491b";
            openWeather.City = city;
            double temp = 0.0;
            try
            {
                temp = openWeather.GetTempature();
            }
            catch (WebException)
            {
                return "N/A";
            }
            return $"{temp}°C";
        }

    }
}
