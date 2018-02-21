using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;
using esp8266_pin.Models.Commands;

namespace esp8266_pin.Models.Notifications
{
    public class RequestNotification : Command
    {
        public override string Name => "Request";

        public override void Execute(Message message, TelegramBotClient client)
        {
            //TODO: Bot logic -_-
            client.SendTextMessageAsync(AppSettings.My_Chat_Id, "Запрос");
        }
    }
}