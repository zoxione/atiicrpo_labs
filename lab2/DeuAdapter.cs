using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class DeuAdapter : CommunicationCenter
    {
        private DeuCommunicationCenter _communicationCenter = new DeuCommunicationCenter();

        public override void Welcome()
        {
            _communicationCenter.WelcomeDeu();
        }

        public override void ShowSchedule()
        {
            _communicationCenter.ShowScheduleDeu();
        }

        public override void ShowStadiums()
        {
            _communicationCenter.ShowStadiumsDeu();
        }

        public override void QuestionFan(string message)
        {
            _communicationCenter.QuestionFanDeu(message);
        }

        public override void Goodbye()
        {
            _communicationCenter.GoodbyeDeu();
        }
    }
}
