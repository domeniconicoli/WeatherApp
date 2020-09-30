using System.Collections.Generic;
using System.Net;

namespace WeatherApp.API
{
    class Weather
    {
        private const string getLocationPath = "https://www.metaweather.com/api/location/search/?query=";
        private const string getForecastPath = "https://www.metaweather.com/api/location/";
        private const string imageLocationPath = "https://www.metaweather.com/static/img/weather/png/";

        public static List<LocationResponse.Location> GetLocationWoeid(string location)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString($"{getLocationPath}{location}");
                return LocationResponse.Location.FromJson(json);
            }
        }

        public static ForecastResponse.Weather GetForecast(long woeid)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString($"{getForecastPath}{woeid}");
                return ForecastResponse.Weather.FromJson(json);
            }
        }

        public static string GetImageURL(string weatherStateAbbr)
        {
            return $"{imageLocationPath}{weatherStateAbbr}.png";
        }

    }
}