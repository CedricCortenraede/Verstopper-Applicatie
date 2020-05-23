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
        HttpClient client = new HttpClient();
        const string baseAddress = "http://127.0.0.1:8080/json.htm";

        private List<Switch> switches = new List<Switch>();

        private int secondsLeftInGame;
        private bool canHide;
        private Dictionary<DateTime, string> path = new Dictionary<DateTime, string>();

        public GameMenu(int playingTimeInSeconds)
        {
            InitializeComponent();

            this.GetMotionSensorsAndPowerUps();

            this.secondsLeftInGame = playingTimeInSeconds;
            this.canHide = true;

            this.StartGameTimer();

            this.UseSwitch(switches[0], SwitchActionEnum.On);
        }

        // API CALLS
        private void GetMotionSensorsAndPowerUps()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(baseAddress + "?type=command&param=getlightswitches");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            String JSONString;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                
                JSONString = reader.ReadToEnd();
            }

            SwitchResult switchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SwitchResult>(JSONString);

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
            gameTimer.Interval = 1000;
            gameTimer.Start();

            this.DisplayGameTimeLeftOnScreen();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.secondsLeftInGame--;
            this.DisplayGameTimeLeftOnScreen();

            if (secondsLeftInGame <= 0)
            {
                this.canHide = false;

                gameTimer.Stop();

                gameTimeLeftLabel.Text = "Afgelopen";
            }
        }
    }
}
