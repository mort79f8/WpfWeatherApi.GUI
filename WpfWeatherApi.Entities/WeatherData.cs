using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeatherApi.Entities
{
    public class WeatherData
    {
        private string city;
        private string temperature;

        public string City { get => city; set => city = value; }
        public string Temperature { get => temperature; set => temperature = value; }

        public WeatherData()
        { 
        }

        public WeatherData(string city, string temperature)
        {
            City = city;
            Temperature = temperature;
        }
    }
}
