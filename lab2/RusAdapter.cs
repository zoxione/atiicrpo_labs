using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class RusAdapter : CommunicationCenter
    {
        private RusCommunicationCenter _communicationCenter = new RusCommunicationCenter();
       
        public override void Welcome()
        {
            _communicationCenter.WelcomeRu();
        }

        public override void ShowSchedule()
        {
            _communicationCenter.ShowScheduleRu();
        }

        public override void ShowStadiums()
        {
            _communicationCenter.ShowStadiumsRu();
        }

        public override void QuestionFan(string message)
        {
            _communicationCenter.QuestionFanRu(message);
        }

        public override void Goodbye()
        {
            _communicationCenter.GoodbyeRu();
        }
    }
}
