//Web API 2 Controller - Empty
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using esp8266_pin.Models;


namespace esp8266_pin.Controllers
{
    public class MessageController : ApiController
    {
        /*Путь может быть любым... при обращении по этому маршруту
        * будет обрабатываться информация, присланная телеграммом
        */
        [Route(@"api/message/update")] //webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)//API тип, в котором                                                  
        {                                                           //хранится актуальная инфа по боту
                                                                    //например: сообщения, команды
            var commands = Bot.Commands;//список доступных команд
            var message = update.Message;
            var client = await Bot.Get();

            foreach(var commandbot in commands)
            {
                if(commandbot.Comparison(message.Text))
                {
                    commandbot.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}
