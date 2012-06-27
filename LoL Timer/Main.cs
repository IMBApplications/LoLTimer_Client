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
            RefreshTimer();

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
                return;
            }

            if (bottomBlue.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartBottomBlue();
                return;
            }

            if (topRed.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartTopRed();
                return;
            }

            if (bottomRed.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartBottomRed();
                return;
            }

            if (dragon.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartDragon();
                return;
            }

            if (baron.Keys.ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartBaron();
                return;
            }

            if (Properties.Settings.Default.InitGame.Split('#').ToList().TrueForAll(x => keys.Contains(x)))
            {
                StartGame();
                return;
            }

            if (Properties.Settings.Default.Reset.Split('#').ToList().TrueForAll(x => keys.Contains(x)))
            {
                ResetTimer();
                return;
            }
        }

        private void StartGame()
        {
            this.topBlue.OverwriteTimer(60 + 55);
            this.bottomBlue.OverwriteTimer(60 + 55);

            this.topRed.OverwriteTimer(60 + 55);
            this.bottomRed.OverwriteTimer(60 + 55);

            this.dragon.OverwriteTimer(6 * 60);
            this.baron.OverwriteTimer(15 * 60);
        }

        private void ResetTimer()
        {
            this.topBlue.ResetTimer();
            this.bottomBlue.ResetTimer();

            this.topRed.ResetTimer();
            this.bottomRed.ResetTimer();

            this.dragon.ResetTimer();
            this.baron.ResetTimer();
        }

        private void StartTopBlue()
        {
            this.topBlue.SetTimer(5 * 60);
        }

        private void StartBottomBlue()
        {
            this.bottomBlue.SetTimer(5 * 60);
        }

        private void StartTopRed()
        {
            this.topRed.SetTimer(5 * 60);
        }

        private void StartBottomRed()
        {
            this.bottomRed.SetTimer(5 * 60);
        }

        private void StartDragon()
        {
            this.dragon.SetTimer(6 * 60);
        }

        private void StartBaron()
        {
            this.baron.SetTimer(7 * 60);
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            RefreshTimer();
        }

        private void RefreshTimer()
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
