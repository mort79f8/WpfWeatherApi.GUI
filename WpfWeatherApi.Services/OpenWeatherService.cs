using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WpfWeatherApi.Services.Entities;

namespace WpfWeatherApi.Services
{
    public class OpenWeatherService
    {
        private const string api = "http://api.openweathermap.org/data/2.5/weather?units=metric";
        public string City { get; set; }
        public string AppId { get; set; }
        public string Url
        {
            get
            {
                return $"{api}&appid={AppId}&q={City}";
            }
        }

        private OpenWeather GetOpenWeather()
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(Url);
                OpenWeather weather = JsonConvert.DeserializeObject<OpenWeather>(json);
                return weather;
            }
        }

        public double GetTempature()
        {
            return GetOpenWeather().Main.Temp;
        }
    }
}
