using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace IMBApplication.Lol.Timer
{
    public partial class Main : Form
    {
        private static List<Key> keySet = new List<Key>();
        private KeyboardListener KListener = new KeyboardListener();

        private TimerProfile topBlue = new TimerProfile();
        private TimerProfile bottomBlue = new TimerProfile();

        private TimerProfile topRed = new TimerProfile();
        private TimerProfile bottomRed = new TimerProfile();

        private TimerProfile dragon = new TimerProfile();
        private TimerProfile baron = new TimerProfile();

        public Main()
        {
            InitializeComponent();

            KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);
            KListener.KeyUp += new RawKeyEventHandler(KListener_KeyUp);

            topBlue.Keys = Properties.Settings.Default.TopBlue.Split('#');
            bottomBlue.Keys = Properties.Settings.Default.BottomBlue.Split('#');
            topRed.Keys = Properties.Settings.Default.TopRed.Split('#');
            bottomRed.Keys = Properties.Settings.Default.BottomRed.Split('#');
            dragon.Keys = Properties.Settings.Default.Dragon.Split('#');
            baron.Keys = Properties.Settings.Default.Baron.Split('#');

            ticker.Start();
            ticker_Tick(null, null);

            int x = (Screen.PrimaryScreen.Bounds.Width / 2) - this.Width / 2;
            this.Location = new Point(x, 0);
        }

        #region GlobalKeyListener
        private void KListener_KeyDown(object sender, RawKeyEventArgs e)
        {
            if (!keySet.Contains(e.Key))
            {
                keySet.Add(e.Key);
            }
        }

        private void KListener_KeyUp(object sender, RawKeyEventArgs e)
        {
            string keysDown = string.Empty;
            if (keySet.Count != 0)
            {
                for (int i = 0; i < keySet.Count; i++)
                {
                    System.Windows.Input.Key key = keySet[i];
                    keysDown += (i != (keySet.Count - 1)) ? key.ToString() + "+" : key.ToString();
                }
                keySet.Clear();
            }

            GlobalKeyIntercepted(keysDown);
        } 
        #endregion

        private void GlobalKeyIntercepted(String keys)
        {
            if (topBlue.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartTopBlue();
            }

            if (bottomBlue.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartBottomBlue();
            }

            if (topRed.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartTopRed();
            }

            if (bottomRed.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartBottomRed();
            }

            if (dragon.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartDragon();
            }

            if (baron.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartBaron();
            }
        }

        private void StartTopBlue()
        {
            this.topBlue.Timer = 5 * 60;
        }

        private void StartBottomBlue()
        {
            this.bottomBlue.Timer = 5 * 60;
        }

        private void StartTopRed()
        {
            this.topRed.Timer = 5 * 60;
        }

        private void StartBottomRed()
        {
            this.bottomRed.Timer = 5 * 60;
        }

        private void StartDragon()
        {
            this.dragon.Timer = 6 * 60;
        }

        private void StartBaron()
        {
            this.baron.Timer = 7 * 60;
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            lblTopBlue.Text = this.topBlue.Timer.ToString();
            lblBottomBlue.Text = this.bottomBlue.Timer.ToString();

            lblTopRed.Text = this.topRed.Timer.ToString();
            lblBottomRed.Text = this.bottomRed.Timer.ToString();

            lblBaron.Text = this.baron.Timer.ToString();
            lblDragon.Text = this.dragon.Timer.ToString();
        }
    }
}
