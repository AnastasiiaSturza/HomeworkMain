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

var client = new TelegramBotClient("6301861699:AAFLmIMh8_PoYx5JHVAtWAbeQIzvGoA4Mvg");
using CancellationTokenSource cts = new();
var weatherClient = new WeatherClient();
string cityFromChat = "";
var dataBase = new BotDBContext();
dataBase.Database.EnsureCreated();  // if db wasn;t created - create, if created - use db;

// StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
ReceiverOptions receiverOptions = new()
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
};

client.StartReceiving(updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    receiverOptions: receiverOptions,
    cancellationToken: cts.Token);

var me = await client.GetMeAsync();


async Task HandlePollingErrorAsync(ITelegramBotClient arg1, Exception ex, CancellationToken arg3)
{
    await client.SendTextMessageAsync(971891573, $"ERRORROROROOROR {ex.Message}");
   

}

async Task HandleUpdateAsync(ITelegramBotClient client, Update args, CancellationToken cst)
{
    var message = args.Message;



    if (message != null)
    {
        Console.WriteLine($"I got a message from {message.Chat.FirstName}: {message.Text}");


        if (message.Text == "Set City")
        {
            var addCity = client.SendTextMessageAsync(chatId: message.Chat.Id,
                   "Type the ciy you need get weather using next comand : /city (Name of the city)", replyMarkup: BotButtons.GetButtons());
            return;
        }
        if (message.Text.Contains("/city"))
        {
            try
            {
                var city = message.Text.Substring(6);

                var user= dataBase.Users.Where(x => x.TelegramId == message.Chat.Id).FirstOrDefault();
                if (user == null)
                {
                    var userEntity = new UserEntyty()
                    {
                        City = city,
                        TelegramId = message.Chat.Id
                    };

                    await dataBase.Users.AddAsync(userEntity, cst);
                }
                else 
                { 
                user.City=city;
                   
                }
                
                await dataBase.SaveChangesAsync(cst);

            }
            catch 
            { 
                
            }
            
            return;
        }
        
        if (message.Text == "Get weather")
        {
            try
            {
                var user = dataBase.Users.Where(x => x.TelegramId == message.Chat.Id).FirstOrDefault();
                if (user == null || user.City == null)
                {
                    await client.SendTextMessageAsync(chatId: message.Chat.Id, $"Please set City");
                    return;
                }
               
                

                var weather = weatherClient.Getweather(user.City);
                var weatherFromCity = client.SendTextMessageAsync(chatId: message.Chat.Id, $" The weather in {weather.Name} is {Math.Round(weather.Main.Temp)} °C "
                    , replyMarkup: BotButtons.GetButtons());
                var icon = weather.Weather.FirstOrDefault().Icon;

                var file = new InputFileUrl($"https://openweathermap.org/img/wn/{icon}@2x.png");
                await client.SendPhotoAsync(chatId: message.Chat.Id, photo: file);
            }
            catch 
            { 
            
            }
            return;
        }
        else
        {
            await client.SendTextMessageAsync(message.Chat.Id, $"Hello, {message.Chat.FirstName}. Please choose the option",
               replyMarkup: BotButtons.GetButtons());
        }

    }
}



Console.ReadLine();

