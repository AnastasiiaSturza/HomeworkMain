using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Serialization;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotMain21._08;

using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using System.Net;
using Newtonsoft.Json;
using TelegramBotMain21._08;

namespace TelegramBotMain21._08
{
    public class WeatherClient
    {
        public WeatherResponse Getweather(String city)
        {
            var defaultweatherUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=c50cacd4f45cdc4cf364a3230306942e";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(defaultweatherUrl);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            return weatherResponse;
        }
    }
}
