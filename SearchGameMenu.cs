using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verstopper
{
    public partial class SearchGameMenu : Form
    {
        // Alle switches in Domoticz worden opgeslagen zodat deze makkelijk beschikbaar zijn.
        private List<Switch> switches = new List<Switch>();

        // Game informatie wordt ook opgeslagen zodat dit makkelijk op te halen is.
        private int totalSearchTime = -1;
        private int secondsLeftInGame = -1;
        private bool canSearch = false;
        private Switch currentSwitch = null;

        public SearchGameMenu()
        {
            InitializeComponent();

            this.switches = Domoticz.GetSwitches();

            this.CheckIfGameStarted();
        }

        private void CheckIfGameStarted()
        {
            startGameTimer.Interval = 1000;
            startGameTimer.Start();
        }

        private void DisplayGameTimeLeftOnScreen()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(this.secondsLeftInGame);

            gameTimeLeftLabel.Text = timeSpan.ToString(@"mm\:ss");
        }

        private void startGameTimer_Tick(object sender, EventArgs e)
        {
            if (secondsLeftInGame == 0)
            {
                if (!this.canSearch)
                {
                    timeLeftLabel.Text = "Zoek tijd over:";

                    this.canSearch = true;
                    this.secondsLeftInGame = this.totalSearchTime;
                } else
                {
                    // TODO: STOP SPEL
                }
            } else if (secondsLeftInGame == -1) 
            {
                List<Log> logs = Domoticz.GetLogs(DateTime.Now - new TimeSpan(0, 5, 0), 2);

                foreach (Log log in logs)
                {
                    String[] words = log.message.Split(' ');

                    if (!words[4].Equals("[HIDING]")) continue;

                    if (!words[5].Equals("Started:")) continue;

                    DateTime startTime = DateTime.Parse(words[6] + " " + words[7]);
                    int secondsForHiding = int.Parse(words[10]);
                    int secondsPassed = (int) DateTime.Now.Subtract(startTime).TotalSeconds;

                    this.totalSearchTime = secondsForHiding;
                    this.secondsLeftInGame = secondsForHiding - secondsPassed;

                    timeLeftLabel.Text = "Verstop tijd over:";
                }
            } else
            {
                secondsLeftInGame--;
                this.DisplayGameTimeLeftOnScreen();
            }
        }

        private void checkHiderLocationTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
