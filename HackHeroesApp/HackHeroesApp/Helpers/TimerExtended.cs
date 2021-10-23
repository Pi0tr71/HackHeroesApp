using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace HackHeroesApp.Helpers
{
    public class TimerExtended
    {
        Timer timer;

        public TimerExtended(int time)
        {
            this.timer = new Timer((double)time * 1000);
            timer.Start();
        }
    }
}
