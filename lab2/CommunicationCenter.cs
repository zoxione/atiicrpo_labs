using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    abstract public class CommunicationCenter
    {
        public abstract void Welcome();

        public abstract void ShowSchedule();

        public abstract void ShowStadiums();

        public abstract void QuestionFan(string message);

        public abstract void Goodbye();
    }
}
