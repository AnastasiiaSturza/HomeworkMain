using Microsoft.VisualBasic;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

var client = new TelegramBotClient("6301861699:AAGGQTyb8V3tbi1UHUnI9-X1ipQU_4doUeo");
client.StartReceiving(Update, Error);

Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
{
    throw new NotImplementedException();
}

async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
{
    var message = update.Message;
    if(message.Text != null)
    {
        if (message.Text.ToLower().Contains("hello"))
        {
            Console.WriteLine($"I got a message: {message.Text}");
            await botClient.SendTextMessageAsync(message.Chat.Id, "Hello, my friend", replyToMessageId: message.MessageId); /*replyMarkup: GetButtons()*/
            return;
        }
    }
}

 //static IReplyMarkup GetButtons()
 //{
 //   return new ReplyKeyboardMarkup
 //   {
 //       Keyboard = new List<List<KeyboardButton>>
 //       {
 //       new List<KeyboardButton>{new KeyboardButton{ Text = "Hello"} , new KeyboardButton {Text = "Check" } },
 //       new List<KeyboardButton>{new KeyboardButton{ Text = "123"} , new KeyboardButton {Text = "456" } },
 //       }
 //   };
 //}

Console.ReadLine();
