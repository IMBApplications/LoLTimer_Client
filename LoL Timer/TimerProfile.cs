using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMBApplication.Lol.Timer
{
    public class TimerProfile
    {
        public String[] Keys { get; set; }

        private int _timer;
        public int Timer
        {
            get
            {
                if (_timer > 0)
                {
                    _timer--;
                }

                return _timer;
            }
            set
            {
                if (!IMBApplication.Lol.Timer.Properties.Settings.Default.OverwriteTimer && _timer > 0)
                {
                    return;
                }

                _timer = value;
            }
        }

        public TimerProfile()
        {
            Timer = 0;
        }
    }
}
