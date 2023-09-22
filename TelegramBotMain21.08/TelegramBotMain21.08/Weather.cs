using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotMain21._08
{
    public class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
        public List<Weather> Weather { get; set; }
    }

    public class Weather
    {
        public string Icon { get; set; }
    }
}
