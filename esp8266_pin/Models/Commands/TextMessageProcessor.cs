using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace esp8266_pin.Models.Commands
{
    public class TextMessageProcessor : Command
    {
        public override string Name => "Text";


        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Bot logic -_-

            //Используйте String.Format , если необходимо вставить значение объекта, переменной или выражения в другую строку. 
            //Например, можно вставить значение String или Decimal значения в строку, чтобы отобразить ее пользователю как одна строка:
            client.SendTextMessageAsync(chatId, string.Format("{0}, я всего лишь глупый бот и не могу поддерживать сложные беседы. Список моих понятных мне команд:",
                message.From.FirstName));
        }
    }
}