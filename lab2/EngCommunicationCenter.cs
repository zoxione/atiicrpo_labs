using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class EngCommunicationCenter : CommunicationCenter
    {
        public string FanName { get; set; } = "";
        public int FanAge { get; set; } = 0;

        public override void Welcome()
        {
            Console.WriteLine($"\nWelcome! You are contacting the Communication Center of the FIFA World Cup in Qatar.");
            Console.Write($"What is your name? ");
            FanName = Console.ReadLine();

            Console.Write($"Great, {FanName}. How old are you? ");
            FanAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"What would you like to know?\n");
        }

        public override void ShowSchedule()
        {
            Console.WriteLine($"{FanName}, there will be 2 matches today:");
            Console.WriteLine("16:40 (Moscow time) Poland - Saudi Arabia");
            Console.WriteLine("20:20 (Moscow time) Iran - USA");
        }

        public override void ShowStadiums()
        {
            Console.WriteLine($"{FanName}, the World Cup is taking place in Qatar across 8 stadiums:");
            Console.WriteLine("Lusail Stadium");
            Console.WriteLine("Al Bayt Stadium");
            Console.WriteLine("Stadium 974");
            Console.WriteLine("Al Thumama Stadium");
            Console.WriteLine("Khalifa International Stadium");
            Console.WriteLine("Ahmed bin Ali Stadium");
            Console.WriteLine("Al Janoub Stadium");
            Console.WriteLine("Education City Stadium");
        }

        public override void QuestionFan(string message)
        {
            Console.WriteLine($"{FanName}, we have recorded your question: {message}. It will be passed on and someone will call you back later.");
        }

        public override void Goodbye()
        {
            Console.WriteLine($"Goodbye, {FanName}! Have a pleasant viewing experience.\n");
        }
    }
}
