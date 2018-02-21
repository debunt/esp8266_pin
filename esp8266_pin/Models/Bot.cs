using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using esp8266_pin.Models.Commands;

/// <summary>
/// Первичная инициализация Бота и его команд
/// </summary>
namespace esp8266_pin.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandsLists;
        //лист, хранящий коллекцию команд только для чтения
        public static IReadOnlyList<Command> Commands => commandsLists.AsReadOnly();

        //асинхронный метод GET, который будет возвращать экземпляр клиента
        public static async Task<TelegramBotClient> Get()
        {
            //проверка: заинициализировано ли наше поле, если да - возвращаем клиент
            if(client != null)
            {
                return client;
            }
            //иначе создаем новый экземляр с API ключем

            //инициализируем коллекцию всех! команд
            commandsLists = new List<Command>();
            commandsLists.Add(new HelloCommand());
            commandsLists.Add(new StartCommand());
            //commandsLists.Add(new TextMessageProcessor());
            commandsLists.Add(new SubscribeCommand());
            //TODO: Add more commands


            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);//Ожидание прихода новых сообщений
            //Используйте этот метод, чтобы указать URL-адрес и получать входящие обновления через 
            //исходящий веб-сайт. Всякий раз, когда для бота имеется Telegram.Bot.Types.Update, 
            //мы отправим запрос POST HTTPS на указанный URL-адрес, содержащий сериализованное 
            //JSON обновление. В случае неудачного запроса мы сдадимся после разумного количества 
            //попыток. Если вы хотите убедиться, что запрос Webhook поступает из Telegram, мы 
            //рекомендуем использовать секретный путь в URL-адресе, 
            //например. https://www.example.com/ <лексема>. Поскольку никто другой не знает маркера 
            //вашего бота, вы можете быть уверены, что это мы.

            return client;
        }
    }
}