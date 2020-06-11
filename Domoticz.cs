using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Verstopper
{
    class Domoticz
    {
        const string baseAddress = "http://127.0.0.1:8080" + "/json.htm";

        public static List<Switch> GetSwitches()
        {
            // Doe een API request naar de link om alle Switches op te halen van Domoticz.
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

            // Geef de beschikbare switches terug als resultaat.
            return switchResult.result;
        }

        public static List<Log> GetLogs(DateTime lastLogTime, int logLevel)
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseAddress + "?type=command&param=getlog&lastlogtime=" + new DateTimeOffset(lastLogTime).ToUnixTimeSeconds().ToString() + "&loglevel=" + logLevel);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Haal de JSON String van deze pagina op.
            String JSONString;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);

                JSONString = reader.ReadToEnd();
            }

            // Veranderd deze JSON String naar een Object dat gebruikt kan worden in de applicatie.
            LogResult logResult = Newtonsoft.Json.JsonConvert.DeserializeObject<LogResult>(JSONString);

            return logResult.result;
        }

        public static void UseSwitch(Switch @switch, SwitchActionEnum action)
        {
            String paramString = "?type=command&param=switchlight&idx=" + @switch.idx + "&switchcmd=" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseAddress + paramString);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

        public static void SendLogMessageToDomoticz(String message)
        {
            String paramString = "?type=command&param=addlogmessage&message=" + message;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseAddress + paramString);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
