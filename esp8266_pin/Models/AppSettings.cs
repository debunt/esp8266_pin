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

        //API ключ нашего бота
        public static string Key { get; set; } = "452678815:AAH9tO6xF_1XMapgCZ_f0oqrewQa9L05dfU";
    }
}