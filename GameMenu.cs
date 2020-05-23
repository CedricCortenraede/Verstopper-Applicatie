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
    public partial class GameMenu : Form
    {
        // Moet veranderd worden naar je Domoticz link.
        const string baseAddress = "http://127.0.0.1:8080" + "/json.htm";

        private List<Switch> switches = new List<Switch>();

        private int secondsLeftInGame;
        private bool canHide;

        // Is waarschijnlijk niet nodig aangezien de route via de Domoticz logs opgehaald kunnen worden.
        private Dictionary<DateTime, Switch> path = new Dictionary<DateTime, Switch>();

        public GameMenu(int playingTimeInSeconds)
        {
            InitializeComponent();

            // Haal alle sensoren op via de Demoticz API.
            this.GetMotionSensorsAndPowerUps();

            // Zet het aantal seconden van het spel naar de gespecificeerde tijd.
            // Verder wordt ook aangezet dat de verstopper zich kan gaan verstoppen.
            this.secondsLeftInGame = playingTimeInSeconds;
            this.canHide = true;

            // De tijd wordt gestart
            this.StartGameTimer();

            /*
             * Voorbeeld hoe je switches aan en uit kan zetten.
             * this.UseSwitch(switches[0], SwitchActionEnum.On);
            */
        }

        // API CALLS
        private void GetMotionSensorsAndPowerUps()
        {
            // Doe een API request naar de link om alle Switches op te halen van Demoticz.
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(baseAddress + "?type=command&param=getlightswitches");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            // Haal de JSON String van deze pagina op.
            String JSONString;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                
                JSONString = reader.ReadToEnd();
            }

            // Veranderd deze JSON String naar een Object dat gebruikt kan worden in de applicatie.
            SwitchResult switchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SwitchResult>(JSONString);

            // Zet de beschikbare switches in een globaal beschikbare list.
            switches = switchResult.result;
        }

        private void UseSwitch(Switch @switch, SwitchActionEnum action)
        {
            String paramString = "?type=command&param=switchlight&idx=" + @switch.idx + "&switchcmd=" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseAddress + paramString);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        }

        // GAME
        // TODO:

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
            }
        }
    }
}
