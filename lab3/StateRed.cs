using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class StateRed : State
    {
        public StateRed() { }

        public override void DisplayColor(TrafficLight trafficLight)
        {
            Thread.Sleep(_delay);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ForegroundColor = ConsoleColor.Gray;

            trafficLight.ChangeState(new StateYellow());
        }
    }
}
