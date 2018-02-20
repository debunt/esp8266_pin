using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace esp8266_pin.Models.Commands
{
    //наследование от класса Command 
    public class HelloCommand : Command
    {
        /*Модификатор override требуется для расширения или изменения абстрактной 
         * или виртуальной реализации унаследованного метода, свойства, индексатора или события.
         */
        public override string Name => "hello";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Bot logic -_-
            client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId);
        }
    }
}