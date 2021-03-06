﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Verstopper
{
    public partial class SearchGameMenu : Form
    {
        // Alle switches in Domoticz worden opgeslagen zodat deze makkelijk beschikbaar zijn.
        private List<Switch> switches = new List<Switch>();

        // Alle pictures worden opgeslagen zodat deze makkelijk te benaderen zijn.
        private List<PictureBox> boxList = new List<PictureBox>();

        // Game informatie wordt ook opgeslagen zodat dit makkelijk op te halen is.
        private int secondsLeftInGame = -1;
        private bool gameOver = false;
        private Switch currentSwitch = null;

        private bool canSearch = false;
        private bool foundHider = false;
        private int seekerLives = 3;

        public SearchGameMenu()
        {
            InitializeComponent();

            boxList.Add(pictureBox1);
            boxList.Add(pictureBox2);
            boxList.Add(pictureBox3);
            boxList.Add(pictureBox4);
            boxList.Add(pictureBox5);
            boxList.Add(pictureBox6);
            boxList.Add(pictureBox7);
            boxList.Add(pictureBox8);

            this.switches = Domoticz.GetSwitches();

            this.CheckIfGameStarted();
        }

        // Game

        private void CheckIfGameStarted()
        {
            // Start de timer om te checken of er een Game gestart is in de laatste 5 minuten.
            // Dit wordt elke 30 seconden gecheckt.
            startGameTimer.Interval = 1000 * 30;

            startGameTimer.Start();

            startGameTimer_Tick(null, null);
        }

        private void StartGame()
        {
            this.canSearch = false;
            this.currentSwitch = null;

            // Zorg dat de juisite informatie op het scherm staat.
            timeLeftLabel.Text = "Verstop tijd over:";
            this.DisplayGameTimeLeftOnScreen();

            // De Game timer en het ophalen van de locatie van de zoeker worden gestart.
            this.StartGameThreading();

            this.EnablePictureBoxStatus(false);
        }

        private void StartSearchPartOfGame()
        {
            // Zorg dat de zoeker nu kan zoeken en de tijd gereset wordt.
            this.canSearch = true;
            this.secondsLeftInGame = 60;

            this.EnablePictureBoxStatus(true);


            this.SafelyWriteTextToLabel(timeLeftLabel, "Zoek tijd over:");
            this.DisplayGameTimeLeftOnScreen();
            
            // De verstopper kan zich niet meer verplaatsen, dus de locatie hoeft niet meer bekeken te worden.
            checkHiderLocationTimer.Stop();
        }

        private void StopGame()
        {
            this.EnablePictureBoxStatus(false);

            this.gameOver = true;

            gameTimer.Stop();

            if (this.foundHider)
            {
                MessageBox.Show("Je hebt gewonnen!");

                Domoticz.SendLogMessageToDomoticz("[SEEKER] Won Lives" + this.seekerLives);
            } else
            {
                MessageBox.Show("Je hebt verloren!");

                Domoticz.SendLogMessageToDomoticz("[SEEKER] Lost Lives:" + this.seekerLives);
            }
        }

        private void HiderMovesRoom(Switch @switch)
        {
            if (this.currentSwitch == null || !this.currentSwitch.Equals(@switch))
            {
                if (this.currentSwitch != null)
                {
                    this.boxList[int.Parse(this.currentSwitch.idx) - 1].Image = Properties.Resources.question_mark_40;
                }

                if (this.secondsLeftInGame > 15)
                {
                    this.boxList[int.Parse(@switch.idx) - 1].Image = Properties.Resources.exclamation_mark_40;
                }

                this.currentSwitch = @switch;
            }
        }

        // Timer(s)

        private void startGameTimer_Tick(object sender, EventArgs e)
        {
            // Is de totale aantal seconden zoektijd al gezet, dan wordt de timer gestopt.
            if (this.secondsLeftInGame != -1)
            {
                startGameTimer.Stop();
            }

            // Er gaat gecheckt worden in de logs of er in de laatste 5 minuten een game gestart is.
            // Dit wordt elke seconde gedaan.

            // De logs van de laatste 5 minuten op niveau 2 worden opgehaald.
            List<Log> logs = Domoticz.GetLogs(DateTime.Now - new TimeSpan(0, 5, 0), 2);

            // Er wordt door de logs gezocht naar logs van de Verstop applicatie.
            foreach (Log log in logs)
            {
                String[] words = log.message.Split(' ');

                // Als het niet van de Verstop applicatie komt gaat de volgende log bekeken worden.
                if (! words[4].Equals("[HIDING]")) continue;

                // Als het een bericht is waar het spel niet wordt gestart wordt er naar de volgende gekeken.
                if (!words[5].Equals("Started:")) continue;

                // Nu kan geconcludeerd worden dat op dit moment dat deze log is gemaakt een spel gestart is.
                // De tijd van het starten wordt opgehaald en hoeveel tijd er totaal beschikbaar was.
                DateTime startTime = DateTime.Parse(words[6] + " " + words[7]);
                int totalSecondsForHiding = int.Parse(words[10]);

                // Er wordt nu gekeken naar de start tijd en de tijd beschikbaar hoeveel tijd er nog over is.
                int secondsPassedFromStartTime = (int) DateTime.Now.Subtract(startTime).TotalSeconds;
                int secondsLeftInGame = totalSecondsForHiding - secondsPassedFromStartTime;

                // Als er meer tijd is verstreken dan de zoek tijd betekent dat deze niet meer geldig is, dan kan er naar de volgende log gekeken worden.
                if (secondsPassedFromStartTime > totalSecondsForHiding) continue;

                this.secondsLeftInGame = secondsLeftInGame;

                // De game kan nu gestart worden nu de informatie is opgehaald.
                this.StartGame();

                // De huidige timer kan gestopt worden aangezien een Game gevonden is.
                startGameTimer.Stop();

                break;
            }
        }


        // Multi Threading

        private delegate void ChangeTimeLeftLabel(String text);

        private void StartGameThreading()
        {
            // De Game timer wordt gestart.
            Thread checkGameThread = new Thread(CheckGameTimer);

            // De huidige locatie van de verstopper wordt opgehaald.
            Thread hiderLocationThread = new Thread(CheckHiderLocation);

            checkGameThread.Start();
            hiderLocationThread.Start();
        }

        private void CheckGameTimer()
        {
            Thread.Sleep(1000);

            while (!this.gameOver)
            {

                if (this.secondsLeftInGame > 0)
                {
                    this.secondsLeftInGame--;

                    this.DisplayGameTimeLeftOnScreen();

                    if (secondsLeftInGame <= 15 && !this.canSearch)
                    {
                        foreach (PictureBox box in this.boxList)
                        {
                            box.Image = Properties.Resources.question_mark_40;
                        }
                    }
                }
                else
                {
                    // De huidige Game tijd is afgelopen, er moet nu gecontroleerd worden of het spel in totaal is afgelopen of alleen het verstop gedeelte.
                    if (this.canSearch)
                    {
                        // De zoeker kon zoeken en de timer is afgelopen, dit betekent dat het spel voorbij is.
                        this.StopGame();
                    }
                    else
                    {
                        // De zoeker kon nog niet zoeken, dit betekent dat er verstopt werd.
                        this.StartSearchPartOfGame();
                    }
                }

                Thread.Sleep(1000);
            }
        }

        private void CheckHiderLocation()
        {
            while (!this.canSearch && !this.gameOver)
            {
                // De logs gaan gecontroleerd worden of de verstopper zich verplaatst heeft.
                // Er gaat de laatste seconde gekeken worden na Logs, dit omdat deze method elke seconde herhaalt wordt.
                List<Log> logs = Domoticz.GetLogs(DateTime.Now - new TimeSpan(0, 0, 1), 2);

                // Er wordt door de logs gezocht naar logs van de Verstop applicatie.
                if (logs != null)
                {
                    foreach (Log log in logs)
                    {
                        String[] words = log.message.Split(' ');

                        // Als het niet van de Verstop applicatie komt gaat de volgende log bekeken worden.
                        if (!words[4].Equals("[HIDING]")) continue;

                        // Als het een bericht is waar niet wordt verplaatst wordt er naar de volgende gekeken.
                        if (!words[5].Equals("To:")) continue;

                        string switchID = words[6].Trim(new Char[] { '(', ')' });

                        foreach (Switch @switch in this.switches)
                        {
                            if (@switch.idx.Equals(switchID))
                            {
                                if (this.currentSwitch == null || !this.currentSwitch.Equals(@switch))
                                {
                                    this.HiderMovesRoom(@switch);

                                    break;
                                }
                            }
                        }
                    }
                }

                Thread.Sleep(100);
            }
        }

        // Front end

        private void SafelyWriteTextToLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        label.Text = text;
                    }
                ));
            } else
            {
                label.Text = text;
            }
        }

        private void SafelyChangeImageOfPictureBox(PictureBox box, Image image)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new MethodInvoker(
                    delegate()
                    {
                        box.Image = image;
                    }    
                ));
            } else
            {
                box.Image = image;
            }
        }

        private void SafelyEnablePictureBox(PictureBox box, bool enabled)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        box.Enabled = enabled;
                    }
                ));
            }
            else
            {
                box.Enabled = enabled;
            }
        }

        private void EnablePictureBoxStatus(bool enabled)
        {
            foreach (PictureBox box in boxList)
            {
                this.SafelyEnablePictureBox(box, enabled);
            }
        }

        private void DisplayGameTimeLeftOnScreen()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(this.secondsLeftInGame);

            this.SafelyWriteTextToLabel(gameTimeLeftLabel, timeSpan.ToString(@"mm\:ss"));
        }

        private void Check(Switch @switch)
        {
            PictureBox box = boxList[int.Parse(@switch.idx) - 1];
            box.Enabled = false;

            if (this.currentSwitch.Equals(@switch))
            {
                SafelyChangeImageOfPictureBox(box, Properties.Resources.found_40);

                this.foundHider = true;

                this.StopGame();
            } else
            {
                SafelyChangeImageOfPictureBox(box, Properties.Resources.error_40);

                seekerLives--;

                amountOfLivesLabel.Text = "Aantal levens: " + seekerLives;
            }

            if (seekerLives <= 0)
            {
                this.StopGame();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {             
            Check(this.switches[0]);          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Check(this.switches[1]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Check(this.switches[2]);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Check(this.switches[3]);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Check(this.switches[4]);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Check(this.switches[5]);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Check(this.switches[6]);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Check(this.switches[7]);
        }
    }
}
