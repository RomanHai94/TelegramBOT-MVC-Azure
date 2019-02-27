using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBotApp.Comands;

namespace TelegramBotApp.Models
{
    public static class Bot
    {

        private static TelegramBotClient client;
        private static List<Comand> commandsList;

        public static IReadOnlyList<Comand> Comands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            if(client != null)
            {
                return client;
            }

            commandsList = new List<Comand>();
            commandsList.Add(new HelloComand());

            client = new TelegramBotClient(AppSetings.Key);
            var hook = String.Format(AppSetings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);

            return client;

        }

    }
}