using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class RusCommunicationCenter
    {
        public string Nickname { get; set; } = "";
        public int FanYears { get; set; } = 0;

        public void WelcomeRu()
        {
            Console.WriteLine($"\nДобро пожаловать! Вы обращает в Центр коммуникации Чемпионата мира по футболу в Катаре.");
            Console.Write($"Как вас зовут? ");
            Nickname = Console.ReadLine();

            Console.Write($"Отлично, {Nickname}. Сколько вам лет? ");
            FanYears = int.Parse(Console.ReadLine());

            Console.WriteLine($"Хорошо, что вы хотели узнать?\n");
        }

        public void ShowScheduleRu()
        {
            Console.WriteLine($"{Nickname}, сегодня будет 2 матча:");
            Console.WriteLine("16:40(МСК) Польша - Саудовская Аравия");
            Console.WriteLine("20:20(МСК) Иран - США");
        }

        public void ShowStadiumsRu()
        {
            Console.WriteLine($"{Nickname}, Чемпионат мира проходит в Катаре на 8 стадионах:");
            Console.WriteLine("Стадион «Лусаил»");
            Console.WriteLine("Стадион «Аль Байт»");
            Console.WriteLine("Стадион 974");
            Console.WriteLine("Стадион «Аль Тумама»");
            Console.WriteLine("Международный стадион «Халифа»");
            Console.WriteLine("Стадион «Ахмед Бин Али»");
            Console.WriteLine("Стадион «Аль Джануб»");
            Console.WriteLine("Стадион «Эдьюкэйшн Сити»");
        }

        public void QuestionFanRu(string message)
        {
            Console.WriteLine($"{Nickname}, мы записали ваш вопрос: {message}. Он будет передан и позже вам перезвонят.");
        }

        public void GoodbyeRu()
        {
            Console.WriteLine($"До свидания, {Nickname}! Желаем приятного просмотра.\n");
        }
    }
}
