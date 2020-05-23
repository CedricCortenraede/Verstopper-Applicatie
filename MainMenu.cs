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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            // Wanneer er op de knop wordt geklikt wordt er opgehaald hoeveel minuten er is ingevuld en wordt dit doorgegeven aan het Game scherm.
            GameMenu gameMenu = new GameMenu((int) gameTimeNumber.Value * 60);
            gameMenu.Show();
        }
    }
}
