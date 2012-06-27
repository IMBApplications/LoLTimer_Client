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
            private set
            {
                _timer = value;
            }
        }

        public void SetTimer(int timer)
        {
            if (!Properties.Settings.Default.OverwriteTimer && _timer > 0)
            {
                return;
            }

            this.Timer = timer;
        }

        public void OverwriteTimer(int timer)
        {
            this.Timer = timer;
        }

        public void ResetTimer()
        {
            this.Timer = 0;
        }

        public TimerProfile()
        {
            Timer = 0;
        }
    }
}
