using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class TrafficLight
    {
        private State _state;

        public TrafficLight(State st)
        {
            _state = st;
        }

        // Измение состояния
        public void ChangeState(State st)
        {
            _state = st;
        }

        // Отображение цвета (делегирование, мы не знаем что там)
        public void DisplayColor(int delay = 0)
        {
            if (_state != null)
            {
                _state.ChangeDelay(delay);
                _state.DisplayColor(this);
            }
        }
    }
}
