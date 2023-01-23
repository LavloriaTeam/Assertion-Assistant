using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertion_Assistant.Translations
{
    internal class Dict
    {
        Dictionary<string, string> russianWelcomeForm = new Dictionary<string, string>()
        {
            // WelcomeForm - Settings Questions
            ["Welcome to Assertion Assistant"] = "Добро пожаловать в Assertion Assistant",
            ["Let's customize the app for you!"] = "Давайте настроим приложение для вас!",
            ["Specify your name, age and mood that you have most often."] = "Укажите ваше имя, возраст и настроение, которое  у вас чаще всего.",
            ["Choose for what purpose you want to use the application."] = "Выберите с какой целью вы хотите использовать приложение. ",
            ["Great, you've set up all the data, let's move on to use."] = "Отлично, вы настроили все данные, перейдем к использованию.",
            
            // goals
            ["Uplifting the mood"] = "Поднятие настроения",
            ["Motivation to work"] = "Мотивация работать",
            ["Support in difficult situations"] = "Поддержка в сложных ситуациях",
            ["Solving health problems"] = "Решение проблем со здоровьем",
            ["Development motivation"] = "Мотивация развития",
            ["Motivation to go to your dream"] = "Мотивация идти к своей мечте",
        };
    }
}
