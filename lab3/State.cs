using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class State
    {
        protected int _delay = 0;

        protected State() { }

        public void ChangeDelay(int d) 
        { 
            _delay = d;
        }

        public virtual void DisplayColor(TrafficLight tl) { }
    }
}
