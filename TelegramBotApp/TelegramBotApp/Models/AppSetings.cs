using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public static class AppSetings
    {

        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:443/{0}";
        public static string Name { get; set; } = "Rom4n_bot";
        public static string Key { get; set; }

    }
}