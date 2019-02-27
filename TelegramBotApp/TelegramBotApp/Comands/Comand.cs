using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelegramBotApp.Models;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBotApp.Comands
{
    public abstract class Comand
    {

        public abstract string Name { get; set; }
        public abstract void Execute(Message message, TelegramBotClient client);
        public bool Contains(string comand)
        {
            return comand.Contains(this.Name) && comand.Contains(AppSetings.Name);
        }

    }
}