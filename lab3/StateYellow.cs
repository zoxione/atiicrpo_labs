using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class StateYellow : State
    {
        public StateYellow() { }

        public override void DisplayColor(TrafficLight trafficLight)
        {
            Thread.Sleep(_delay);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow");
            Console.ForegroundColor = ConsoleColor.Gray;

            trafficLight.ChangeState(new StateGreen());
        }
    }
}
