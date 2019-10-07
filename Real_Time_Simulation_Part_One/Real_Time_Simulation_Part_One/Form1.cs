using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Time_Simulation_Part_One
{
    public partial class frmRTS : Form
    {
        GameEngine engine;
        Timer timer;
        GameState gameState = GameState.PAUSED;

        public frmRTS()
        {
            InitializeComponent();

            engine = new GameEngine();
            lblMap.Text = engine.GetMapDisplay();
            rtbUnitInfo.Text = "Round: " + engine.Round;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
        }

        private void TimerTick (object sender, EventArgs e)
        {
            engine.GameLoop();
            UpdateUI();

            if (engine.IsGameOver)
            {
                timer.Stop();
                lblMap.Text = engine.WinningFaction + " WON!\n" + lblMap.Text;
                gameState = GameState.ENDED;
                btnStartPauseSim.Text = "Reset";
            }
        }

        private void UpdateUI()
        {
            lblMap.Text = engine.GetMapDisplay();
            rtbUnitInfo.Text = engine.GetUnitInfo();
            lblRound.Text = "Round: " + engine.Round;
        }

        /*private void btnStart_Click(object sender, EventArgs e)
        {
            battlefield.InitializeMap();
            battlefield.ShowBattlefield(lblMap);
            battlefield.DisplayInformation(txtInfoBox);
            if (isPaused == false)
            {
                ge.Ticker(lblRound);
            }
            else
            {

            }
        }*/

        private void btnStartPauseSim_Click(object sender, EventArgs e)
        {
            if (gameState == GameState.RUNNING)
            {
                timer.Stop();
                gameState = GameState.PAUSED;
                btnStartPauseSim.Text = "Start";
            }
            else
            {
                if (gameState == GameState.ENDED)
                {
                    engine.Reset();
                }
                timer.Start();
                gameState = GameState.RUNNING;
                btnStartPauseSim.Text = "Pause";
            }
        }

        public enum GameState
        {
            RUNNING,
            PAUSED,
            ENDED
        }
    }
}
