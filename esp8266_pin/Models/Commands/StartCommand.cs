using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace esp8266_pin.Models.Commands
{
    public class StartCommand : Command
    {
        public override string Name => "start";


        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Bot logic -_-

            //Используйте String.Format , если необходимо вставить значение объекта, переменной или выражения в другую строку. 
            //Например, можно вставить значение String или Decimal значения в строку, чтобы отобразить ее пользователю как одна строка:
            client.SendTextMessageAsync(chatId, string.Format("Привет, {0}! Меня зовут Еспэшка и я могу управлять по интернету платой {1}!", 
                message.From.FirstName, AppSettings.Name_board));
        }
    }
}