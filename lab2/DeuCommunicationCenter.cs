using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class DeuCommunicationCenter
    {
        public string Nick { get; set; } = "";
        public int Age { get; set; } = 0;

        public void WelcomeDeu()
        {
            Console.WriteLine($"\nHerzlich willkommen! Sie wenden sich an das Kommunikationszentrum der Fußballweltmeisterschaft in Katar.");
            Console.Write($"Wie heißen Sie? ");
            Nick = Console.ReadLine();

            Console.Write($"Ausgezeichnet, {Nick}. Wie alt sind Sie? ");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Was möchten Sie gerne erfahren?\n");
        }

        public void ShowScheduleDeu()
        {
            Console.WriteLine($"{Nick}, heute finden 2 Spiele statt:");
            Console.WriteLine("16:40 (MSK) Polen - Saudi-Arabien");
            Console.WriteLine("20:20 (MSK) Iran - USA");
        }

        public void ShowStadiumsDeu()
        {
            Console.WriteLine($"{Nick}, die Weltmeisterschaft findet in Katar an 8 Stadien statt:");
            Console.WriteLine("Lusail-Stadion");
            Console.WriteLine("Al-Bayt-Stadion");
            Console.WriteLine("Stadion 974");
            Console.WriteLine("Al-Thumama-Stadion");
            Console.WriteLine("International Stadium Khalifa");
            Console.WriteLine("Ahmed bin Ali Stadium");
            Console.WriteLine("Al-Janoub Stadium");
            Console.WriteLine("Education City Stadium");
        }

        public void QuestionFanDeu(string message)
        {
            Console.WriteLine($"{Nick}, wir haben Ihre Frage aufgenommen: {message}. Sie wird weitergeleitet und Sie werden später zurückgerufen.");
        }

        public void GoodbyeDeu()
        {
            Console.WriteLine($"Auf Wiedersehen, {Nick}! Wir wünschen Ihnen viel Spaß beim Zuschauen.\n");
        }
    }
}
