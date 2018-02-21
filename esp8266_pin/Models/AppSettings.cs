using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace esp8266_pin.Models
{
    //статичный класс
    public static class AppSettings
    {
        // перечислим некоторые свойства данного класса

        //URL, содержащий конечную ссылку на наш опубликованный бот
        public static string Url { get; set; } = "https://esp8266p.azurewebsites.net:443/{0}";

        //название контакта нашего бота
        public static string Name { get; set; } = "esp8266_pin_bot";

        //API ключ нашего бота... Для того, чтобы защитить этот ключ после развертывания на каком-либо сервере,
        //файл конфигурации необходимо ограничить правами доступа!
        public static string Key { get; set; } = Properties.Settings.Default.token;

        /// <summary>
        /// Название управляемой платы
        /// </summary>
        public static string Name_board { get; set; } = "ESP8266";

        /// <summary>
        /// Мой чат id для отправки мне сообщений. Заполняется после подписки
        /// </summary>
        public static long My_Chat_Id { get; set; } = 0;
    }
}