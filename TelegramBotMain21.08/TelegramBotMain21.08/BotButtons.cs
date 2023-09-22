using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotMain21._08
{
    public static class BotButtons
    {

        public static IReplyMarkup GetButtons()
        {
            var Keyboard = new List<KeyboardButton> { new KeyboardButton("Set City") ,
            new KeyboardButton("Get weather")};
                

            return new ReplyKeyboardMarkup(Keyboard)
            {
                ResizeKeyboard = true
            };
        }




    }
}
