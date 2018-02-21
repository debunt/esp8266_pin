using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace esp8266_pin.Models.Commands
{
    public class SubscribeCommand : Command
    {
        public override string Name => "subscribe";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            AppSettings.My_Chat_Id = chatId;

            //TODO: Bot logic -_-
            client.SendTextMessageAsync(chatId, String.Format("Подписка на уведомления. \n chatId = {0}", AppSettings.My_Chat_Id));
        }
    }
}