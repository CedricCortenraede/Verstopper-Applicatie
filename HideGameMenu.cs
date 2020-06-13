using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verstopper
{
    public partial class HideGameMenu : Form
    {
        // De Domoticz link, moet evt. per persoon veranderd worden.
        const string baseAddress = "http://127.0.0.1:8080" + "/json.htm";

        // Alle switches in Domoticz worden opgeslagen zodat deze makkelijk beschikbaar zijn.
        private List<Switch> switches = new List<Switch>();

        // Game informatie wordt ook opgeslagen zodat dit makkelijk op te halen is.
        public int secondsLeftInGame = 0;
        private bool canHide = false;
        private Switch currentSwitch = null;

        public HideGameMenu(int playingTimeInSeconds)
        {
            InitializeComponent();

            // Haal alle sensoren op via de Domoticz API.
            this.switches = Domoticz.GetSwitches();

            // Doe alle switches uitzetten zodat deze niet al aanstaan voordat het spel begint.
            this.TurnOffAllSwitches();

            // Stuur een bericht naar Domoticz dat het verstoppen begint, zo kan dit in de zoekapplicatie gekeken worden wanneer het spel begonnen is.
            Domoticz.SendLogMessageToDomoticz("[HIDING] Started: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ", Game length: " + playingTimeInSeconds + " seconds");

            // Zet het aantal seconden van het spel naar de gespecificeerde tijd.
            this.secondsLeftInGame = playingTimeInSeconds;

            // De tijd wordt gestart
            this.StartGameTimer();

            // Verder wordt ook aangezet dat de verstopper zich kan gaan verstoppen.
            this.canHide = true;
        }

        // GAME
        private void TurnOffAllSwitches()
        {
            foreach(Switch @switch in this.switches)
            {
                Domoticz.UseSwitch(@switch, SwitchActionEnum.Off);
            }
        }

        private void GoToRoom(Switch @switch)
        {
            // Check of de verstopper zich nog kan verstoppen, zo niet wordt er een bericht gestuurd en wordt de code verder niet uitgevoerd.
            if (!this.canHide)
            {
                MessageBox.Show("Je kan je niet meer verder verstoppen! De tijd is namelijk afgelopen.", "Stop met verstoppen!");
                return;
            }

            // Huidige switch uitzetten
            if (this.currentSwitch != null)
            {
                Domoticz.UseSwitch(this.currentSwitch, SwitchActionEnum.Off);
            }

            // Nieuwe switch aanzetten
            Domoticz.UseSwitch(@switch, SwitchActionEnum.On);

            Domoticz.SendLogMessageToDomoticz("[HIDING] To: " + @switch.Name + " (" + @switch.idx + ")");

            this.currentSwitch = @switch;
        }

        // GAME TIMER
        private void DisplayGameTimeLeftOnScreen()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(this.secondsLeftInGame);

            gameTimeLeftLabel.Text = timeSpan.ToString(@"mm\:ss");
        }

        private void StartGameTimer()
        {
            // Zet de Timer refresh time op elke seconde.
            gameTimer.Interval = 1000;
            gameTimer.Start();

            // Zet de juiste resterende tijd op het scherm.
            this.DisplayGameTimeLeftOnScreen();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Doe een seconden van de game tijd aftrekken en update de resterende tijd op het scherm.
            this.secondsLeftInGame--;
            this.DisplayGameTimeLeftOnScreen();

            if (secondsLeftInGame <= 0)
            {
                // Wanneer de tijd is afgelopen kan de verstopper zich niet meer verder bewegen en wordt de timer gestopt.
                // Verder wordt ook bij de resterende tijd afgelopen weergegeven.
                this.canHide = false;

                gameTimer.Stop();

                gameTimeLeftLabel.Text = "Afgelopen";

                Domoticz.SendLogMessageToDomoticz("[HIDING] Ended, Current room: " + this.currentSwitch.Name + " (" + this.currentSwitch.idx + ")");
            }
        }

        private void kamer1btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[0]);
        }

        private void kamer2btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[1]);
        }

        private void kamer3btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[2]);
        }

        private void kamer4btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[3]);
        }

        private void kamer5btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[4]);
        }

        private void kamer6btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[5]);
        }

        private void kamer7btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[6]);
        }

        private void kamer8btn_Click(object sender, EventArgs e)
        {
            this.GoToRoom(this.switches[7]);
        }
    }
}
