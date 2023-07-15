using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class StateGreen : State
    {
        public StateGreen() { }

        public override void DisplayColor(TrafficLight trafficLight)
        {
            Thread.Sleep(_delay);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.ForegroundColor = ConsoleColor.Gray;

            trafficLight.ChangeState(new StateRed());
        }
    }
}
